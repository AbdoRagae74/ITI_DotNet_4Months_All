namespace AdoD1
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
            dgv_students = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_address = new TextBox();
            cb_dept = new ComboBox();
            btn_add = new Button();
            cb_students = new ComboBox();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(35, 241);
            dgv_students.Name = "dgv_students";
            dgv_students.Size = new Size(715, 177);
            dgv_students.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 28);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 61);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 2;
            label2.Text = "age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 102);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 143);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 4;
            label4.Text = "department";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(564, 23);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 5;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(564, 62);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(100, 23);
            txt_age.TabIndex = 6;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(565, 104);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(100, 23);
            txt_address.TabIndex = 7;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(569, 144);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(121, 23);
            cb_dept.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(686, 185);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 9;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cb_students
            // 
            cb_students.FormattingEnabled = true;
            cb_students.Location = new Point(58, 41);
            cb_students.Name = "cb_students";
            cb_students.Size = new Size(121, 23);
            cb_students.TabIndex = 10;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(198, 44);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(cb_students);
            Controls.Add(btn_add);
            Controls.Add(cb_dept);
            Controls.Add(txt_address);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_students;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_address;
        private ComboBox cb_dept;
        private Button btn_add;
        private ComboBox cb_students;
        private Button btn_delete;
    }
}
