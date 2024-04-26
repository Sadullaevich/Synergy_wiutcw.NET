using SynergyDevelopment.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynergyDevelopment
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new EmployeeManager().GetAll();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }
        //sort button functions
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by!"); //sort function validating

            else if (cbxSort.SelectedIndex == 0)
            {
                ByAttribute attribute;
                attribute = ByAttribute.Name;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Sort(attribute);
            }

            else if (cbxSort.SelectedIndex == 1)
            {
                ByAttribute attribute;
                attribute = ByAttribute.Active;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Sort(attribute);
            }

            else if (cbxSort.SelectedIndex == 2)
            {
                ByAttribute attribute;
                attribute = ByAttribute.InActive;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Sort(attribute);
            }

            else
            {
                ByAttribute attribute;
                attribute = ByAttribute.All;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Sort(attribute);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Provide the search term!");
            else
            {
                var selectedAttribute = ByAttribute.Name;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Search(tbxSearch.Text, selectedAttribute);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEditForm();
            form.CreateNewEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an applicant");
            else
            {
                var a = (Employee)dgv.SelectedRows[0].DataBoundItem;
                new EmployeeManager().Delete(a.Id);
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an applicant");
            else
            {
                var a = (Employee)dgv.SelectedRows[0].DataBoundItem;
                new EmployeeEditForm().UpdateEmployee(a);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
