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

namespace CSharpPostgreSQL_CRUD
{
    public partial class frmMain : Form
    {
        private int id = 0;
        private int countRow = 0;
        private DataTable dt = default;
        private DataView dv = default;
        public frmMain()
        {
            InitializeComponent();
        }
        private void resetMe()
        {
            if (dataGridView1.RowCount > 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                btnUpdate.Text = "Update (" + id + ")";
                btnDelete.Text = "Delete (" + id + ")";
                txtFirstName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtLastName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                cbGender.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }
            else
            {
                id = 0;
                txtFirstName.Text = "";
                txtLastName.Text = "";

                if (cbGender.Items.Count > 0)
                {
                    cbGender.SelectedIndex = 0;
                }

                btnUpdate.Text = "Update ()";
                btnDelete.Text = "Delete ()";
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadData("");
            resetMe();
        }
        private void loadData(string keyword)
        {
            dt = CRUD.ReadData();
            countRow = 0;
            countRow = Convert.ToInt32(dt.Rows.Count.ToString());
            toolStripStatusLabel1.Text = "Number of row(s): " + countRow.ToString();
            /*dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;*/
            dataGridView1.DataSource = dt;

            /*dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
            dataGridView1.Columns[3].HeaderText = "Full Name";
            dataGridView1.Columns[4].HeaderText = "Gender";*/

            /*dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 50;*/
            /*//datagrid has calculated it's widths so we can store them
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                //store autosized widths
                int colw = dataGridView1.Columns[i].Width;
                //remove autosizing
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView1.Columns[i].Width = colw;
            }*/
            //set autosize mode
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Vui lòng First Name và Last Name.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                int result = CRUD.CreateData(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), cbGender.SelectedItem.ToString());
                if (result == 1)
                {
                    MessageBox.Show("Đã thêm thành công.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData("");
                    resetMe();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Không thêm được.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtSearch.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex != -1)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                btnUpdate.Text = "Update (" + id + ")";
                btnDelete.Text = "Delete (" + id + ")";
                txtFirstName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtLastName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                cbGender.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }*/
            resetMe();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Vui lòng First Name và Last Name.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                int result = CRUD.UpdateData(id, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), cbGender.SelectedItem.ToString());
                if (result == 1)
                {
                    MessageBox.Show("Đã cập nhật thành công ID = " + id, "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData("");
                    resetMe();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Không có dữ liệu nào được cập nhật.", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Muốn xóa thiệt chứ?","Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int result = CRUD.DeleteData(id);
                if (result == 1)
                {
                    MessageBox.Show("Đã xóa thành công ID = " + id, "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData("");
                    resetMe();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Không có dữ liệu nào được xóa.", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtSearch.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            id = 0;
            txtFirstName.Text = "";
            txtLastName.Text = "";

            if (cbGender.Items.Count > 0)
            {
                cbGender.SelectedIndex = 0;
            }

            btnUpdate.Text = "Update ()";
            btnDelete.Text = "Delete ()";

            txtSearch.Clear();

            if (txtSearch.CanSelect)
            {
                txtSearch.Select();
            }
            dataGridView1.ClearSelection();
            txtFirstName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dv = dt.DefaultView;
            dv.RowFilter = string.Format("Convert (id, 'System.String') Like '%{0}%' " +
                "or first_name like '%{0}%' " +
                "or last_name like '%{0}%' " +
                "or gender like '%{0}%' ", txtSearch.Text.Trim());
            dataGridView1.DataSource = dv.ToTable();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dv = dt.DefaultView;
            dv.RowFilter = string.Format("Convert (id, 'System.String') Like '%{0}%' " +
                "or first_name like '%{0}%' " +
                "or last_name like '%{0}%' " +
                "or gender like '%{0}%' ", txtSearch.Text.Trim());
            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
