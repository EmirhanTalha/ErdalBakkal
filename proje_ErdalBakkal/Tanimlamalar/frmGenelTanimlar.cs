using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;

namespace proje_ErdalBakkal.Tanimlamalar
{
  public partial class frmGenelTanimlar : DevExpress.XtraEditors.XtraUserControl
  {
    public frmGenelTanimlar()
    {
      InitializeComponent();
    }

    private void frmIKGenelTanimlar_Load(object sender, EventArgs e)
    {
      try
      {
        #region lkpCari
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select CariID, CariTanim From Cari  order by CariTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpPerakendeCari.Properties.DataSource = dt;
          lkpPerakendeCari.Properties.PopulateColumns();
          lkpPerakendeCari.Properties.ValueMember = "CariID";
          lkpPerakendeCari.Properties.DisplayMember = "CariTanim";

          lkpPerakendeCari.Properties.Columns["CariID"].Visible = false;
          lkpPerakendeCari.Properties.Columns["CariTanim"].Caption = @"Cari Tanım";
          lkpPerakendeCari.EditValue = -1;
        }
        #endregion

        #region lkpKasa
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select KasaID, KasaTanim From Kasa  order by KasaTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpHizliSatisKasa.Properties.DataSource = dt;
          lkpHizliSatisKasa.Properties.PopulateColumns();
          lkpHizliSatisKasa.Properties.ValueMember = "KasaID";
          lkpHizliSatisKasa.Properties.DisplayMember = "KasaTanim";

          lkpHizliSatisKasa.Properties.Columns["KasaID"].Visible = false;
          lkpHizliSatisKasa.Properties.Columns["KasaTanim"].Caption = @"Kasa Tanım";
          lkpHizliSatisKasa.EditValue = -1;
        }
        #endregion

        using (var cmd = new SqlCommand(@"SELECT     SatisSonundaOnayiIste, StokEksiyeInebilsin, HizliSatisTuslariAktif, HizliSatisIskontoYapilabilsin, PerakendeCariID, HizliSatisKasaID, MailSmtpAdresi, MailAdresi, MailSifre, MailPort, MailHost
FROM         dbo.GenelTanimlar", cs.csBaglanti.BaglantiGetir()))
        {
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            if (dr.Read())
            {
              ceSatisSonundaOnayiIste.Checked = (bool)dr["SatisSonundaOnayiIste"];
              ceStokEksiyeInebilsin.Checked = (bool)dr["StokEksiyeInebilsin"];
              ceHizliSatisTuslariAktif.Checked = (bool)dr["HizliSatisTuslariAktif"];
              ceHizliSatisIskontoYapilabilsin.Checked = (bool)dr["HizliSatisIskontoYapilabilsin"];
              lkpPerakendeCari.EditValue=(int)dr["PerakendeCariID"];
              lkpHizliSatisKasa.EditValue = (int)dr["HizliSatisKasaID"];

              txtMailSmtpAdresi.Text = dr["MailSmtpAdresi"].ToString();
              txtMailAdresi.Text = dr["MailAdresi"].ToString();
              txtMailSifre.Text = dr["MailSifre"].ToString();
              txtMailPort.Text = dr["MailPort"].ToString();
              txtMailHost.Text = dr["MailHost"].ToString();
            }
          }
        }
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        using (var cmd = new SqlCommand(@"Update GenelTanimlar SET SatisSonundaOnayiIste=@SatisSonundaOnayiIste, StokEksiyeInebilsin=@StokEksiyeInebilsin, HizliSatisTuslariAktif=@HizliSatisTuslariAktif, HizliSatisIskontoYapilabilsin=@HizliSatisIskontoYapilabilsin, PerakendeCariID=@PerakendeCariID, HizliSatisKasaID=@HizliSatisKasaID, 
        MailSmtpAdresi=@MailSmtpAdresi, MailAdresi=@MailAdresi, MailSifre=@MailSifre, MailPort=@MailPort, MailHost=@MailHost", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@SatisSonundaOnayiIste", SqlDbType.Bit).Value = ceSatisSonundaOnayiIste.Checked;
          cmd.Parameters.Add("@StokEksiyeInebilsin", SqlDbType.Bit).Value = ceStokEksiyeInebilsin.Checked;
          cmd.Parameters.Add("@HizliSatisTuslariAktif", SqlDbType.Bit).Value = ceHizliSatisTuslariAktif.Checked;
          cmd.Parameters.Add("@HizliSatisIskontoYapilabilsin", SqlDbType.Bit).Value = ceHizliSatisIskontoYapilabilsin.Checked;
          cmd.Parameters.Add("@PerakendeCariID", SqlDbType.Int).Value = lkpPerakendeCari.EditValue.ToString();
          cmd.Parameters.Add("@HizliSatisKasaID", SqlDbType.Int).Value = lkpHizliSatisKasa.EditValue.ToString();

          cmd.Parameters.Add("@MailSmtpAdresi", SqlDbType.VarChar).Value = txtMailSmtpAdresi.Text;
          cmd.Parameters.Add("@MailAdresi", SqlDbType.VarChar).Value = txtMailAdresi.Text;
          cmd.Parameters.Add("@MailSifre", SqlDbType.VarChar).Value = txtMailSifre.Text;
          cmd.Parameters.Add("@MailPort", SqlDbType.VarChar).Value = txtMailPort.Text;
          cmd.Parameters.Add("@MailHost", SqlDbType.VarChar).Value = txtMailHost.Text;

          cmd.ExecuteNonQuery();
        }
        //cs.csGenelTanimlarOkunuyor.GenelTanimlarOkunuyor();

        XtraMessageBox.Show("Kaydetme işlemi başarılı.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }
  }
}
