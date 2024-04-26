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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void swipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutform = new AboutForm();
            aboutform.ShowDialog();
        }

        private void allEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<EmployeeListForm>().Show();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEditForm();
            form.CreateNewEmployee();
        }

        private void oldSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<SwipeListForm>().Show();
        }

        private void newSwipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SwipeEditForm();
            form.CreateNewSwipe();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
