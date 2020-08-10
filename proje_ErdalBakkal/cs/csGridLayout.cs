using DevExpress.XtraGrid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace proje_ErdalBakkal.cs
{
  class csGridLayout : IDisposable
  {
    internal enum enGridArayuzIslemleri { Set, Get };
    private Control _gelenForm;
    private int _kullaniciID;
    private SqlConnection _baglanti;
    private SqlTransaction trGenel;
    private enGridArayuzIslemleri _islem;

    public csGridLayout(enGridArayuzIslemleri islem, Control gelenForm, int kullaniciID, SqlConnection baglanti)
    {
      try
      {
        _islem = islem;
        _gelenForm = gelenForm;
        _kullaniciID = kullaniciID;
        _baglanti = baglanti;

        trGenel = _baglanti.BeginTransaction();
        FormdakiGridleriBul(gelenForm, islem);
        trGenel.Commit();
      }
      catch (Exception hata)
      {
        trGenel.Rollback();
        throw new Exception("Hata Kodu : " + hata.Message + "\n\nHata Detay : " + hata.StackTrace);
      }
    }
    private void FormdakiGridleriBul(Control nesne, enGridArayuzIslemleri islem)
    {
      if (nesne is DevExpress.XtraGrid.GridControl)
      {
        if (islem == enGridArayuzIslemleri.Set)
          GridArayuzleriKaydet(nesne);
        else
          GridArayuzleriYukle(nesne);
      }

      foreach (Control altnesne in nesne.Controls)
        FormdakiGridleriBul(altnesne, islem);
    }
    void GridArayuzleriKaydet(Control ctrl)
    {
      var gc = new GridControl();
      gc = ctrl as DevExpress.XtraGrid.GridControl;
      var gv = (DevExpress.XtraGrid.Views.Grid.GridView)gc.Views[0];

      string Layout = "";
      using (var ms = new MemoryStream())
      {
        gv.SaveLayoutToStream(ms);
        ms.Position = 0;
        using (var reader = new StreamReader(ms))
          Layout = reader.ReadToEnd();
      }

      InsertLayout(_kullaniciID, _gelenForm.Name, gv.Name, Layout, _baglanti, trGenel);
    }
    void GridArayuzleriYukle(Control ctrl)
    {
      var gc = new GridControl();
      gc = ctrl as DevExpress.XtraGrid.GridControl;
      var gv = (DevExpress.XtraGrid.Views.Grid.GridView)gc.Views[0];

      MemoryStream ms = GetLayout(_kullaniciID, _gelenForm.Name, gv.Name, _baglanti, trGenel);
      if (ms.Length > 0)
        gv.RestoreLayoutFromStream(ms);
    }
    public static MemoryStream GetLayout(int KullaniciID, string FormName, string GridName, SqlConnection Baglanti, SqlTransaction trGenel)
    {
      var ms = new MemoryStream();
      using (var cmd = new SqlCommand("select GridLayout from GridLayout where KullaniciID=@KullaniciID and FormName=@FormName AND GridName=@GridName ", Baglanti, trGenel))
      {
        cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = KullaniciID;
        cmd.Parameters.Add("@FormName", SqlDbType.NVarChar).Value = FormName;
        cmd.Parameters.Add("@GridName", SqlDbType.NVarChar).Value = GridName;
        using (SqlDataReader dr = cmd.ExecuteReader())
        {
          if (dr.Read())
          {
            string data = dr["GridLayout"].ToString();
            byte[] buffer = System.Text.Encoding.ASCII.GetBytes(data);
            ms.Write(buffer, 0, buffer.Length);
            ms.Seek(0, SeekOrigin.Begin);
          }
        }
      }
      return ms;
    }
    public static void InsertLayout(int KullaniciID, string FormName, string GridName, string GridLayout, SqlConnection Baglanti, SqlTransaction trGenel)
    {
      string GridLayoutID = "-1";
      try
      {
        using (SqlCommand cmd = new SqlCommand("Select GridLayoutID From GridLayout Where KullaniciID=@KullaniciID AND FormName=@FormName AND GridName=@GridName", Baglanti, trGenel))
        {
          cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = KullaniciID;
          cmd.Parameters.Add("@FormName", SqlDbType.NVarChar).Value = FormName;
          cmd.Parameters.Add("@GridName", SqlDbType.NVarChar).Value = GridName;
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            if (dr.Read())
              GridLayoutID = dr["GridLayoutID"].ToString();
        }
        if (GridLayoutID != "-1")
        {
          using (SqlCommand cmd = new SqlCommand("Update GridLayout SET GridLayout=@GridLayout  Where KullaniciID=@KullaniciID AND FormName=@FormName AND GridName=@GridName", Baglanti, trGenel))
          {
            cmd.Parameters.Add("@GridLayout", SqlDbType.NVarChar).Value = GridLayout;

            cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = KullaniciID;
            cmd.Parameters.Add("@FormName", SqlDbType.NVarChar).Value = FormName;
            cmd.Parameters.Add("@GridName", SqlDbType.NVarChar).Value = GridName;
            cmd.ExecuteNonQuery();
          }
        }
        else
        {
          using (SqlCommand cmd = new SqlCommand("Insert Into GridLayout(KullaniciID,FormName,GridName,GridLayout) Values(@KullaniciID,@FormName,@GridName,@GridLayout)", Baglanti, trGenel))
          {
            cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = KullaniciID;
            cmd.Parameters.Add("@FormName", SqlDbType.NVarChar).Value = FormName;
            cmd.Parameters.Add("@GridName", SqlDbType.NVarChar).Value = GridName;
            cmd.Parameters.Add("@GridLayout", SqlDbType.NVarChar).Value = GridLayout;
            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception)
      {
      }
    }
    public static void LayoutClear(int KullaniciID, string FormName, string GridName, SqlConnection Baglanti)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("Delete From  GridLayout where KullaniciID=@KullaniciID and FormName=@FormName AND GridName=@GridName ", Baglanti))
        {
          cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = KullaniciID;
          cmd.Parameters.Add("@FormName", SqlDbType.NVarChar).Value = FormName;
          cmd.Parameters.Add("@GridName", SqlDbType.NVarChar).Value = GridName;
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception hata)
      {
        throw new Exception(hata.Message);
      }
    }
    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}
