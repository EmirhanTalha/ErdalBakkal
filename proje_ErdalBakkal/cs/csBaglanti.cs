using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace proje_ErdalBakkal.cs
{
	public class csBaglanti
	{
		static SqlConnection baglanti;
		public static SqlConnection BaglantiGetir()
		{
			if (baglanti == null)
				baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);

			if (baglanti.State == ConnectionState.Closed)
				baglanti.Open();

			return baglanti;
		}
	}
}
