using DataAccessLayer;

using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
 public  class DalPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {

            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("select * from TblBilgi",Baglanti.bgl);
            if (komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();

            }
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.ID = int.Parse(dr["Id"].ToString());
                ent.Ad = dr["Ad"].ToString();
                ent.Soyad = dr["Soyad"].ToString();
                ent.Gorev = dr["Gorev"].ToString();
                ent.Maas = short.Parse(dr["Maas"].ToString());
            }
            dr.Close();
                return degerler;
        }


    }
}
