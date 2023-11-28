using Npgsql;
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
    public partial class FrmMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterKodePromo()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMasterKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_09.tbl_kode_promo" +
                    "(id,kode_promo,berlaku_sampai,persentase_diskon,maksimum_diskon,deskripsi)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePromo.Text + "'," +
                    "'" + txtBerlakuSampai.Text + "'," +
                    "'" + txtPersentaseDiskon.Text + "'," +
                    "'" + txtMaksimumDiskon.Text + "'," +
                    "'" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Kode Promo");
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
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_09.tbl_kode_promo", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_09.tbl_kode_promo");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Kode Promo";
            dataGridView1.Columns[4].HeaderText = "Berlaku Sampai";
            dataGridView1.Columns[5].HeaderText = "Persentase Diskon";
            dataGridView1.Columns[6].HeaderText = "Maksimum Diskon";
            dataGridView1.Columns[7].HeaderText = "Deskripsi";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_09.tbl_kode_promo where id in(select max(id) FROM db_ticket_xii_rpl_1_09.tbl_kode_promo) order by id desc";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_09.tbl_kode_promo WHERE id=@id";
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
        }
    }
}
