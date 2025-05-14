using AdoD1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoD1
{
    public partial class studentLayer : Form
    {
        public studentLayer()
        {
            InitializeComponent();
        }

        private void studentLayer_Load(object sender, EventArgs e)
        {
            //dgv_students.DataSource = DBLayer.select("select *  from student");
            dgv_students.DataSource = studentBussLayer.getall();
           // cb_dept.DataSource = DBLayer.select("select * from department");
            cb_dept.DataSource = departmentBussLayer.getall();
            cb_dept.ValueMember = "id";
            cb_dept.DisplayMember = "name";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // string query = $"insert into student values('{txt_name.Text}',{txt_age.Text},'{txt_address.Text}',{cb_dept.SelectedValue})";
            // int roweeffect = DBLayer.DML(query);
            int roweeffect = studentBussLayer.add(txt_name.Text, int.Parse(txt_age.Text), txt_address.Text, (int)cb_dept.SelectedValue);
            if(roweeffect > 0)
            {
              //  dgv_students.DataSource = DBLayer.select("select *  from student");
                dgv_students.DataSource = studentBussLayer.getall();
                txt_address.Text = txt_age.Text = txt_name.Text = "";

                MessageBox.Show("added");
            }
        }
    }
}
