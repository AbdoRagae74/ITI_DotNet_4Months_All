using EFD02.Models;

namespace EFD02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            newsDB = new NewsContext();
        }
        NewsContext newsDB;
        private void fillGV()
        {

            var x = newsDB.Authors.Where(x=>x.Id==1).Select(x=>x.news).ToList();
            NewsGV.DataSource = newsDB.News.ToList();
            NewsGV.Columns[8].Visible = false;
            NewsGV.Columns[7].Visible = false;
            
            cb_author.DataSource = newsDB.Authors.ToList();
            cb_author.DisplayMember = "Name";
            cb_author.ValueMember = "Id";

            cb_category.DataSource = newsDB.Categories.ToList();
            cb_category.DisplayMember = "Name";
            cb_category.ValueMember = "Id";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillGV();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            News newOne = new News()
            {
                AuthorID = (int)cb_author.SelectedValue,
                Title = txt_title.Text,
                Brief = txt_brief.Text,
                CategoryID = (int)cb_category.SelectedValue,
                Description = txt_desc.Text,
                NewsDate = DateTime.Now

            };
            newsDB.Add(newOne);
            newsDB.SaveChanges();
            fillGV();
            MessageBox.Show("Added");
        }
        int newsId;
        News n = new News();
        private void NewsGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            newsId = (int)NewsGV.SelectedRows[0].Cells[0].Value;
            n = newsDB.News.Where(n => n.ID == newsId).SingleOrDefault();
            cb_author.SelectedValue = n.AuthorID;
            txt_title.Text = n.Title;
            txt_brief.Text = n.Brief;
            cb_category.SelectedValue = n.CategoryID;
            txt_desc.Text = n.Description;
            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            n.AuthorID = (int)cb_author.SelectedValue;
            n.Title = txt_title.Text;
            n.Brief = txt_brief.Text;
            n.CategoryID = (int)cb_category.SelectedValue;
            n.Description = txt_desc.Text;
            newsDB.SaveChanges();
            txt_desc.Text = txt_title.Text = txt_brief.Text = "";
            fillGV();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            MessageBox.Show("Updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            newsDB.Remove(n);
            newsDB.SaveChanges();
            txt_desc.Text = txt_title.Text = txt_brief.Text = "";
            fillGV();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            MessageBox.Show("Deleted");
        }
    }
}
