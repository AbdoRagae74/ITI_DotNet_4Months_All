using EFday2Task.Models;

namespace EFday2Task
{
    public partial class Form1 : Form
    {
        NewsDBContext NewsDBContext;
        public Form1()
        {
            InitializeComponent();
            NewsDBContext = new NewsDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = NewsDBContext.News.ToList();

            cb_author.DataSource = NewsDBContext.Authors.ToList();
            cb_author.DisplayMember = "Name";
            cb_author.ValueMember = "Id";

            cb_cat.DataSource = NewsDBContext.Categories.ToList();
            cb_cat.DisplayMember = "Name";
            cb_cat.ValueMember = "Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            News newNews = new News
            {
                Title = tb_title.Text,
                Brief = tb_brief.Text,
                Description = tb_desc.Text,
                //PublishDate = dateTimePicker1,
                AuthorId = (int)cb_author.SelectedValue,
                CategoryId = (int)cb_cat.SelectedValue,
            };

            NewsDBContext.News.Add(newNews);

            tb_title.Text = tb_brief.Text = tb_desc.Text = "";

            NewsDBContext.SaveChanges();

            Form1_Load(null, null);

            MessageBox.Show("Added!");
        }

        int selectedNewsId;
        News selectedNews;
        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgv.SelectedRows[0];
            selectedNewsId = (int)row.Cells[0].Value;

            selectedNews = NewsDBContext.News.Where(n => n.Id == selectedNewsId).SingleOrDefault();

            tb_title.Text = selectedNews.Title;
            tb_brief.Text = selectedNews.Brief;
            tb_desc.Text = selectedNews.Description;
            cb_author.SelectedValue = selectedNews.AuthorId;
            cb_cat.SelectedValue = selectedNews.CategoryId;



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            selectedNews.Title = tb_title.Text;
            selectedNews.Brief = tb_brief.Text;
            selectedNews.Description = tb_desc.Text;
            selectedNews.AuthorId = (int)cb_author.SelectedValue;
            selectedNews.CategoryId = (int)cb_cat.SelectedValue;
            NewsDBContext.SaveChanges();
            tb_title.Text = tb_brief.Text = tb_desc.Text = "";


            Form1_Load(null, null);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            NewsDBContext.News.Remove(selectedNews);
            NewsDBContext.SaveChanges();
            Form1_Load(null, null);
            tb_title.Text = tb_brief.Text = tb_desc.Text = "";

        }
    }
}
