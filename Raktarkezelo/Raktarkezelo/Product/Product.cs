using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raktarkezelo.DataBase;

namespace Raktarkezelo.Product
{
    class Phone
    {
        public string Id;
        public string Azonosito;
        public string Kategoria;
        public string Marka;
        public string Szin;
        public string Fuggoseg;
        public string Vetel;
        public string Eladas;
        public string Veteli_ar;
        public string Allapot;
        public string Eladasi_ar;
        public string Akcios_ar;
        public string Afa;
        public string Statusz;
        public string BelsoMegjegyzes;
        public string KulsoMegjegyzes;
        public string Garancia;
        public string Garancia_Osszeg;
        public string Tulajdonos;
        public string Felhasznalo;
        public string Web;
        public string Del;
        
        public Phone(string id,string azon,string kategoria,string marka,string szin,string fuggoseg,string allapot, string akcios,string veteli_ar,string afa, string eladasi_ar,string statusz,string belsomegj,string kulsomegj,string garancia,int garancia_ar,string tulaj,string felhasznalo, string web,string del)
        {
            Id = id;
            Azonosito = azon;
            Kategoria = kategoria;
            Marka = marka;
            Szin = szin;
            Fuggoseg = fuggoseg;
            Allapot = allapot;
            Vetel= "CURDATE()";
            Eladas = " null";
            Veteli_ar = veteli_ar;
            Eladasi_ar = eladasi_ar;
            Akcios_ar = akcios;
            Afa = afa;
            Statusz = statusz;
            BelsoMegjegyzes = belsomegj;
            KulsoMegjegyzes = kulsomegj;
            Garancia = garancia;
            Garancia_Osszeg = (garancia_ar).ToString();
            Tulajdonos = tulaj;
            Felhasznalo = felhasznalo;
            Web = web;
            Del = del;

        }
        public void Insert()
        {
            MySQLDB db = new MySQLDB();
            db.Insert("INSERT INTO shop_phone VALUES('','"+Azonosito+"','"+Kategoria+"','"+Marka+"','"+Szin+"','"+Fuggoseg+"','"+Allapot+"','"+Veteli_ar+"','"+Eladasi_ar+"','"+Akcios_ar+"','"+Statusz+"','"+BelsoMegjegyzes+"','"+KulsoMegjegyzes+"','"+Garancia+"','"+Garancia_Osszeg+"','"+Tulajdonos+"','"+Web+"',NOW(),NOW(),'"+Felhasznalo+"','"+Felhasznalo+"','0') ");
        }
        public void Update()
        {
            MySQLDB db = new MySQLDB();
            db.Update("UPDATE shop_phone set tel_imei='"+Azonosito+"',tel_cat='"+Kategoria+"',tel_marka='"+Marka+"',tel_szin='"+Szin+"',tel_fuggo='"+Fuggoseg+"',tel_allapot='"+Allapot+"',tel_veteli_ar='"+Veteli_ar+"',tel_eladasi_ar='"+Eladasi_ar+"',tel_akcios_ar='"+Akcios_ar+"',tel_afa='"+Afa+"',tel_statusz='"+Statusz+"',tel_belso_megj='"+BelsoMegjegyzes+"',tel_kulso_megj='"+KulsoMegjegyzes+"',tel_web='"+Web+"',tel_lastup=NOW(),tel_user_update='"+Felhasznalo+"', tel_del='"+Del+"' where tel_id='"+Id+"'");
        
        }
        public void Delete()
        {
            MySQLDB db = new MySQLDB();
            db.Delete("UPDATE shop_phone set tel_del='1', tel_lastup=NOW(), tel_user_updated='" + Felhasznalo + "',tel_statusz='TÖRÖLT' ");
            
        }

        public void Sell()
        {
            MySQLDB db = new MySQLDB();
            db.Update("UPDATE shop_phone SET tel_eladasi_ar_'"+Eladasi_ar+"',tel_garancia='"+Garancia+"', tel_garancia_ar='"+Garancia_Osszeg+"', tel_web='0',tel_user_updated='"+Felhasznalo+"', te_statusz='Eladva'");
        }
        public void Send()
        {
            
        }


    }
   
}
