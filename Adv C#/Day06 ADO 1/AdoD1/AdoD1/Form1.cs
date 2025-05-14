using Microsoft.Data.SqlClient;
namespace AdoD1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-JP4B1RU;Initial Catalog=EFD1;Integrated Security=True;Trust Server Certificate=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    //define connection
            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = "Data Source=DESKTOP-JP4B1RU;Initial Catalog=EFD1;Integrated Security=True;Trust Server Certificate=True";

            //    //define command
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "select * from student";
            //    cmd.CommandType = System.Data.CommandType.Text;
            //    cmd.Connection = con;

            //    con.Open();

            //SqlDataReader dr=    cmd.ExecuteReader();
            //    List<studentdata> sts = new List<studentdata>();
            //    while (dr.Read()) {
            //        studentdata st = new studentdata();
            //        st.id = (int)dr["ID"];
            //        st.name = dr["name"].ToString();
            //        st.age = (int)dr["age"];
            //        st.address = dr["adddress"].ToString();
            //        st.deptid = (int)dr["deptid"];
            //        sts.Add(st);
            //    }

            //    dgv_students.DataSource = sts;


            //    con.Close();


            //define connection
            //  SqlConnection con = new SqlConnection("Data Source=DESKTOP-JP4B1RU;Initial Catalog=EFD1;Integrated Security=True;Trust Server Certificate=True");


            //define command
            SqlCommand cmd = new SqlCommand("select * from student", con);

            SqlCommand cmddept = new SqlCommand("select id,name from department", con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            List<studentdata> sts = new List<studentdata>();
            while (dr.Read())
            {
                studentdata st = new studentdata();
                st.id = (int)dr["ID"];
                st.name = dr["name"].ToString();
                st.age = (int)dr["age"];
                st.address = dr["adddress"].ToString();
                st.deptid = (int)dr["deptid"];
                sts.Add(st);
            }

            dgv_students.DataSource = sts;

            cb_students.DataSource = sts;
            cb_students.ValueMember = "id";
            cb_students.DisplayMember = "name";

            dr.Close();


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
    }
}
