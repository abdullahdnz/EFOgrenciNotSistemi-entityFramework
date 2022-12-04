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

namespace EFOgrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbOgrenciEntities db = new DbOgrenciEntities();

        private void btnDersList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"data source=DESKTOP-RR12QMS;initial catalog=DbOgrenci;integrated security=True;");
            SqlCommand command = new SqlCommand("select *from tbl_dersler", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"data source=DESKTOP-RR12QMS;initial catalog=DbOgrenci;integrated security=True;");
            tbl_dersler d = new tbl_dersler();
            d.DersAdi = txtDersAdi.Text;
            db.tbl_dersler.Add(d);
            db.SaveChanges();
            MessageBox.Show("Ders Başarıyla Eklendi");
        }

        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            tbl_ogrenci s = new tbl_ogrenci();
            s.OgrenciAdi = txtOgrAdi.Text;
            s.OgrenciSoyadi = txtOgrSoyad.Text;
            db.tbl_ogrenci.Add(s);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Başarıyla Eklendi");
        }

        private void btnOgrList_Click(object sender, EventArgs e)
        {
            var query = from item in db.tbl_ogrenci
                        select new
                        {
                            item.OgrenciID,
                            item.OgrenciAdi,
                            item.OgrenciSoyadi
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.tbl_ogrenci.Find(id);
            db.tbl_ogrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var g = db.tbl_ogrenci.Find(id);
            g.OgrenciAdi = txtOgrAdi.Text;
            g.OgrenciSoyadi = txtOgrSoyad.Text;
            g.Fotograf = txtFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_ogrenci.Where(x => x.OgrenciAdi == txtOgrAdi.Text).ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
    }
}
