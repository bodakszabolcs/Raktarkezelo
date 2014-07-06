using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktarkezelo.Product
{
    class Phone
    {
        public Attribute Azonosito;
        public Attribute Kategoria;
        public Attribute Marka;
        public Attribute Szin;
        public Attribute Fuggoseg;
        public Attribute Vetel;
        public Attribute Eladas;
        public Attribute Veteli_ar;
        public Attribute Eladasi_ar;
        public Attribute Akcios_ar;
        public Attribute Statusz;
        public Attribute BelsoMegjegyzes;
        public Attribute KulsoMegjegyzes;
        public Attribute Garancia;
        public Attribute Garancia_Osszeg;
        public Attribute Tulajdonos;
        public Attribute Web;
        
        public Phone(string azon,string kategoria,string marka,string szin,string fuggoseg, int akcios,int veteli_ar, int eladasi_ar,string statusz,string belsomegj,string kulsomegj,string garancia,int garancia_ar,string tulaj, string web)
        {
            Azonosito.AttributeName = "tel_imei";
            Azonosito.Value = azon;
            Kategoria.AttributeName = "tel_cat";
            Kategoria.Value = kategoria;
            Marka.AttributeName = "tel_marka";
            Marka.Value = marka;
            Szin.AttributeName = "tel_szin";
            Szin.Value = szin;
            Fuggoseg.AttributeName = "tel_fuggo";
            Fuggoseg.Value = fuggoseg;
            Vetel.AttributeName = "tel_vetel";
            Vetel.Value = "CURDATE()";
            Eladas.AttributeName = "tel_eladas";
            Eladas.Value = " null";
            Veteli_ar.AttributeName = "tel_eladasi_ar";
            Veteli_ar.Value = (veteli_ar).ToString();
            Eladasi_ar.AttributeName = "tel_eladasi_ar";
            Eladasi_ar.Value = "null";
            Statusz.AttributeName = "tel_statusz";
            Statusz.Value = statusz;
            BelsoMegjegyzes.AttributeName = "tel_belso_megj";
            BelsoMegjegyzes.Value = belsomegj;
            KulsoMegjegyzes.AttributeName = "tel_kulso_megj";
            KulsoMegjegyzes.Value = kulsomegj;
            Garancia.AttributeName = "tel_garancia";
            Garancia.Value = garancia;
            Garancia_Osszeg.AttributeName = "tel_garancia_ar";
            Garancia_Osszeg.Value = (garancia_ar).ToString();
            Tulajdonos.AttributeName = "tel_tulaj";
            Tulajdonos.Value = tulaj;
            Web.AttributeName = "tel_web";
            Web.Value = web;

        }
        public Phone()
        {
            Azonosito.AttributeName = "tel_imei";
            Azonosito.Value = null;
            Kategoria.AttributeName = "tel_cat";
            Kategoria.Value = null;
            Marka.AttributeName = "tel_marka";
            Marka.Value = null;
            Szin.AttributeName = "tel_szin";
            Szin.Value = null;
            Fuggoseg.AttributeName = "tel_fuggo";
            Fuggoseg.Value = null;
            Vetel.AttributeName = "tel_vetel";
            Vetel.Value = "CURDATE()";
            Eladas.AttributeName = "tel_eladas";
            Eladas.Value = " null";
            Veteli_ar.AttributeName = "tel_eladasi_ar";
            Veteli_ar.Value = null;
            Eladasi_ar.AttributeName = "tel_eladasi_ar";
            Eladasi_ar.Value = null;
            Statusz.AttributeName = "tel_statusz";
            Statusz.Value = null;
            BelsoMegjegyzes.AttributeName = "tel_belso_megj";
            BelsoMegjegyzes.Value = null;
            KulsoMegjegyzes.AttributeName = "tel_kulso_megj";
            KulsoMegjegyzes.Value = null;
            Garancia.AttributeName = "tel_garancia";
            Garancia.Value = null;
            Garancia_Osszeg.AttributeName = "tel_garancia_ar";
            Garancia_Osszeg.Value = null;
            Tulajdonos.AttributeName = "tel_tulaj";
            Tulajdonos.Value = null;
            Web.AttributeName = "tel_web";
            Web.Value =null;

        }


    }
    class Attribute
    {
       public string AttributeName;
       public string Value;

       public Attribute()
       {
           AttributeName = null;
           Value = null;
       }
       public Attribute(string name)
       {
           AttributeName = name;
           Value = null;
       }
    }
}
