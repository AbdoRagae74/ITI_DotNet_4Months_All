namespace AdoD1
{
    partial class DepartmetDisconnected
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
            DGV_dept = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txt_name = new TextBox();
            txt_location = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_savechanged = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_dept).BeginInit();
            SuspendLayout();
            // 
            // DGV_dept
            // 
            DGV_dept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_dept.Location = new Point(52, 211);
            DGV_dept.Name = "DGV_dept";
            DGV_dept.Size = new Size(752, 209);
            DGV_dept.TabIndex = 0;
            DGV_dept.RowHeaderMouseDoubleClick += DGV_dept_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 79);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Location";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(615, 30);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 3;
            // 
            // txt_location
            // 
            txt_location.Location = new Point(614, 79);
            txt_location.Name = "txt_location";
            txt_location.Size = new Size(100, 23);
            txt_location.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(680, 130);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 5;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(564, 130);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 6;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_savechanged
            // 
            btn_savechanged.Location = new Point(636, 439);
            btn_savechanged.Name = "btn_savechanged";
            btn_savechanged.Size = new Size(168, 23);
            btn_savechanged.TabIndex = 7;
            btn_savechanged.Text = "Save changed";
            btn_savechanged.UseVisualStyleBackColor = true;
            btn_savechanged.Click += btn_savechanged_Click;
            // 
            // DepartmetDisconnected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 484);
            Controls.Add(btn_savechanged);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_location);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGV_dept);
            Name = "DepartmetDisconnected";
            Text = "DepartmetDisconnected";
            FormClosing += DepartmetDisconnected_FormClosing;
            Load += DepartmetDisconnected_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_dept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_dept;
        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_location;
        private Button btn_add;
        private Button btn_update;
        private Button btn_savechanged;
    }
}