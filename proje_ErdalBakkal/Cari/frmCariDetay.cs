using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Cari
{
  public partial class frmCariDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmCariDetay(string CariID)
    {
      InitializeComponent();
      _CariID = CariID;
    }
    string _CariID = "-1";
    SqlDataAdapter daCariTur = new SqlDataAdapter();
    DataTable dtCariTur =new DataTable();

		SqlDataAdapter daOzelKod = new SqlDataAdapter();
		DataTable dtOzelKod = new DataTable();

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
    private void frmCariDetay_Load(object sender, EventArgs e)
    {
      try
      {
        #region lkpCariTur
        using (daCariTur.SelectCommand = new  SqlCommand(@"Select CariTurID, CariTurTanim From CariTur  order by CariTurTanim", cs.csBaglanti.BaglantiGetir()))
        {
          daCariTur.Fill(dtCariTur);
          lkpCariTur.Properties.DataSource = dtCariTur;
          lkpCariTur.Properties.PopulateColumns();
          lkpCariTur.Properties.ValueMember = "CariTurID";
          lkpCariTur.Properties.DisplayMember = "CariTurTanim";

          lkpCariTur.Properties.Columns["CariTurID"].Visible = false;
          lkpCariTur.Properties.Columns["CariTurTanim"].Caption = @"Cari Tür Tanım";
          lkpCariTur.EditValue = -1;
        }
        #endregion
        #region lkpCariGrup
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select CariGrupID, CariGrupTanim From CariGrup  order by CariGrupTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpCariGrup.Properties.DataSource = dt;
          lkpCariGrup.Properties.PopulateColumns();
          lkpCariGrup.Properties.ValueMember = "CariGrupID";
          lkpCariGrup.Properties.DisplayMember = "CariGrupTanim";

          lkpCariGrup.Properties.Columns["CariGrupID"].Visible = false;
          lkpCariGrup.Properties.Columns["CariGrupTanim"].Caption = @"Cari Grup Tanım";
          lkpCariGrup.EditValue = -1;
        }
        #endregion
        #region lkpOzelKod
        using (daOzelKod. SelectCommand= new  SqlCommand(@"Select OzelKodID, OzelKodTanim From OzelKod  order by OzelKodTanim", cs.csBaglanti.BaglantiGetir()))
        {
					daOzelKod.Fill(dtOzelKod);
          lkpOzelKod.Properties.DataSource = dtOzelKod;
          lkpOzelKod.Properties.PopulateColumns();
          lkpOzelKod.Properties.ValueMember = "OzelKodID";
          lkpOzelKod.Properties.DisplayMember = "OzelKodTanim";

          lkpOzelKod.Properties.Columns["OzelKodID"].Visible = false;
          lkpOzelKod.Properties.Columns["OzelKodTanim"].Caption = @"Özel Kod Tanım";
          lkpOzelKod.EditValue = -1;
        }
        #endregion
        #region lkpProje
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select ProjeID, ProjeTanim From Proje  order by ProjeTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpProje.Properties.DataSource = dt;
          lkpProje.Properties.PopulateColumns();
          lkpProje.Properties.ValueMember = "ProjeID";
          lkpProje.Properties.DisplayMember = "ProjeTanim";

          lkpProje.Properties.Columns["ProjeID"].Visible = false;
          lkpProje.Properties.Columns["ProjeTanim"].Caption = @"Proje Tanım";
          lkpProje.EditValue = -1;
        }
        #endregion

        if (_CariID != "-1")
        {
          using (SqlCommand cmd = new SqlCommand(@"SELECT     CariID, CariKod, CariTanim, Yetkili, EMailAdres, Adres, VergiDairesi, VergiNumarasi, TelefonNo, FaksNo, Aktif, CariTurID, CariGrupID, OzelKodID, ProjeID
FROM         dbo.Cari
WHERE     (CariID = @CariID)", cs.csBaglanti.BaglantiGetir()))
          {
            cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = _CariID;
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
              if (dr.Read())
              {
                lkpCariTur.EditValue = (int)dr["CariTurID"];
                lkpCariGrup.EditValue = (int)dr["CariGrupID"];
                txtCariKod.Text = dr["CariKod"].ToString();
                txtCariTanim.Text = dr["CariTanim"].ToString();
                lkpOzelKod.EditValue = (int)dr["OzelKodID"];
                lkpProje.EditValue = (int)dr["ProjeID"];
                txtYetkili.Text = dr["Yetkili"].ToString();
                txtEMailAdres.Text = dr["EMailAdres"].ToString();
                memoAdres.Text = dr["Adres"].ToString();
                txtVergiDairesi.Text = dr["VergiDairesi"].ToString();
                txtVergiNumarasi.Text = dr["VergiNumarasi"].ToString();
                txtTelefonNo.Text = dr["TelefonNo"].ToString();
                txtFaksNo.Text = dr["FaksNo"].ToString();
                ceAktif.Checked = (bool)dr["Aktif"];
              }
            }
          }
        }

      }
      catch (Exception hata)
      {
				MessageBox.Show(hata.Message);
			}
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        dxErrorProvider1.ClearErrors();
        #region Boş alan kontrolü
        if ((int)lkpCariTur.EditValue == -1)
        {
          dxErrorProvider1.SetError(lkpCariTur, "Boş geçilemez");
          //XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          lkpCariTur.Focus();
          return;
        }
        if (txtCariKod.Text == "")
        {
          dxErrorProvider1.SetError(txtCariKod, "Boş geçilemez");
          //XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz","Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtCariKod.Focus();
          return;
        }
        if (txtCariTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtCariTanim.Focus();
          return;
        }
        #endregion
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        if (_CariID == "-1")
        {
          cmd.CommandText = @"Insert Into Cari values(@CariTurID, @CariGrupID, @CariKod, @CariTanim, @OzelKodID, @ProjeID, @Yetkili, @EMailAdres, @Adres, @VergiDairesi, @VergiNumarasi, @TelefonNo, @FaksNo, @Aktif)";

        }
        else
        {
          cmd.CommandText = @"Update Cari SET CariTurID=@CariTurID, CariGrupID=@CariGrupID, CariKod=@CariKod, CariTanim=@CariTanim, OzelKodID=@OzelKodID, ProjeID=@ProjeID, Yetkili=@Yetkili, EMailAdres=@EMailAdres, Adres=@Adres, VergiDairesi=@VergiDairesi, VergiNumarasi=@VergiNumarasi, TelefonNo=@TelefonNo, FaksNo=@FaksNo, Aktif=@Aktif Where CariID=@CariID";
          cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = _CariID;
        }

        cmd.Parameters.Add("@CariTurID", SqlDbType.Int).Value = lkpCariTur.EditValue.ToString();
        cmd.Parameters.Add("@CariGrupID", SqlDbType.Int).Value = lkpCariGrup.EditValue.ToString();
        cmd.Parameters.Add("@CariKod", SqlDbType.VarChar).Value = txtCariKod.Text;
        cmd.Parameters.Add("@CariTanim", SqlDbType.VarChar).Value = txtCariTanim.Text;
        cmd.Parameters.Add("@OzelKodID", SqlDbType.Int).Value = lkpOzelKod.EditValue.ToString();
        cmd.Parameters.Add("@ProjeID", SqlDbType.Int).Value = lkpProje.EditValue.ToString();
        cmd.Parameters.Add("@Yetkili", SqlDbType.VarChar).Value = txtYetkili.Text;
        cmd.Parameters.Add("@EMailAdres", SqlDbType.VarChar).Value = txtEMailAdres.Text;
        cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = memoAdres.Text;

        cmd.Parameters.Add("@VergiDairesi", SqlDbType.VarChar).Value = txtVergiDairesi.Text;
        cmd.Parameters.Add("@VergiNumarasi", SqlDbType.VarChar).Value = txtVergiNumarasi.Text;
        cmd.Parameters.Add("@TelefonNo", SqlDbType.VarChar).Value = txtTelefonNo.Text;

        cmd.Parameters.Add("@FaksNo", SqlDbType.VarChar).Value = txtFaksNo.Text;

        cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ceAktif.Checked;

        cmd.ExecuteNonQuery();
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch (Exception hata)
      {
				MessageBox.Show(hata.Message);
			}
    }

    private void lkpCariTur_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      if (e.Button.Index == 1)
      {
        Cari.frmCariTurEkle frmCariTurEkle = new frmCariTurEkle();
        if (frmCariTurEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
          //lkpCariTur güncellenecek.
          dtCariTur.Clear();
          daCariTur.Fill(dtCariTur);

					//En son eklenen Cari Tur ün Lookup ta da seçili duruma gelmesini istiyoruz.
          lkpCariTur.EditValue = frmCariTurEkle.sonCariTurID;
        }
      }
    }

		private void lkpOzelKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			if (e.Button.Index == 1)
			{
				Cari.frmOzelKodEkle frmOzelKodEkle = new frmOzelKodEkle();
				if (frmOzelKodEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					dtOzelKod.Clear();
					daOzelKod.Fill(dtOzelKod);

					lkpOzelKod.EditValue = frmOzelKodEkle.sonKayitID;
				}
			}
		}
	}
}