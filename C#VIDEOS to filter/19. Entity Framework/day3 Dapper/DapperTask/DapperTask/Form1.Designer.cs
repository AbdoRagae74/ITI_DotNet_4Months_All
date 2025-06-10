namespace DapperTask
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
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            tb_name = new TextBox();
            tb_dur = new TextBox();
            cb_topic = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(11, 8);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(652, 430);
            dgv.TabIndex = 0;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(695, 18);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(695, 55);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Duration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(695, 105);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 5;
            label5.Text = "Topic";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(820, 12);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(150, 31);
            tb_name.TabIndex = 6;
            // 
            // tb_dur
            // 
            tb_dur.Location = new Point(820, 55);
            tb_dur.Name = "tb_dur";
            tb_dur.Size = new Size(150, 31);
            tb_dur.TabIndex = 7;
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(820, 105);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(150, 33);
            cb_topic.TabIndex = 10;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(753, 268);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(753, 325);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 12;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(753, 379);
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
            ClientSize = new Size(982, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(cb_topic);
            Controls.Add(tb_dur);
            Controls.Add(tb_name);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_name;
        private TextBox tb_dur;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox cb_topic;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}
