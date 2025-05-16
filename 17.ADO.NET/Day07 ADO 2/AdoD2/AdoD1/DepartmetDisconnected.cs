using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AdoD1
{
    public partial class DepartmetDisconnected : Form
    {
        SqlConnection con;
        public DepartmetDisconnected()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
        }
        DataTable dt;
        private void DepartmetDisconnected_Load(object sender, EventArgs e)
        {
            //disconnected 
            SqlCommand selectcmd = new SqlCommand("select id,name,loc from Department", con);
            SqlDataAdapter adpter = new SqlDataAdapter(selectcmd);
            // adpter.SelectCommand = selectcmd;
            dt = new DataTable();
            adpter.Fill(dt);


            DGV_dept.DataSource = dt;
            btn_update.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow r = dt.Rows[dt.Rows.Count - 1];
            int lastid = (int)r["id"];

            DataRow dr = dt.NewRow();
            dr["id"] = lastid + 1;
            dr["name"] = txt_name.Text;
            dr["loc"] = txt_location.Text;
            dt.Rows.Add(dr);

            DGV_dept.DataSource = dt;
            txt_location.Text = txt_name.Text = "";
            MessageBox.Show("added");
        }
        int id;
        private void DGV_dept_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = DGV_dept.SelectedRows[0];
            id = (int)row.Cells[0].Value;
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_location.Text = row.Cells[2].Value.ToString();
            //foreach(DataRow dr in dt.Rows)
            //{
            //    if ((int)dr["id"] == id)
            //    {
            //        txt_name.Text = dr["name"].ToString();
            //        txt_location.Text = dr["loc"].ToString();
            //    }
            //}

            btn_add.Visible = false;
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt.Rows)
            {
                // if ((int?)dr["id"]!=null)
                if ((int)dr["id"] == id)
                {
                    dr["name"] = txt_name.Text;
                    dr["loc"] = txt_location.Text;
                    //break;
                }

            }

            DGV_dept.DataSource = dt;
            txt_location.Text = txt_name.Text = "";
            btn_add.Visible = true;
            btn_update.Visible = false;
            MessageBox.Show("updated");
        }

        private void btn_savechanged_Click(object sender, EventArgs e)
        {
            //insertcommand,update

            SqlCommand insertcmd = new SqlCommand("insert into department values(@name ,@location)", con);
            insertcmd.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            insertcmd.Parameters.Add("@location", SqlDbType.NVarChar, 150, "loc");

            SqlCommand updateCmd = new SqlCommand("update department set name=@name ,loc=@location where id=@id", con);
            updateCmd.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            updateCmd.Parameters.Add("@location", SqlDbType.NVarChar, 150, "loc");
            updateCmd.Parameters.Add("@id", SqlDbType.Int, 4, "id");

            SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.InsertCommand = insertcmd;
            adpter.UpdateCommand = updateCmd;

            adpter.Update(dt);
        }

        private void DepartmetDisconnected_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlCommand insertcmd = new SqlCommand("insert into department values(@name ,@location)", con);
            insertcmd.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            insertcmd.Parameters.Add("@location", SqlDbType.NVarChar, 150, "loc");

            SqlCommand updateCmd = new SqlCommand("update department set name=@name ,loc=@location where id=@id", con);
            updateCmd.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            updateCmd.Parameters.Add("@location", SqlDbType.NVarChar, 150, "loc");
            updateCmd.Parameters.Add("@id", SqlDbType.Int, 4, "id");

            SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.InsertCommand = insertcmd;
            adpter.UpdateCommand = updateCmd;

            adpter.Update(dt);
        }
    }
}
