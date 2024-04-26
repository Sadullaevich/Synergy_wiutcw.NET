namespace SynergyDevelopment
{
    partial class EmployeeEditForm
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
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            chbIsActive = new CheckBox();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpDischargeDate = new DateTimePicker();
            tbxname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(123, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(221, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chbIsActive
            // 
            chbIsActive.AutoSize = true;
            chbIsActive.CheckAlign = ContentAlignment.MiddleRight;
            chbIsActive.Location = new Point(12, 59);
            chbIsActive.Name = "chbIsActive";
            chbIsActive.Size = new Size(156, 24);
            chbIsActive.TabIndex = 4;
            chbIsActive.Text = "Active                     ";
            chbIsActive.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(150, 91);
            dtpStartDate.MaxDate = new DateTime(2300, 12, 31, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(165, 27);
            dtpStartDate.TabIndex = 5;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "Start date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 7;
            label3.Text = "Discharge date";
            // 
            // dtpDischargeDate
            // 
            dtpDischargeDate.Format = DateTimePickerFormat.Custom;
            dtpDischargeDate.Location = new Point(150, 134);
            dtpDischargeDate.Name = "dtpDischargeDate";
            dtpDischargeDate.Size = new Size(165, 27);
            dtpDischargeDate.TabIndex = 8;
            // 
            // tbxname
            // 
            tbxname.Location = new Point(150, 15);
            tbxname.Name = "tbxname";
            tbxname.Size = new Size(162, 27);
            tbxname.TabIndex = 9;
            // 
            // EmployeeEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 233);
            Controls.Add(tbxname);
            Controls.Add(dtpDischargeDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpStartDate);
            Controls.Add(chbIsActive);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "EmployeeEditForm";
            Text = "New Employee";
            Load += EmployeeEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox chbIsActive;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDischargeDate;
        private TextBox tbxname;
    }
}