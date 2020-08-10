using System.Data;
using System.Data.SqlClient;
using System;
namespace proje_ErdalBakkal.cs
{
  public class csGenelTanimlarOkunuyor
  {
    public static void GenelTanimlarOkunuyor()
    {
      try
      {
        using (SqlCommand cmdGenel = new SqlCommand(@"
SELECT     SatisSonundaOnayiIste, StokEksiyeInebilsin, HizliSatisTuslariAktif, HizliSatisIskontoYapilabilsin, PerakendeCariID, MailSmtpAdresi, MailAdresi, MailSifre, MailPort, MailHost, PerakendeCariID, HizliSatisKasaID
FROM         dbo.GenelTanimlar", cs.csBaglanti.BaglantiGetir()))
        {
          using (SqlDataReader drGenel = cmdGenel.ExecuteReader())
          {
            if (drGenel.Read())
            {
              cs.csKullanici.SatisSonundaOnayiIste = drGenel.GetBoolean(0);
              cs.csKullanici.StokEksiyeInebilsin = drGenel.GetBoolean(1);
              cs.csKullanici.HizliSatisTuslariAktif = drGenel.GetBoolean(2);
              cs.csKullanici.HizliSatisIskontoYapilabilsin = drGenel.GetBoolean(3);
              cs.csKullanici.PerakendeCariID = drGenel["PerakendeCariID"].ToString();
              cs.csKullanici.HizliSatisKasaID = drGenel["HizliSatisKasaID"].ToString();

              cs.csKullanici.MailSmtpAdresi = drGenel["MailSmtpAdresi"].ToString();
              cs.csKullanici.MailAdresi = drGenel["MailAdresi"].ToString();
              cs.csKullanici.MailSifre = drGenel["MailSifre"].ToString();
              cs.csKullanici.MailPort = drGenel["MailPort"].ToString();
              cs.csKullanici.MailHost = drGenel["MailHost"].ToString();
            }
          }
        }
      }
      catch (Exception hata)
      {        
        throw new Exception(hata.Message);
      }
    }
  }
}
