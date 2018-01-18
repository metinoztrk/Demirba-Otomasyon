using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SinamaProje;

namespace SinamaProjeTest
{
    [TestClass]
    public class SinamaUnitTest
    {
        [TestMethod]
        public void OdaOlusturma()
        {
            OdaTanimlama odatanim = new OdaTanimlama();
            string odaadi = "deneme";
            int odasorumlusu = 1;
            int fakulte = 0;
            string sonuc = odatanim.OdaKayit(odaadi, odasorumlusu, fakulte);
            Assert.AreEqual("Başarıyla oda tanımlandı.", sonuc);
        }
        [TestMethod]
        public void OdayaPersonelAtama()
        {
            OdaPersonelAtama opa = new OdaPersonelAtama();
            string PersonelAdi = "Yiğit";
            string OdaAdi = "lab1";
            int PersonelIndex = 0;
            int OdaIndex = 0;
            string sonuc = opa.OdayaPersonelAtama(PersonelAdi,OdaAdi,PersonelIndex,OdaIndex);
            Assert.AreEqual("İşlem Başarılı.", sonuc);
        }
        [TestMethod]
        public void GirisYapma()
        {
            Giris giris = new Giris();
            string kullaniciadi = "emin";
            string sifre = "123";
            string sonuc = giris.GirisYap(kullaniciadi, sifre);
            Assert.AreEqual("Giriş Başarılı.", sonuc);
        }
        [TestMethod]
        public void IzinsizGirisEngelleme()
        {
            Giris giris = new Giris();
            string kullaniciadi = "yabanci";
            string sifre = "qwerty";
            string sonuc = giris.GirisYap(kullaniciadi, sifre);
            Assert.AreNotEqual("Giriş Başarılı.", sonuc);          
        }
    }
}
