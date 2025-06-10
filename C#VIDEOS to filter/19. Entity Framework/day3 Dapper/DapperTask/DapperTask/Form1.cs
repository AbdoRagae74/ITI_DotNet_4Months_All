using Dapper;
using Microsoft.Data.SqlClient;
using DapperTask.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace DapperTask
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            con = new SqlConnection("Data Source =.\\sqlexpress; Initial Catalog = ITI; Integrated Security = True; Encrypt = True; Trust Server Certificate = True");
            InitializeComponent();
        }
        int lastId;
        private void Form1_Load(object sender, EventArgs e)
        {
            var q1 = con.Query<Course>("select * from course").ToList();

            lastId = con.ExecuteScalar<int>("select crs_id from course where crs_id = (select max(crs_id) from Course)");

            dgv.DataSource = q1;

            var q2 = con.Query<Topic>("select * from Topic").ToList();

            cb_topic.DataSource = q2;
            cb_topic.ValueMember = "Top_Id";
            cb_topic.DisplayMember = "Top_Name";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course
            {
                Crs_Id = ++lastId,
                Crs_Name = tb_name.Text,
                Crs_Duration = int.Parse(tb_dur.Text),
                Top_Id = (int)cb_topic.SelectedValue
            };

            int rooAffected =
            con.Execute("insert into course values(@id,@name,@dur,@topId)", new
            {
                id = newCourse.Crs_Id,
                name = newCourse.Crs_Name,
                dur = newCourse.Crs_Duration,
                topId = newCourse.Top_Id
            });

            if (rooAffected > 0)
            {
                MessageBox.Show("added!");
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        int selectedId;
        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgv.SelectedRows[0];
            selectedId = (int)row.Cells[0].Value;

            tb_name.Text = row.Cells[1].Value.ToString();
            tb_dur.Text = row.Cells[2].Value.ToString();
            cb_topic.SelectedValue = row.Cells[3].Value;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int rowAffected =
            con.Execute("UPDATE Course SET crs_name = @name, crs_duration = @dur, Top_Id = @topId WHERE crs_id = @id",
    new
    {
        id = selectedId,
        name = tb_name.Text,
        dur = int.Parse(tb_dur.Text), 
        topId = cb_topic.SelectedValue
    });

            if (rowAffected > 0)
            {
                MessageBox.Show("Updated!");
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowAffected =
            con.Execute("delete from Course WHERE crs_id = @id",
            new
            {
                id = selectedId,
            });

            if (rowAffected > 0)
            {
                MessageBox.Show("Deleted!");
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
