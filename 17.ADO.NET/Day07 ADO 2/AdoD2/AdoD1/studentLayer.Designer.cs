namespace AdoD1
{
    partial class studentLayer
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
            btn_update = new Button();
            btn_add = new Button();
            cb_dept = new ComboBox();
            txt_address = new TextBox();
            txt_age = new TextBox();
            txt_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_students = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.Location = new Point(591, 190);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 25;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(688, 190);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 22;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(571, 149);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(121, 23);
            cb_dept.TabIndex = 21;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(567, 109);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(100, 23);
            txt_address.TabIndex = 20;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(566, 67);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(100, 23);
            txt_age.TabIndex = 19;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(566, 28);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 148);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 17;
            label4.Text = "department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 107);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 16;
            label3.Text = "address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 66);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 15;
            label2.Text = "age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 33);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 14;
            label1.Text = "name";
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(37, 246);
            dgv_students.Name = "dgv_students";
            dgv_students.Size = new Size(715, 177);
            dgv_students.TabIndex = 13;
            // 
            // studentLayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_update);
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
            Name = "studentLayer";
            Text = "studentLayer";
            Load += studentLayer_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private Button btn_add;
        private ComboBox cb_dept;
        private TextBox txt_address;
        private TextBox txt_age;
        private TextBox txt_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_students;
    }
}