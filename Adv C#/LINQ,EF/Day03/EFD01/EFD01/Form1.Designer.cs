namespace EFD01
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
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_first_name = new TextBox();
            txt_second_name = new TextBox();
            txt_address = new TextBox();
            txt_Age = new TextBox();
            cb_depts = new ComboBox();
            cb_super = new ComboBox();
            stdGV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            supervisor = new Label();
            txt_dept = new Label();
            ((System.ComponentModel.ISupportInitialize)stdGV).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(83, 210);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 0;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(202, 210);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 1;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(335, 210);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Remove";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_first_name
            // 
            txt_first_name.Location = new Point(98, 26);
            txt_first_name.Name = "txt_first_name";
            txt_first_name.Size = new Size(125, 27);
            txt_first_name.TabIndex = 3;
            // 
            // txt_second_name
            // 
            txt_second_name.Location = new Point(314, 26);
            txt_second_name.Name = "txt_second_name";
            txt_second_name.Size = new Size(125, 27);
            txt_second_name.TabIndex = 4;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(314, 90);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(125, 27);
            txt_address.TabIndex = 6;
            // 
            // txt_Age
            // 
            txt_Age.Location = new Point(98, 90);
            txt_Age.Name = "txt_Age";
            txt_Age.Size = new Size(125, 27);
            txt_Age.TabIndex = 5;
            // 
            // cb_depts
            // 
            cb_depts.FormattingEnabled = true;
            cb_depts.Location = new Point(98, 140);
            cb_depts.Name = "cb_depts";
            cb_depts.Size = new Size(151, 28);
            cb_depts.TabIndex = 7;
            // 
            // cb_super
            // 
            cb_super.FormattingEnabled = true;
            cb_super.Location = new Point(288, 140);
            cb_super.Name = "cb_super";
            cb_super.Size = new Size(151, 28);
            cb_super.TabIndex = 8;
            // 
            // stdGV
            // 
            stdGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stdGV.Location = new Point(12, 261);
            stdGV.Name = "stdGV";
            stdGV.RowHeadersWidth = 51;
            stdGV.Size = new Size(776, 188);
            stdGV.TabIndex = 9;
            stdGV.RowHeaderMouseDoubleClick += stdGV_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 37);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 11;
            label2.Text = "Second Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 93);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 12;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 13;
            label4.Text = "Age";
            // 
            // supervisor
            // 
            supervisor.AutoSize = true;
            supervisor.Location = new Point(480, 148);
            supervisor.Name = "supervisor";
            supervisor.Size = new Size(80, 20);
            supervisor.TabIndex = 14;
            supervisor.Text = "SuperVisor";
            // 
            // txt_dept
            // 
            txt_dept.AutoSize = true;
            txt_dept.Location = new Point(3, 148);
            txt_dept.Name = "txt_dept";
            txt_dept.Size = new Size(89, 20);
            txt_dept.TabIndex = 15;
            txt_dept.Text = "Department";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_dept);
            Controls.Add(supervisor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stdGV);
            Controls.Add(cb_super);
            Controls.Add(cb_depts);
            Controls.Add(txt_address);
            Controls.Add(txt_Age);
            Controls.Add(txt_second_name);
            Controls.Add(txt_first_name);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)stdGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_first_name;
        private TextBox txt_second_name;
        private TextBox txt_address;
        private TextBox txt_Age;
        private ComboBox cb_depts;
        private ComboBox cb_super;
        private DataGridView stdGV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label supervisor;
        private Label txt_dept;
    }
}
