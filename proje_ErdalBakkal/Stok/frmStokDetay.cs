using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace proje_ErdalBakkal.stok
{
  public partial class frmStokDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmStokDetay(string StokID)
    {
      InitializeComponent();
      _StokID = StokID;
    }
    string _StokID = "-1";
    public string OzelKodID = "-1", ProjeKodID = "-1";

    private void frmStokDetay_Load(object sender, EventArgs e)
    {
      try
      {
        #region lkpKDVOran
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select KdvOranID, KdvOranTanim From KdvOran  order by KdvOranTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpKDVOran.Properties.DataSource = dt;
          lkpKDVOran.Properties.PopulateColumns();
          lkpKDVOran.Properties.ValueMember = "KdvOranID";
          lkpKDVOran.Properties.DisplayMember = "KdvOranTanim";

         // lkpKDVOran.Properties.Columns["KdvOranID"].Visible = false;
          lkpKDVOran.Properties.Columns["KdvOranTanim"].Caption = @"KDV Oran Tanım";
          lkpKDVOran.EditValue = -1;
        }
        #endregion
        #region lkpStokBirim
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select StokBirimID, StokBirimTanim From StokBirim  order by StokBirimTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpStokBirim.Properties.DataSource = dt;
          lkpStokBirim.Properties.PopulateColumns();
          lkpStokBirim.Properties.ValueMember = "StokBirimID";
          lkpStokBirim.Properties.DisplayMember = "StokBirimTanim";

          //lkpStokBirim.Properties.Columns["StokBirimID"].Visible = false;
          lkpStokBirim.Properties.Columns["StokBirimTanim"].Caption = @"Stok Birim Tanım";
          lkpStokBirim.EditValue = -1;
        }
        #endregion
        #region lkpStokMarka
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select StokMarkaID, StokMarkaTanim From StokMarka  order by StokMarkaTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpStokMarka.Properties.DataSource = dt;
          lkpStokMarka.Properties.PopulateColumns();
          lkpStokMarka.Properties.ValueMember = "StokMarkaID";
          lkpStokMarka.Properties.DisplayMember = "StokMarkaTanim";

          lkpStokMarka.Properties.Columns["StokMarkaID"].Visible = false;
          lkpStokMarka.Properties.Columns["StokMarkaTanim"].Caption = @"Stok Marka Tanım";
          lkpStokMarka.EditValue = -1;
        }
        #endregion

        if (_StokID != "-1")
        {
          using (SqlCommand cmd = new SqlCommand(@"SELECT dbo.Stok.StokBarkod, dbo.Stok.StokTanim, dbo.Stok.OzelKodID, dbo.OzelKod.OzelKodTanim, dbo.Stok.ProjeID, dbo.Proje.ProjeTanim, dbo.Stok.KdvOranID, dbo.Stok.MinimumStokSeviyesi, dbo.Stok.AlisFiyati, dbo.Stok.SatisFiyati, dbo.Stok.StokMiktari, dbo.Stok.StokBirimID, dbo.Stok.StokMarkaID, dbo.Stok.HizliSatis, dbo.Stok.Aktif, dbo.Stok.StokResmi FROM dbo.Stok LEFT OUTER JOIN 
dbo.OzelKod ON dbo.Stok.OzelKodID = dbo.OzelKod.OzelKodID LEFT OUTER JOIN 
dbo.Proje ON dbo.Stok.ProjeID = dbo.Proje.ProjeID
WHERE     (dbo.Stok.StokID = @StokID)", cs.csBaglanti.BaglantiGetir()))
          {
            cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = _StokID;
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
              if (dr.Read())
              {
                txtStokBarkod.Text = dr["StokBarkod"].ToString();
                txtStokTanim.Text = dr["StokTanim"].ToString();
                OzelKodID = dr["OzelKodID"].ToString();
                txtOzelKod.Text = dr["OzelKodTanim"].ToString();
                ProjeKodID = dr["ProjeID"].ToString();
                txtProjeKod.Text = dr["ProjeTanim"].ToString();
                lkpKDVOran.EditValue = (int)dr["KdvOranID"];

                txtMinimumStokSeviyesi.Text = dr["MinimumStokSeviyesi"].ToString();
                txtAlisFiyati.Text = dr["AlisFiyati"].ToString();
                txtSatisFiyati.Text = dr["SatisFiyati"].ToString();

                lkpStokBirim.EditValue = (int)dr["StokBirimID"];
                lkpStokMarka.EditValue = (int)dr["StokMarkaID"];
                txtStokMiktari.Text = dr["StokMiktari"].ToString();

                ceAktif.Checked = (bool)dr["Aktif"];
                ceHizliSatis.Checked = (bool)dr["HizliSatis"];

								System.Drawing.Image image;
								if (dr["StokResmi"].ToString() != "" || dr["StokResmi"] != DBNull.Value)
								{
									using (System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])dr["StokResmi"]))
									{
										image = System.Drawing.Image.FromStream(ms);
										peStokResmi.Image = image;
									}
								}
							}
            }
          }
        }

      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }
    private void AktifTextBackColorChange(object sender, EventArgs e)
    {
      DevExpress.XtraEditors.TextEdit AktifText = (TextEdit)sender;
      AktifText.BackColor = Color.AntiqueWhite;
    }
    private void PasifTextBackColorChange(object sender, EventArgs e)
    {
      DevExpress.XtraEditors.TextEdit AktifText = (TextEdit)sender;
      AktifText.BackColor = Color.White;
    }

    private void txtOzelKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      if (e.Button.Index == 0)
      {
        stok.frmOzelKodSecim frmOzelKodSecim = new frmOzelKodSecim();
        frmOzelKodSecim.ShowDialog();
      }
      else
      {
        txtOzelKod.Text = "";
        OzelKodID = "-1";
      }
    }

    private void txtProjeKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      if (e.Button.Index == 0)
      {
        stok.frmProjeKoduSecim frmProjeKoduSecim = new frmProjeKoduSecim();
        frmProjeKoduSecim.ShowDialog();
      }
      else
      {
        txtProjeKod.Text = "";
        ProjeKodID = "-1";
      }
    }

		private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        #region Boş alan kontrolü
        if (txtStokBarkod.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz");
          txtStokBarkod.Focus();
          return;
        }
        if (txtStokTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz");
          txtStokTanim.Focus();
          return;
        }

        #endregion
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        if (_StokID == "-1")
        {
          cmd.CommandText = @"Insert Into Stok(StokMarkaID, StokBarkod, StokTanim, KdvOranID, MinimumStokSeviyesi, AlisFiyati, SatisFiyati, StokMiktari, StokBirimID, HizliSatis, Aktif, OzelKodID, ProjeID, StokResmi) values(@StokMarkaID, @StokBarkod, @StokTanim, @KdvOranID, @MinimumStokSeviyesi, @AlisFiyati, @SatisFiyati, @StokMiktari, @StokBirimID, @HizliSatis, @Aktif, @OzelKodID, @ProjeID, @StokResmi)";

        }
        else
        {
          cmd.CommandText = @"Update Stok SET StokBarkod=@StokBarkod, StokTanim=@StokTanim, OzelKodID=@OzelKodID, ProjeID=@ProjeID, KdvOranID=@KdvOranID, MinimumStokSeviyesi=@MinimumStokSeviyesi, AlisFiyati=@AlisFiyati, SatisFiyati=@SatisFiyati, StokMiktari=@StokMiktari, StokBirimID=@StokBirimID, StokMarkaID=@StokMarkaID, HizliSatis=@HizliSatis, Aktif=@Aktif, StokResmi=@StokResmi Where StokID=@StokID";
          cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = _StokID;
        }

        cmd.Parameters.Add("@StokBarkod", SqlDbType.VarChar).Value = txtStokBarkod.Text;
        cmd.Parameters.Add("@StokTanim", SqlDbType.VarChar).Value = txtStokTanim.Text;
        cmd.Parameters.Add("@OzelKodID", SqlDbType.Int).Value = OzelKodID;
        cmd.Parameters.Add("@ProjeID", SqlDbType.Int).Value = ProjeKodID;
        cmd.Parameters.Add("@KdvOranID", SqlDbType.Int).Value = lkpKDVOran.EditValue.ToString();
        if (txtMinimumStokSeviyesi.Text == "")
          cmd.Parameters.Add("@MinimumStokSeviyesi", SqlDbType.Decimal).Value = txtMinimumStokSeviyesi.Text;
        else
          cmd.Parameters.Add("@MinimumStokSeviyesi", SqlDbType.Decimal).Value = txtMinimumStokSeviyesi.Text;
        cmd.Parameters.Add("@AlisFiyati", SqlDbType.Decimal).Value = txtAlisFiyati.Text;
        cmd.Parameters.Add("@SatisFiyati", SqlDbType.Decimal).Value = txtSatisFiyati.Text;
        cmd.Parameters.Add("@StokMiktari", SqlDbType.Decimal).Value = txtStokMiktari.Text;
        cmd.Parameters.Add("@StokBirimID", SqlDbType.Int).Value = lkpStokBirim.EditValue.ToString();
        cmd.Parameters.Add("@StokMarkaID", SqlDbType.Int).Value = lkpStokMarka.EditValue.ToString();
        cmd.Parameters.Add("@HizliSatis", SqlDbType.Bit).Value = ceHizliSatis.Checked;
        cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ceAktif.Checked;

				#region resim işlemi
				byte[] buffer1 = null;
				if (peStokResmi.Image != null)
				{
					Image image1 = peStokResmi.Image;
					System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
					image1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);

					buffer1 = ms1.ToArray();
					ms1.Close();
					ms1.Dispose();
				}

				if (buffer1 == null)
					cmd.Parameters.Add("@StokResmi", SqlDbType.Image).Value = DBNull.Value;
				else
					cmd.Parameters.Add("@StokResmi", SqlDbType.Image).Value = buffer1;
				#endregion
				cmd.ExecuteNonQuery();
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }
  }
}