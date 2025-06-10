using EFD2.Models;
using Microsoft.EntityFrameworkCore;
namespace EFD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ITIContext db = new ITIContext();
          //  dgv_employee.DataSource = db.Employees.Include(n=>n.department).ToList();
            dgv_employee.DataSource = db.Employees.ToList();
        }
    }
}
