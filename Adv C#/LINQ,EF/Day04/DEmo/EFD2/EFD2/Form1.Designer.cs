namespace EFD2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_employee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_employee).BeginInit();
            SuspendLayout();
            // 
            // dgv_employee
            // 
            dgv_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_employee.Location = new Point(25, 131);
            dgv_employee.Name = "dgv_employee";
            dgv_employee.RowHeadersWidth = 51;
            dgv_employee.Size = new Size(1013, 323);
            dgv_employee.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 450);
            Controls.Add(dgv_employee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_employee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_employee;
    }
}
