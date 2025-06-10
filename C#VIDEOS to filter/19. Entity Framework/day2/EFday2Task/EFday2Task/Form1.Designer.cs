namespace EFday2Task
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
            dgv = new DataGridView();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_title = new TextBox();
            tb_brief = new TextBox();
            tb_desc = new TextBox();
            cb_author = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            cb_cat = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(13, 319);
            dgv.Margin = new Padding(4, 5, 4, 5);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(1490, 490);
            dgv.TabIndex = 0;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(565, 23);
            btn_add.Margin = new Padding(4, 5, 4, 5);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(154, 68);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(565, 180);
            btn_delete.Margin = new Padding(4, 5, 4, 5);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(154, 68);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(565, 102);
            btn_update.Margin = new Padding(4, 5, 4, 5);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(154, 68);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 5;
            label2.Text = "Brief";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 173);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 7;
            label4.Text = "Publish Date";
            // 
            // tb_title
            // 
            tb_title.Location = new Point(144, 23);
            tb_title.Margin = new Padding(4, 5, 4, 5);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(320, 31);
            tb_title.TabIndex = 8;
            // 
            // tb_brief
            // 
            tb_brief.Location = new Point(144, 68);
            tb_brief.Margin = new Padding(4, 5, 4, 5);
            tb_brief.Name = "tb_brief";
            tb_brief.Size = new Size(320, 31);
            tb_brief.TabIndex = 9;
            // 
            // tb_desc
            // 
            tb_desc.Location = new Point(144, 115);
            tb_desc.Margin = new Padding(4, 5, 4, 5);
            tb_desc.Name = "tb_desc";
            tb_desc.Size = new Size(320, 31);
            tb_desc.TabIndex = 10;
            // 
            // cb_author
            // 
            cb_author.FormattingEnabled = true;
            cb_author.Location = new Point(144, 212);
            cb_author.Margin = new Padding(4, 5, 4, 5);
            cb_author.Name = "cb_author";
            cb_author.Size = new Size(171, 33);
            cb_author.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(144, 163);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // cb_cat
            // 
            cb_cat.FormattingEnabled = true;
            cb_cat.Location = new Point(144, 260);
            cb_cat.Margin = new Padding(4, 5, 4, 5);
            cb_cat.Name = "cb_cat";
            cb_cat.Size = new Size(171, 33);
            cb_cat.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 217);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 14;
            label5.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 265);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 15;
            label6.Text = "Category";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 832);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cb_cat);
            Controls.Add(dateTimePicker1);
            Controls.Add(cb_author);
            Controls.Add(tb_desc);
            Controls.Add(tb_brief);
            Controls.Add(tb_title);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(dgv);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_title;
        private TextBox tb_brief;
        private TextBox tb_desc;
        private ComboBox cb_author;
        private DateTimePicker dateTimePicker1;
        private ComboBox cb_cat;
        private Label label5;
        private Label label6;
    }
}
