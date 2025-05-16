using EFD1.Models;

namespace EFD1
{
    public partial class Form1 : Form
    {
        ITIContext db;

        public Form1()
        {
            InitializeComponent();
            db = new ITIContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            //var q1 = db.Students.Where(n => n.age > 20);
            //var q2 = db.Students.Where(n => n.age > 20).AsEnumerable;
            //var q3 = db.Students.Where(n => n.age > 20).ToList();


            dgv_students.DataSource = db.Students.ToList();
            // dgv_students.DataSource = db.Students.Where(n => n.age > 20).Select(n => new {n.ID ,n.name,n.age,deptname=n.dept.name}).ToList();
            cb_dept.DataSource = db.Departments.ToList();
            cb_dept.ValueMember = "ID";
            cb_dept.DisplayMember = "name";


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                name = txt_name.Text,
                age = int.Parse(txt_age.Text),
                adddress = txt_address.Text,
                deptid = (int)cb_dept.SelectedValue
            };

            db.Students.Add(s);
            db.SaveChanges();

            txt_address.Text = txt_age.Text = txt_name.Text = "";
            dgv_students.DataSource = db.Students.ToList();
            MessageBox.Show("done");
        }
        int id;
        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_students.SelectedRows[0].Cells[0].Value;
            Student s = db.Students.Where(n => n.ID == id).SingleOrDefault();
            txt_name.Text = s.name;
            txt_age.Text = s.age.ToString();
            txt_address.Text = s.adddress.ToString();
            cb_dept.SelectedValue = s.deptid;


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(n => n.ID == id).SingleOrDefault();
            s.name = txt_name.Text;
            s.age = int.Parse(txt_age.Text);
            s.adddress = txt_address.Text;
            s.deptid = (int)cb_dept.SelectedValue;

            db.SaveChanges();
            txt_address.Text = txt_age.Text = txt_name.Text = "";
            dgv_students.DataSource = db.Students.ToList();
            MessageBox.Show("updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Student s = db.Students.Where(n => n.ID == id).SingleOrDefault();
                db.Students.Remove(s);

                db.SaveChanges();
                txt_address.Text = txt_age.Text = txt_name.Text = "";
                dgv_students.DataSource = db.Students.ToList();
                MessageBox.Show("deleted");
            }
        }
    }
}
