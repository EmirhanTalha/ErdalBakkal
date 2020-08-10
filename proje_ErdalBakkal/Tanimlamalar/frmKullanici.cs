using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace proje_ErdalBakkal.Tanimlamalar
{
	public partial class frmKullanici : DevExpress.XtraEditors.XtraUserControl
	{
		public frmKullanici()
		{
			InitializeComponent();
		}

		SqlConnection Baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);

		SqlTransaction tr;
		SqlDataAdapter da = new SqlDataAdapter();
		BindingSource bs = new BindingSource();
		DataTable dt = new DataTable();
		bool islem = false;
		int SatirNo = 0;

		private void frmAdresTuru_Load(object sender, EventArgs e)
		{
			try
			{
				if (Baglanti.State == ConnectionState.Closed)
					Baglanti.Open();

				#region lkpSkinName DOLDURULUYOR.
				using (SqlDataAdapter da = new SqlDataAdapter("Select SkinNameID,SkinName From SkinName", Baglanti))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);
					lkpSkinName.Properties.DataSource = dt;
					lkpSkinName.Properties.PopulateColumns();
					lkpSkinName.Properties.ValueMember = "SkinNameID";
					lkpSkinName.Properties.DisplayMember = "SkinName";
					lkpSkinName.Properties.Columns["SkinNameID"].Visible = false;
					lkpSkinName.Properties.Columns["SkinName"].Caption = "Görünüm Adı";
				} 
				#endregion

				tr = Baglanti.BeginTransaction();

				using (da.SelectCommand = new SqlCommand("SELECT KullaniciID, KullaniciKodu,KullaniciSifre,SkinNameID FROM dbo.Kullanici", Baglanti, tr))
				{
					dt.Clear();
					da.Fill(dt);
					bs.DataSource = dt;
					gcKullanici.DataSource = bs;

					txtKullaniciKodu.DataBindings.Clear();
					txtKullaniciSifre.DataBindings.Clear();
					txtKullaniciKodu.DataBindings.Add("Text", bs, "KullaniciKodu");
					txtKullaniciSifre.DataBindings.Add("Text", bs, "KullaniciSifre");
					lkpSkinName.DataBindings.Add("EditValue", bs, "SkinNameID");

					gvKullanici.Columns["KullaniciID"].Visible = false;
					gvKullanici.Columns["KullaniciSifre"].Visible = false;
					gvKullanici.Columns["SkinNameID"].Visible = false;
					gvKullanici.Columns["KullaniciKodu"].Caption = "Kullanıcı Kodu";
					gvKullanici.Columns["KullaniciSifre"].Caption = "Kullanıcı Şifre";
				}

				tr.Commit();
				NesneEnabled(true);
				gvKullanici.OptionsView.ShowGroupPanel = false;
			}
			catch (Exception hata)
			{
				tr.Rollback();
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnEkle_Click(object sender, EventArgs e)
		{
			islem = true;
			NesneEnabled(false);
			txtKullaniciKodu.Text = "";
			txtKullaniciKodu.Focus();
		}
		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvKullanici.FocusedRowHandle < 0) return;
				if (XtraMessageBox.Show("Seçili Kaydı Silmek İstediğinize Emin misiniz ?", "Parekende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
					return;

				tr = Baglanti.BeginTransaction();
				using (SqlCommand cmd = new SqlCommand("Delete From Kullanici Where KullaniciID=@KullaniciID", Baglanti, tr))
				{
					cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = gvKullanici.GetFocusedRowCellValue("KullaniciID").ToString();
					cmd.ExecuteNonQuery();
				}
				tr.Commit();
				dt.Clear();
				da.Fill(dt);
			}
			catch (Exception hata)
			{
				tr.Rollback();
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnDegistir_Click(object sender, EventArgs e)
		{
			if (gvKullanici.FocusedRowHandle < 0) return;
			SatirNo = gvKullanici.FocusedRowHandle;
			islem = false;
			NesneEnabled(false);
			txtKullaniciKodu.Focus();
		}
		private void btnVazgec_Click(object sender, EventArgs e)
		{
			islem = false;
			NesneEnabled(true);
			dt.Clear();
			da.Fill(dt);
			gvKullanici.FocusedRowHandle = SatirNo;
		}
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtKullaniciKodu.Text == "")
				{
					XtraMessageBox.Show("Kullanıcı Kodu Boş Geçilemez.", "Parekende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtKullaniciKodu.Focus();
					return;
				}
				tr = Baglanti.BeginTransaction();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = Baglanti;
				cmd.Transaction = tr;
				cmd.CommandType = CommandType.Text;

				if (islem)
				{
					cmd.CommandText = "Insert Into Kullanici(KullaniciKodu,KullaniciSifre,SkinNameID) Values(@KullaniciKodu,@KullaniciSifre,@SkinNameID)";
				}
				else
				{
					cmd.CommandText = "Update Kullanici Set KullaniciKodu=@KullaniciKodu,KullaniciSifre=@KullaniciSifre, SkinNameID=@SkinNameID Where KullaniciID=@KullaniciID";
					cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = gvKullanici.GetFocusedRowCellValue("KullaniciID").ToString();
				}

				cmd.Parameters.Add("@KullaniciKodu", SqlDbType.NVarChar).Value = txtKullaniciKodu.Text;
				cmd.Parameters.Add("@KullaniciSifre", SqlDbType.NVarChar).Value = txtKullaniciSifre.Text;
				cmd.Parameters.Add("@SkinNameID", SqlDbType.Int).Value = lkpSkinName.EditValue.ToString();
				cmd.ExecuteNonQuery();

				tr.Commit();

				NesneEnabled(true);
				dt.Clear();
				da.Fill(dt);
				if (!islem) gvKullanici.FocusedRowHandle = SatirNo;
			}
			catch (Exception hata)
			{
				tr.Rollback();
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			dt.Clear();
			da.Fill(dt);
		}
		void NesneEnabled(bool islem)
		{
			btnEkle.Enabled = islem;
			btnSil.Enabled = islem;
			btnDegistir.Enabled = islem;

			btnVazgec.Enabled = !islem;
			btnKaydet.Enabled = !islem;

			btnGuncelle.Enabled = islem;

			txtKullaniciKodu.Enabled = !islem;
			txtKullaniciSifre.Enabled = !islem;
			lkpSkinName.Enabled = !islem;

			gcKullanici.Enabled = islem;
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
		private void lkpSkinName_EditValueChanged(object sender, EventArgs e)
		{
			//if (lkpSkinName.Enabled)
			//	((frmKullaniciGiris)Application.OpenForms["frmKullaniciGiris"]).dlf.LookAndFeel.SkinName = lkpSkinName.Text;
		}
	}
}
