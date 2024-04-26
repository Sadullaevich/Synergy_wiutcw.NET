namespace SynergyDevelopment
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            newEmployeeToolStripMenuItem = new ToolStripMenuItem();
            allEmployeesToolStripMenuItem = new ToolStripMenuItem();
            swipeToolStripMenuItem = new ToolStripMenuItem();
            oldSwipesToolStripMenuItem = new ToolStripMenuItem();
            newSwipeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, employeeToolStripMenuItem, swipeToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newEmployeeToolStripMenuItem, allEmployeesToolStripMenuItem });
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(95, 24);
            employeeToolStripMenuItem.Text = "Employees";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // newEmployeeToolStripMenuItem
            // 
            newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            newEmployeeToolStripMenuItem.Size = new Size(192, 26);
            newEmployeeToolStripMenuItem.Text = "New employee";
            newEmployeeToolStripMenuItem.Click += newEmployeeToolStripMenuItem_Click;
            // 
            // allEmployeesToolStripMenuItem
            // 
            allEmployeesToolStripMenuItem.Name = "allEmployeesToolStripMenuItem";
            allEmployeesToolStripMenuItem.Size = new Size(192, 26);
            allEmployeesToolStripMenuItem.Text = "All employees";
            allEmployeesToolStripMenuItem.Click += allEmployeesToolStripMenuItem_Click;
            // 
            // swipeToolStripMenuItem
            // 
            swipeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oldSwipesToolStripMenuItem, newSwipeToolStripMenuItem });
            swipeToolStripMenuItem.Name = "swipeToolStripMenuItem";
            swipeToolStripMenuItem.Size = new Size(69, 24);
            swipeToolStripMenuItem.Text = "Swipes";
            swipeToolStripMenuItem.Click += swipeToolStripMenuItem_Click;
            // 
            // oldSwipesToolStripMenuItem
            // 
            oldSwipesToolStripMenuItem.Name = "oldSwipesToolStripMenuItem";
            oldSwipesToolStripMenuItem.Size = new Size(164, 26);
            oldSwipesToolStripMenuItem.Text = "All swipes";
            oldSwipesToolStripMenuItem.Click += oldSwipesToolStripMenuItem_Click;
            // 
            // newSwipeToolStripMenuItem
            // 
            newSwipeToolStripMenuItem.Name = "newSwipeToolStripMenuItem";
            newSwipeToolStripMenuItem.Size = new Size(164, 26);
            newSwipeToolStripMenuItem.Text = "New swipe";
            newSwipeToolStripMenuItem.Click += newSwipeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ParentForm";
            Text = "SynergyDevelopment";
            WindowState = FormWindowState.Maximized;
            Load += ParentForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem newEmployeeToolStripMenuItem;
        private ToolStripMenuItem allEmployeesToolStripMenuItem;
        private ToolStripMenuItem swipeToolStripMenuItem;
        private ToolStripMenuItem newSwipeToolStripMenuItem;
        private ToolStripMenuItem oldSwipesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}