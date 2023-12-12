using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace RESPONSI_483121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Perusahaan";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvData.AutoGenerateColumns = true;
            conn = new NpgsqlConnection(connstring);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connstring))
                {
                    connection.Open();
                    sql = "SELECT * FROM st_insert(:_nama_karyawan,:_nama_dep)";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("_nama_karyawan", txtNama.Text);
                        command.Parameters.AddWithValue("_nama_dep", txtDepartemen.Text);
                        int result = (int)command.ExecuteScalar();
                        if (result == 1)
                        {
                            MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoaddata.PerformClick();
                            txtNama.Text = txtDepartemen.Text = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diEdit", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_update(:_nama_karyawan,:_nama_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("_id_karyawan", txtNama.Text);
                cmd.Parameters.AddWithValue("_nama_karyawan", txtNama.Text);
                cmd.Parameters.AddWithValue("_nama_dep", txtDepartemen.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diEdit", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoaddata.PerformClick();
                    txtNama.Text = txtDepartemen.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtNama.Text = r.Cells["_nama_karyawan"].Value.ToString();
                txtDepartemen.Text = r.Cells["_nama_dep"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diHapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connstring))
                {
                    connection.Open();
                    string deleteSql = @"select * from st_delete(:_id_karyawan)";
                    using (NpgsqlCommand deleteCmd = new NpgsqlCommand(deleteSql, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                        int result = (int)deleteCmd.ExecuteScalar();
                        if (result == 1)
                        {
                            MessageBox.Show("Data Users Berhasil diHapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoaddata.PerformClick();
                            txtNama.Text = txtDepartemen.Text = null;
                            r = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "DELETE FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}