using Microsoft.VisualBasic.Devices;
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
using System.Xml.Linq;

namespace SynergyDevelopment
{
    public partial class SwipeEditForm : Form
    {
        public SwipeEditForm()
        {
            InitializeComponent();
        }


        public Swipe Swipe { get; set; }
        public FormMode Mode { get; set; }

        public void CreateNewSwipe()
        {
            Mode = FormMode.CreateNew;
            Swipe = new Swipe();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateSwipe(Swipe Swipe)
        {
            Mode = FormMode.Update;
            Swipe = new Swipe();
            InitializeControls();
            ShowSwipeInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowSwipeInControls()
        {

        }

        private void GrabUserInput()
        {


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new SwipeManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Swipe);


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
    }
}
