using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;

namespace proje_ErdalBakkal.Tanimlamalar
{
	public partial class frmTanimlamalar : DevExpress.XtraEditors.XtraForm
	{
		public frmTanimlamalar()
		{
			InitializeComponent();
		}
		public void UserControlAc(UserControl ucl)
		{
			int aktifkontrol = -1, sayac = 0;
			foreach (UserControl item in panelControl1.Controls)
			{
				if (item.Name == ucl.Name)
				{
					aktifkontrol = sayac;
					panelControl1.Controls[sayac].Visible = true;
				}
				else
					panelControl1.Controls[sayac].Visible = false;

				sayac++;
			}
			if (aktifkontrol == -1)
				panelControl1.Controls.Add(ucl);
		}
		private void frmTanimlamalar_Load(object sender, EventArgs e)
		{
			tlstMenu.OptionsBehavior.Editable = false;
			tlstMenu.OptionsView.ShowColumns = false;
			tlstMenu.OptionsView.ShowIndicator = false;
			tlstMenu.OptionsView.ShowHorzLines = false;
			tlstMenu.OptionsView.ShowVertLines = false;
			tlstMenu.ExpandAll();

			Tanimlamalar.frmProje frmProje = new frmProje();
			UserControlAc(frmProje);
		}

		private void tlstMenu_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
		{
			var tl = sender as TreeList;
			if (e.Node == tl.FocusedNode)
			{
				e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
				var rect = new Rectangle(e.EditViewInfo.ContentRect.Left,
				e.EditViewInfo.ContentRect.Top,
				Convert.ToInt32(e.Graphics.MeasureString(e.CellText, tlstMenu.Font).Width + 1),
				Convert.ToInt32(e.Graphics.MeasureString(e.CellText, tlstMenu.Font).Height));
				e.Graphics.FillRectangle(SystemBrushes.Highlight, rect);
				e.Graphics.DrawString(e.CellText, tlstMenu.Font, SystemBrushes.HighlightText, rect);
				e.Handled = true;
			}
		}

		private void tlstMenu_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
		{
			switch (tlstMenu.Selection[0].GetValue(0).ToString())
			{
				case "Program Genel Tanımlamalar":
					Tanimlamalar.frmGenelTanimlar frmGenelTanimlar = new frmGenelTanimlar();
					UserControlAc(frmGenelTanimlar);
					break;
				case "Cari Grup":
					Tanimlamalar.frmCariGrup frmCariGrup = new frmCariGrup();
					UserControlAc(frmCariGrup);
					break;
				case "Cari Tür":
					Tanimlamalar.frmCariTur frmCariTur = new frmCariTur();
					UserControlAc(frmCariTur);
					break;
				case "Stok Birim":
					Tanimlamalar.frmStokBirim frmStokBirim = new frmStokBirim();
					UserControlAc(frmStokBirim);
					break;
				case "Proje Tanım":
					Tanimlamalar.frmProje frmProje = new frmProje();
					UserControlAc(frmProje);
					break;
				case "Özel Kod":
					Tanimlamalar.frmOzelKod frmOzelKod = new frmOzelKod();
					UserControlAc(frmOzelKod);
					break;
				case "Stok Marka":
					Tanimlamalar.frmStokMarka frmStokMarka = new frmStokMarka();
					UserControlAc(frmStokMarka);
					break;
				case "KDV Oran":
					Tanimlamalar.frmKDVOran frmKDVOran = new frmKDVOran();
					UserControlAc(frmKDVOran);
					break;
				case "Kasa Tanım":
					Tanimlamalar.frmKasa frmKasa = new frmKasa();
					UserControlAc(frmKasa);
					break;
				case "Kullanıcı Tanımlama":
					Tanimlamalar.frmKullanici frmKullanici = new frmKullanici();
					UserControlAc(frmKullanici);
					break;

			}
		}
	}
}