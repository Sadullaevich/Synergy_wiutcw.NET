using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynergyDevelopment.DAL;
using System.Xml.Linq;

namespace SynergyDevelopment
{
    //add new employee and send data to database
    public partial class EmployeeEditForm : Form
    {
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        public Employee Employee { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewEmployee()
        {
            Mode = FormMode.CreateNew;
            Employee = new Employee();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateEmployee(Employee employee)
        {
            Mode = FormMode.Update;
            Employee = employee;
            InitializeControls();
            ShowEmployeeInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowEmployeeInControls()
        {
            tbxname.Text = Employee.Name;
            dtpStartDate.Value = Employee.StartDate;
            dtpDischargeDate.Value = Employee.DischargeDate;
            chbIsActive.Checked = Employee.IsActive;
        }

        private void GrabUserInput()
        {
            Employee.Name = tbxname.Text;
            Employee.StartDate = dtpStartDate.Value;
            Employee.DischargeDate = dtpDischargeDate.Value;
            Employee.IsActive = chbIsActive.Checked;
        }

        //Save button.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new EmployeeManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Employee);
                else
                    manager.Update(Employee);

                MyForms.GetForm<EmployeeListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
