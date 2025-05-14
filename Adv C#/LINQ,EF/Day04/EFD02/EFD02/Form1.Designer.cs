namespace EFD02
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
            NewsGV = new DataGridView();
            btn_add = new Button();
            label1 = new Label();
            txt_title = new TextBox();
            txt_brief = new RichTextBox();
            label2 = new Label();
            label11 = new Label();
            txt_desc = new RichTextBox();
            cb_category = new ComboBox();
            cb_author = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)NewsGV).BeginInit();
            SuspendLayout();
            // 
            // NewsGV
            // 
            NewsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NewsGV.Location = new Point(12, 232);
            NewsGV.Name = "NewsGV";
            NewsGV.RowHeadersWidth = 51;
            NewsGV.Size = new Size(776, 206);
            NewsGV.TabIndex = 0;
            NewsGV.RowHeaderMouseDoubleClick += NewsGV_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(351, 15);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(103, 12);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(151, 27);
            txt_title.TabIndex = 3;
            // 
            // txt_brief
            // 
            txt_brief.Location = new Point(103, 56);
            txt_brief.Name = "txt_brief";
            txt_brief.Size = new Size(151, 42);
            txt_brief.TabIndex = 4;
            txt_brief.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "Brief";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(495, 78);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 15;
            label11.Text = "News Description";
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(340, 106);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(398, 120);
            txt_desc.TabIndex = 14;
            txt_desc.Text = "";
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(103, 120);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(151, 28);
            cb_category.TabIndex = 16;
            // 
            // cb_author
            // 
            cb_author.FormattingEnabled = true;
            cb_author.Location = new Point(103, 168);
            cb_author.Name = "cb_author";
            cb_author.Size = new Size(151, 28);
            cb_author.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 18;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 19;
            label4.Text = "Author";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(471, 15);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 20;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(644, 15);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 21;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_author);
            Controls.Add(cb_category);
            Controls.Add(label11);
            Controls.Add(txt_desc);
            Controls.Add(label2);
            Controls.Add(txt_brief);
            Controls.Add(txt_title);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(NewsGV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NewsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView NewsGV;
        private Button btn_add;
        private Label label1;
        private TextBox txt_title;
        private RichTextBox txt_brief;
        private Label label2;
        private Label label11;
        private RichTextBox txt_desc;
        private ComboBox cb_category;
        private ComboBox cb_author;
        private Label label3;
        private Label label4;
        private Button btn_update;
        private Button btn_delete;
    }
}
