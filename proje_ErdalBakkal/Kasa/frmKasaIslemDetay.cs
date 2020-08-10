using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Kasa
{
	public partial class frmKasaIslemDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmKasaIslemDetay(string kasaIslemID)
		{
			InitializeComponent();
			_kasaIslemID = kasaIslemID;
		}
		string _kasaIslemID = "-1";
		//KasaIslem.KasaIslemTipi -> 1: Kasadan Alınan Hizmet Faturası, 2: Kasadan Satış Faturası, 3: Kasadan Nakit Tahsilat, 4: Kasadan Nakit Ödeme
		private void frmKasaIslemDetay_Load(object sender, EventArgs e)
		{
			try
			{
				#region lkpKasa
				using (SqlDataAdapter da = new SqlDataAdapter(@"Select KasaID, KasaTanim From Kasa  order by KasaTanim", cs.csBaglanti.BaglantiGetir()))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);
					lkpKasa.Properties.DataSource = dt;
					lkpKasa.Properties.PopulateColumns();
					lkpKasa.Properties.ValueMember = "KasaID";
					lkpKasa.Properties.DisplayMember = "KasaTanim";

					lkpKasa.Properties.Columns["KasaID"].Visible = false;
					lkpKasa.Properties.Columns["KasaTanim"].Caption = @"Kasa Tanım";
					lkpKasa.EditValue = -1;
				}
				#endregion

				#region lkpCari
				using (SqlDataAdapter da = new SqlDataAdapter(@"Select CariID, CariTanim From Cari  order by CariTanim", cs.csBaglanti.BaglantiGetir()))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);
					lkpCari.Properties.DataSource = dt;
					lkpCari.Properties.PopulateColumns();
					lkpCari.Properties.ValueMember = "CariID";
					lkpCari.Properties.DisplayMember = "CariTanim";

					lkpCari.Properties.Columns["CariID"].Visible = false;
					lkpCari.Properties.Columns["CariTanim"].Caption = @"Cari Tanım";
					lkpCari.EditValue = -1;
				}
				#endregion
				if (_kasaIslemID != "-1")
				{
					using (SqlCommand cmd = new SqlCommand(@"SELECT     KasaID, CariID, Tahsilat, IslemTarihi, GenelToplam, KasaIslemTipi FROM dbo.KasaIslem WHERE (KasaIslemID = @KasaIslemID)", cs.csBaglanti.BaglantiGetir()))
					{
						cmd.Parameters.Add("@KasaIslemID", SqlDbType.Int).Value = _kasaIslemID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								lkpKasa.EditValue = (int)dr["KasaID"];
								lkpCari.EditValue = (int)dr["CariID"];
								cmbKasaIslemTipi.SelectedIndex = (int)dr["KasaIslemTipi"];
								deIslemTarihi.DateTime = (DateTime)dr["IslemTarihi"];
								txtGenelToplam.Text = dr["GenelToplam"].ToString();
							}
						}
					}
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				#region Boş alan kontrolü
				if ((int)lkpKasa.EditValue == -1)
				{
					XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz.", "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					lkpKasa.Focus();
					return;
				}
				if (cmbKasaIslemTipi.SelectedIndex == 2 || cmbKasaIslemTipi.SelectedIndex == 3)
					if ((int)lkpCari.EditValue == -1)
					{
						XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz.", "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						lkpCari.Focus();
						return;
					}
				if (deIslemTarihi.Text == "")
				{
					XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz", "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					deIslemTarihi.Focus();
					return;
				}
				if (txtGenelToplam.Text == "")
				{
					XtraMessageBox.Show("Zorunlu alanları boş geçemezsiniz", "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtGenelToplam.Focus();
					return;
				}
				#endregion
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = cs.csBaglanti.BaglantiGetir();
				if (_kasaIslemID == "-1")
				{
					cmd.CommandText = @"Insert Into KasaIslem values(@KasaID, @CariID, @Tahsilat, @IslemTarihi, @GenelToplam, @KasaIslemTipi,-1)";
				}
				else
				{
					cmd.CommandText = @"Update KasaIslem SET KasaID=@KasaID, CariID=@CariID, Tahsilat=@Tahsilat, IslemTarihi=@IslemTarihi, GenelToplam=@GenelToplam, KasaIslemTipi=@KasaIslemTipi Where KasaIslemID=@KasaIslemID";
					cmd.Parameters.Add("@KasaIslemID", SqlDbType.Int).Value = _kasaIslemID;
				}

				cmd.Parameters.Add("@KasaID", SqlDbType.Int).Value = lkpKasa.EditValue.ToString();
				cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = lkpCari.EditValue.ToString();
				cmd.Parameters.Add("@Tahsilat", SqlDbType.Bit).Value =
				(cmbKasaIslemTipi.SelectedIndex == 1 || cmbKasaIslemTipi.SelectedIndex == 2) ? true : false;
				cmd.Parameters.Add("@IslemTarihi", SqlDbType.DateTime).Value = deIslemTarihi.DateTime.ToShortDateString();
				cmd.Parameters.Add("@GenelToplam", SqlDbType.Decimal).Value = txtGenelToplam.Text;
				cmd.Parameters.Add("@KasaIslemTipi", SqlDbType.Int).Value = cmbKasaIslemTipi.SelectedIndex;

				cmd.ExecuteNonQuery();
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbKasaIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbKasaIslemTipi.SelectedIndex == 0 || cmbKasaIslemTipi.SelectedIndex == 1)
				lkpCari.Enabled = false;
			else
				lkpCari.Enabled = true;
		}
	}
}