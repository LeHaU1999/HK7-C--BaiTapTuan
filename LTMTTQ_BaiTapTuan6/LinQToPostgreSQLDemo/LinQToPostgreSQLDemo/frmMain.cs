using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbCrudContext;

namespace LinQToPostgreSQLDemo
{
    public partial class frmMain : Form
    {
        private DbCrudDataContext _db = new DbCrudDataContext();
        private int id = 0;
        private int countRow = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DefaultCellStyle.Font = new Font("Time New ", 15);
            LoadData();
            ResetMe();
        }

        private void ResetMe()
        {
            if (dataGridView1.RowCount > 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                btnUpdate.Text = "Update (" + id + ")";
                btnDelete.Text = "Delete (" + id + ")";
                txtFirstName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtLastName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                cbGender.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
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

        private void LoadData()
        {
            //dataGridView1.DataSource = _db.Cruds.Select(row => row);
            dataGridView1.DataSource = from crud in _db.Cruds
                                       orderby crud.Id
                                       select crud;
            toolStripStatusLabel1.Text = "Number of row(s): " + _db.Cruds.Count().ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetMe();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Vui lòng First Name và Last Name.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Crud newCrud = new Crud();
                newCrud.FirstName = txtFirstName.Text.Trim();
                newCrud.LastName = txtLastName.Text.Trim();
                newCrud.Gender = cbGender.SelectedItem.ToString();
                _db.Cruds.InsertOnSubmit(newCrud);
                // Send the changes to the database.
                // Until you do it, the changes are cached on the client side.
                _db.SubmitChanges();
                MessageBox.Show("Đã thêm thành công.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetMe();
            }
            txtSearch.Clear();
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
                /*var cl = (List<Crud>)crudBindingSource.DataSource;
                foreach (Crud item in cl)
                {
                    if (item.Id != 0)
                    {
                        var up_item = (from d in _db.Cruds where d.Id == item.Id select d).FirstOrDefault();
                        if (up_item == null)
                        {
                            continue;
                        }
                        up_item.FirstName = item.FirstName;
                        up_item.LastName = item.LastName;
                        up_item.Gender = item.Gender;

                        _db.SubmitChanges();
                    }
                }*/
                var up_item = (from d in _db.Cruds 
                               where d.Id == id 
                               select d).FirstOrDefault();
                if (up_item != null)
                {
                    up_item.FirstName = txtFirstName.Text.Trim();
                    up_item.LastName = txtLastName.Text.Trim();
                    up_item.Gender = cbGender.SelectedItem.ToString();

                    _db.SubmitChanges();

                    MessageBox.Show("Đã cập nhật thành công ID = " + id, "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetMe();
                }
            }
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Muốn xóa thiệt chứ?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var del_item = (from d in _db.Cruds
                               where d.Id == id
                               select d).FirstOrDefault();
                if (del_item != null)
                {
                    _db.Cruds.DeleteOnSubmit(del_item);
                    _db.SubmitChanges();
                    MessageBox.Show("Đã xóa thành công ID = " + id, "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetMe();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = _db.Cruds.Where(c => /*c.Id == Int64.Parse(txtSearch.Text.Trim())
                                                ||*/ c.LastName.Contains(txtSearch.Text.Trim())
                                                || c.FirstName.Contains(txtSearch.Text.Trim())
                                                || c.Gender.Contains(txtSearch.Text.Trim()))
                                                .OrderBy(c => c.Id);
            dataGridView1.DataSource = query;
            toolStripStatusLabel1.Text = "Number of row(s): " + dataGridView1.Rows.Count.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*string s = txtSearch.Text.Trim();
            if (s != "")
            {
                dataGridView1.DataSource = from d in _db.Cruds
                                           where d.FirstName == s || d.LastName == s || d.Gender == s
                                           orderby d.Id
                                           select d;
            }
            else
            {
                dataGridView1.DataSource = from crud in _db.Cruds
                                           orderby crud.Id
                                           select crud;
            }*/
        }
    }
}
