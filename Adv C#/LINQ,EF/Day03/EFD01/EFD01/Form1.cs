using EFD01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Net;

namespace EFD01
{
    public partial class Form1 : Form
    {
        ItiContext myDB;
        public Form1()
        {
            InitializeComponent();
            myDB = new ItiContext();
        }
        int mxId = 0, id;
        List<Student> students;
        private void Form1_Load(object sender, EventArgs e)
        {

            mxId = myDB.Students.Max(s => s.ID);
            stdGV.DataSource = myDB.Students.Select(s => new { ID = s.ID, FirstName = s.FirstName, LastName = s.LastName, Age = s.Age, Address = s.Address, super = s.StSuperNavigation.FirstName , sID = s.StSuperNavigation.ID }).ToList();
            cb_depts.DataSource = myDB.Departments.ToList();
            cb_depts.DisplayMember = "DeptName";
            cb_depts.ValueMember = "DeptId";
            cb_super.DataSource = myDB.Students.Select(s => new { Name = s.FirstName, ID = s.ID }).ToList();
            cb_super.DisplayMember = "Name";
            cb_super.ValueMember = "ID";
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                ID = ++mxId,
                FirstName = txt_first_name.Text,
                LastName = txt_second_name.Text,
                Age = int.Parse(txt_Age.Text),
                Address = txt_address.Text,
                StSuper = (int)cb_super.SelectedValue,
                DeptId = (int)cb_depts.SelectedValue,
            };
            myDB.Students.Add(s);
            myDB.SaveChanges();
            txt_first_name.Text = txt_second_name.Text = txt_Age.Text = txt_address.Text = "";
            stdGV.DataSource = myDB.Students.Select(s => new { ID = s.ID, FirstName = s.FirstName, LastName = s.LastName, Age = s.Age, Address = s.Address, super = s.StSuper }).ToList();
            MessageBox.Show("Added");
        }


        private void stdGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)stdGV.SelectedRows[0].Cells[0].Value;
            Student s = myDB.Students.Where(s => s.ID == id).SingleOrDefault();

            txt_first_name.Text = s.FirstName;
            txt_second_name.Text = s.LastName;
            txt_Age.Text = s.Age.ToString();
            txt_address.Text = s.Address;
            cb_super.SelectedValue = s.StSuper;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = myDB.Students.Where(s => s.ID == id).SingleOrDefault();
            s.FirstName = txt_first_name.Text;
            s.LastName = txt_second_name.Text;
            s.Age = int.Parse(txt_Age.Text);
            s.Address = txt_address.Text;
            s.StSuper = (int)cb_super.SelectedValue;
            s.DeptId = (int)cb_depts.SelectedValue;
            myDB.SaveChanges();
            txt_first_name.Text = txt_second_name.Text = txt_Age.Text = txt_address.Text = "";
            stdGV.DataSource = myDB.Students.Select(s => new { ID = s.ID, FirstName = s.FirstName, LastName = s.LastName, Age = s.Age, Address = s.Address, super = s.StSuper }).ToList();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            MessageBox.Show("updated");


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Student s = myDB.Students.Where(s => s.ID == id).SingleOrDefault();
                myDB.Students.Remove(s);
                myDB.SaveChanges();

                txt_first_name.Text = txt_second_name.Text = txt_Age.Text = txt_address.Text = "";
                stdGV.DataSource = myDB.Students.Select(s => new { ID = s.ID, FirstName = s.FirstName, LastName = s.LastName, Age = s.Age, Address = s.Address, super = s.StSuper }).ToList();
                MessageBox.Show("Deleted");
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;

            }
        }
    }
}
/*
 
             
 
 */