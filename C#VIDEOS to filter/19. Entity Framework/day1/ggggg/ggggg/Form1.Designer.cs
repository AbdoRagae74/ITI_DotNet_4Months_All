namespace ggggg
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
            btn_add = new Button();
            tb_name = new TextBox();
            tb_age = new TextBox();
            tb_lname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_depts = new ComboBox();
            cb_super = new ComboBox();
            label5 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // dgv_students
            // 
            dgv_students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(16, 10);
            dgv_students.Name = "dgv_students";
            dgv_students.RowHeadersWidth = 62;
            dgv_students.Size = new Size(741, 567);
            dgv_students.TabIndex = 0;
            dgv_students.RowHeaderMouseDoubleClick += dgv_students_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(966, 212);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(966, 12);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(150, 31);
            tb_name.TabIndex = 2;
            // 
            // tb_age
            // 
            tb_age.Location = new Point(966, 86);
            tb_age.Name = "tb_age";
            tb_age.Size = new Size(150, 31);
            tb_age.TabIndex = 3;
            // 
            // tb_lname
            // 
            tb_lname.Location = new Point(966, 49);
            tb_lname.Name = "tb_lname";
            tb_lname.Size = new Size(150, 31);
            tb_lname.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(832, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(832, 92);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 6;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(832, 55);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(832, 128);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 8;
            label4.Text = "Dept.";
            // 
            // cb_depts
            // 
            cb_depts.FormattingEnabled = true;
            cb_depts.Location = new Point(934, 125);
            cb_depts.Name = "cb_depts";
            cb_depts.Size = new Size(182, 33);
            cb_depts.TabIndex = 9;
            // 
            // cb_super
            // 
            cb_super.FormattingEnabled = true;
            cb_super.Location = new Point(934, 164);
            cb_super.Name = "cb_super";
            cb_super.Size = new Size(182, 33);
            cb_super.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(832, 167);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 11;
            label5.Text = "Supervisor";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(966, 252);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 12;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(966, 292);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 589);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(label5);
            Controls.Add(cb_super);
            Controls.Add(cb_depts);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_lname);
            Controls.Add(tb_age);
            Controls.Add(tb_name);
            Controls.Add(btn_add);
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
        private Button btn_add;
        private TextBox tb_name;
        private TextBox tb_age;
        private TextBox tb_lname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_depts;
        private ComboBox cb_super;
        private Label label5;
        private Button btn_update;
        private Button btn_delete;
    }
}
