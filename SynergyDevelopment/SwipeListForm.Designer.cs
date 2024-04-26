namespace SynergyDevelopment
{
    partial class SwipeListForm
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
            swipeBindingSource = new BindingSource(components);
            swipeBindingSource1 = new BindingSource(components);
            btnAdd = new Button();
            dgv = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            outTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            swipeBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)swipeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)swipeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)swipeBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // swipeBindingSource
            // 
            swipeBindingSource.DataSource = typeof(DAL.Swipe);
            // 
            // swipeBindingSource1
            // 
            swipeBindingSource1.DataSource = typeof(DAL.Swipe);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(720, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "New Swipe";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, empIdDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, inTimeDataGridViewTextBoxColumn, outTimeDataGridViewTextBoxColumn });
            dgv.DataSource = swipeBindingSource2;
            dgv.Location = new Point(12, 12);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(802, 236);
            dgv.TabIndex = 2;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            empIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            empIdDataGridViewTextBoxColumn.ReadOnly = true;
            empIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // inTimeDataGridViewTextBoxColumn
            // 
            inTimeDataGridViewTextBoxColumn.DataPropertyName = "InTime";
            inTimeDataGridViewTextBoxColumn.HeaderText = "InTime";
            inTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            inTimeDataGridViewTextBoxColumn.Name = "inTimeDataGridViewTextBoxColumn";
            inTimeDataGridViewTextBoxColumn.ReadOnly = true;
            inTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // outTimeDataGridViewTextBoxColumn
            // 
            outTimeDataGridViewTextBoxColumn.DataPropertyName = "OutTime";
            outTimeDataGridViewTextBoxColumn.HeaderText = "OutTime";
            outTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            outTimeDataGridViewTextBoxColumn.Name = "outTimeDataGridViewTextBoxColumn";
            outTimeDataGridViewTextBoxColumn.ReadOnly = true;
            outTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // swipeBindingSource2
            // 
            swipeBindingSource2.DataSource = typeof(DAL.Swipe);
            // 
            // SwipeListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 295);
            Controls.Add(dgv);
            Controls.Add(btnAdd);
            Name = "SwipeListForm";
            Text = "Swipes";
            Load += SwipeListForm_Load;
            ((System.ComponentModel.ISupportInitialize)swipeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)swipeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)swipeBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource swipeBindingSource;
        private BindingSource swipeBindingSource1;
        private Button btnAdd;
        private DataGridView dgv;
        private BindingSource swipeBindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outTimeDataGridViewTextBoxColumn;
    }
}