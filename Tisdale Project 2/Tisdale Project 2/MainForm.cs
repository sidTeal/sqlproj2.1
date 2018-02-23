using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tisdale_Project_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string[] employeeArray = DatabaseManager.getEmployeeNames();
            cbViewEmployee.DataSource = employeeArray;

            string[] customerArray = DatabaseManager.getCustomerNames();
            cbViewCustomer.DataSource = customerArray;

            tbViewCustomer.Text = DatabaseManager.viewCustomer("Stokes", "Reece");
        }
        
        private void lbEmployeeDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlModifyCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnAddCustomer_Click(object sender, EventArgs e)
        {
            
            string[] employeeArray = DatabaseManager.getEmployeeNames();
            string out0 = employeeArray[0];
            string out1 = employeeArray[1];

            tbCustomerFirstName.Text = out0;
            tbCustomerLastName.Text = out1;
        }

        private void cbViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
