using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Sehir = txtSehir.Text;
            ent.Maas = short .Parse(txtMaas.Text);
            ent.Gorev = txtGörev.Text;
            LogicPersonel.LLPersonelEkle(ent);



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.ID =Convert.ToInt32(txtId.Text);
            LogicPersonel.LLPersonelSil(ent.ID);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.ID = Convert.ToInt32(txtId.Text);
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Sehir = txtSehir.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            ent.Gorev = txtGörev.Text;
            LogicPersonel.LLPersonelGuncelle(ent);

        }
    }
}
