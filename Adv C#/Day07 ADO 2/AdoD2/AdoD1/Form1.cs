using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace AdoD1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //define command
            SqlCommand cmd = new SqlCommand("select * from student", con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            //List<studentdata> sts = new List<studentdata>();
            //while (dr.Read())
            //{
            //    studentdata st = new studentdata();
            //    st.id = (int)dr["ID"];
            //    st.name = dr["name"].ToString();
            //    st.age = (int)dr["age"];
            //    st.address = dr["adddress"].ToString();
            //    st.deptid = (int)dr["deptid"];
            //    sts.Add(st);
            //}
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_students.DataSource = dt;

            cb_students.DataSource = dt;
            cb_students.ValueMember = "id";
            cb_students.DisplayMember = "name";

            dr.Close();

            SqlCommand cmddept = new SqlCommand("select id,name from department", con);

            SqlDataReader dr2 = cmddept.ExecuteReader();

            List<departmentdata> depts = new List<departmentdata>();
            while (dr2.Read())
            {
                departmentdata dept = new departmentdata();
                dept.id = (int)dr2["ID"];
                dept.name = dr2["name"].ToString();
                depts.Add(dept);
            }
            cb_dept.DataSource = depts;
            cb_dept.ValueMember = "ID";
            cb_dept.DisplayMember = "name";

            con.Close();

            btn_update.Visible = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into student values(@name,@age,@address,@deptid)", con);
            cmd.Parameters.AddWithValue("name", txt_name.Text);
            cmd.Parameters.AddWithValue("age", txt_age.Text);
            cmd.Parameters.AddWithValue("address", txt_address.Text);
            cmd.Parameters.AddWithValue("deptid", cb_dept.SelectedValue);


            con.Open();

            int roweffect = cmd.ExecuteNonQuery();
            con.Close();

            if (roweffect > 0)
            {
                txt_address.Text = txt_age.Text = txt_name.Text = "";

                Form1_Load(null, null);
                MessageBox.Show("added");
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from student where id =@id", con);
                cmd.Parameters.AddWithValue("@id", cb_students.SelectedValue);
                con.Open();

                int roweffect = cmd.ExecuteNonQuery();

                con.Close();
                if (roweffect > 0)
                {

                    Form1_Load(null, null);
                    MessageBox.Show("deleted");
                }
            }
        }
        int id;
        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewRow row= dgv_students.SelectedRows[0];
            // int id = (int)row.Cells[0].Value;

             id = (int)dgv_students.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("select * from student where id=@sid", con);
            cmd.Parameters.AddWithValue("sid", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txt_name.Text = dr[1].ToString();
            txt_age.Text = dr[2].ToString();
            txt_address.Text = dr[3].ToString();
            cb_dept.SelectedValue = dr[4];

            con.Close();
            btn_add.Visible = false;
            btn_update.Visible = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update student set name=@name ,age=@age ,adddress=@address ,deptid=@deptid where id=@id",con);
            cmd.Parameters.AddWithValue("name",txt_name.Text);
            cmd.Parameters.AddWithValue("age",txt_age.Text);
            cmd.Parameters.AddWithValue("address",txt_address.Text);
            cmd.Parameters.AddWithValue("deptid",cb_dept.SelectedValue);
            cmd.Parameters.AddWithValue("id",id);
            con.Open();
            int roweffect = cmd.ExecuteNonQuery();
            con.Close();
            if (roweffect > 0) {
                Form1_Load(null, null);
                txt_name.Text = txt_age.Text = txt_address.Text = "";
                btn_add.Visible = true;
                btn_update.Visible = false;
                MessageBox.Show("updated");

            }
        }
    }
}
