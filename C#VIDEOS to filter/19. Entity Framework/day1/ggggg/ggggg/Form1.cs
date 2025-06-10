using ggggg.Models;

namespace ggggg
{
    public partial class Form1 : Form
    {
        ItiContext db;
        int lastId;
        public Form1()
        {
            InitializeComponent();
            db = new ItiContext();
            lastId = db.Students.Max(s => s.StId);
        }

        public void LoadDGV()
        {
            var querySS = db.Students.Join(db.Departments,
              s => s.DeptId,
              d => d.DeptId,
              (s, d) => new
              {
                  id = s.StId,
                  name = s.StFname + " " + s.StLname,
                  age = s.StAge,
                  dept = d.DeptName,
                  super = s.StSuperNavigation.StFname + " " + s.StSuperNavigation.StLname,
              }).ToList();


            dgv_students.DataSource = querySS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var querySS = db.Students.Join(db.Departments,
              s => s.DeptId,
              d => d.DeptId,
              (s, d) => new
              {
                  id = s.StId,
                  name = s.StFname + " " + s.StLname,
                  age = s.StAge,
                  dept = d.DeptName,
                  super = s.StSuperNavigation.StFname+" "+s.StSuperNavigation.StLname,
              }).ToList();


            dgv_students.DataSource = querySS;

            cb_depts.DataSource = db.Departments.ToList();
            cb_depts.DisplayMember = "DeptName";
            cb_depts.ValueMember = "DeptId";

            cb_super.DataSource = db.Students.ToList();
            cb_super.DisplayMember = "StFname";// +" "+ "StLname";
            cb_super.ValueMember = "StId";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                StId = ++lastId,
                StFname = tb_name.Text,
                StLname = tb_lname.Text,
                StAge = int.Parse(tb_age.Text),
                DeptId = (int)cb_depts.SelectedValue
            };

            db.Add(student);

            db.SaveChanges();

            //dgv_students.DataSource = db.Students.Select(s => new
            //{
            //    id = s.StId,
            //    name = s.StFname + " " + s.StLname,
            //    age = s.StAge,
            //    deptId = s.DeptId

            //}).ToList();

            LoadDGV();

            tb_name.Text = tb_age.Text = "";
            MessageBox.Show("Added!");

        }

        int selectedId;
        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgv_students.SelectedRows[0];
            selectedId = (int)row.Cells[0].Value;

            Student selectedStudent = db.Students.Where(s => s.StId == selectedId).SingleOrDefault();

            tb_name.Text = selectedStudent.StFname;
            tb_lname.Text = selectedStudent.StLname;
            tb_age.Text = selectedStudent.StAge.ToString();
            cb_depts.SelectedValue = selectedStudent.DeptId??-1;
            //cb_super.SelectedValue = (int?)selectedStudent.StSuperNavigation?.StId??-1;
            cb_super.SelectedValue = selectedStudent.StSuper??-1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student selectedStudent = db.Students.Where(s => s.StId == selectedId).SingleOrDefault();

            selectedStudent.StLname = tb_name.Text;
            selectedStudent.StLname = tb_lname.Text;
            selectedStudent.StAge = int.Parse(tb_age.Text);
            selectedStudent.DeptId = (int?)cb_depts.SelectedValue;
            selectedStudent.StSuper = (int?)cb_super.SelectedValue;

            db.SaveChanges();

            //dgv_students.DataSource = db.Students.Select(s => new
            //{
            //    id = s.StId,
            //    name = s.StFname + " " + s.StLname,
            //    age = s.StAge,
            //    deptId = s.DeptId

            //}).ToList();
            LoadDGV();


            tb_name.Text = tb_age.Text = "";
            MessageBox.Show("Adde!");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Student selectedStudent = db.Students.Where(s => s.StId == selectedId).SingleOrDefault();

            db.Students.Remove(selectedStudent);

            db.SaveChanges();

            LoadDGV();

            tb_name.Text = tb_age.Text = "";
            MessageBox.Show("Deleted!");

        }
    }
}
