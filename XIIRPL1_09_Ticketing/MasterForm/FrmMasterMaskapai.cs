using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL1_09_Ticketing.MasterForm
{
    public partial class FrmMasterMaskapai : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;

        public FrmMasterMaskapai()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMasterMaskapai_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_09.tbl_maskapai" +
                    "(id,nama,perusahaan,jumlah_kru,deskripsi)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtPerusahaan.Text + "'," +
                    "'" + txtJumlahKru.Text + "'," +
                    "'" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Maskapai");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_09.tbl_maskapai", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_09.tbl_maskapai");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Nama";
            dataGridView1.Columns[4].HeaderText = "Perusahaan";
            dataGridView1.Columns[5].HeaderText = "Jumlah Kru";
            dataGridView1.Columns[6].HeaderText = "Deskripsi";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_09.tbl_maskapai where id in(select max(id) FROM db_ticket_xii_rpl_1_09.tbl_maskapai) order by id desc";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            koneksi.conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_09.tbl_maskapai WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nama"].Value);
                txtPerusahaan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["perusahaan"].Value);
                txtJumlahKru.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["jumlah_kru"].Value);
                txtDeskripsi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["deskripsi"].Value);
                btnSimpan.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_09.tbl_maskapai SET " +
                "nama = '" + txtNama.Text + "', " +
                "perusahaan = '" + txtPerusahaan.Text + "', " +
                "jumlah_kru = '" + txtJumlahKru.Text + "', " +
                "deskripsi = '" + txtDeskripsi.Text + "'" +
                "WHERE id='" + id.Text + "'";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Ubah Data Maskapai");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
