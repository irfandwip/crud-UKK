using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Betamart
{
    public partial class Form1 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\FLIP CLASSROOM\ukk mas\betamart.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Tolong isi Data Barang dan ID Barang yang akan di edit!");
            }
            else
            {
                koneksi.Open();
                OleDbCommand cmd = koneksi.CreateCommand();
                string perintah = "update tb_betamart set nama_barang='" + txtbox_nama.Text + "' ,harga_barang='" + txtbox_harga.Text + "',stok_barang='" + txtbox_stok.Text + "' where auto_id=" + txtID.Text + "";
                cmd.CommandText = perintah;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Barang berhasil diedit");
                txtID.Clear();
                txtbox_nama.Clear();
                txtbox_harga.Clear();
                txtbox_stok.Clear();
            }
      
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                koneksi.Open();
                string perintah = "insert into tb_betamart (nama_barang,harga_barang,stok_barang) values('" + txtbox_nama.Text + "','" + txtbox_harga.Text + "','" + txtbox_stok.Text + "')";
                OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Tersimpan");
                txtbox_nama.Clear();
                txtbox_harga.Clear();
                txtbox_stok.Clear();

            }
            else
            {
                MessageBox.Show("ID tidak perlu di isi!");
            }
        }

        void ShowData()
        {
            koneksi.Open();
            string perintah = "select * from tb_betamart";
            OleDbDataAdapter da = new OleDbDataAdapter(perintah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Tolong isi ID bila ingin menghapus!");
            }
            else
            {


                koneksi.Open();
                OleDbCommand cmd = koneksi.CreateCommand();
                string perintah = "delete from tb_betamart where auto_id=" + txtID.Text + "";
                cmd.CommandText = perintah;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Barang berhasil dihapus");
                txtID.Clear();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tb_betamart' table. You can move, or remove it, as needed.
            this.tb_betamartTableAdapter.Fill(this.appData.tb_betamart);
            tbbetamartBindingSource.DataSource = this.appData.tb_betamart;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
