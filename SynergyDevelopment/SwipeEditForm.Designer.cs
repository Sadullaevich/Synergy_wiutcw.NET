namespace SynergyDevelopment
{
    partial class SwipeEditForm
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
            components = new System.ComponentModel.Container();
            dtpDate = new DateTimePicker();
            dtpIn = new DateTimePicker();
            dtpOut = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            employeeBindingSource = new BindingSource(components);
            cbxEmpId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/mm/yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(165, 46);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(151, 27);
            dtpDate.TabIndex = 1;
            // 
            // dtpIn
            // 
            dtpIn.CustomFormat = "HH:MM";
            dtpIn.Format = DateTimePickerFormat.Custom;
            dtpIn.Location = new Point(165, 79);
            dtpIn.Name = "dtpIn";
            dtpIn.Size = new Size(151, 27);
            dtpIn.TabIndex = 2;
            // 
            // dtpOut
            // 
            dtpOut.CustomFormat = "HH:MM";
            dtpOut.Format = DateTimePickerFormat.Custom;
            dtpOut.Location = new Point(165, 112);
            dtpOut.Name = "dtpOut";
            dtpOut.Size = new Size(151, 27);
            dtpOut.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 4;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 51);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 84);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 119);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Logout";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(229, 155);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(129, 155);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(DAL.Employee);
            // 
            // cbxEmpId
            // 
            cbxEmpId.DataSource = employeeBindingSource;
            cbxEmpId.DisplayMember = "Name";
            cbxEmpId.FormattingEnabled = true;
            cbxEmpId.Location = new Point(165, 12);
            cbxEmpId.Name = "cbxEmpId";
            cbxEmpId.Size = new Size(151, 28);
            cbxEmpId.TabIndex = 10;
            cbxEmpId.ValueMember = "Id";
            // 
            // SwipeEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 196);
            Controls.Add(cbxEmpId);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpOut);
            Controls.Add(dtpIn);
            Controls.Add(dtpDate);
            Name = "SwipeEditForm";
            Text = "SwipeEditForm";
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpDate;
        private DateTimePicker dtpIn;
        private DateTimePicker dtpOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancel;
        private Button btnSave;
        private BindingSource employeeBindingSource;
        private ComboBox cbxEmpId;
    }
}