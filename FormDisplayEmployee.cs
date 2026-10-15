using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanEmployeeWageSystem
{
    public partial class FormDisplayEmployee : Form
    {
        public FormDisplayEmployee()
        {
            InitializeComponent();
        }
        FormMenu frmMenu;
        private void RadioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (RyanEmployee employee in frmMenu.listEmployees)
            {
                if(employee is RyanRegularEmployee)
                {
                    listBoxInfo.Items.AddRange(employee.Display().Split('\n'));

                }
                if (employee is RyanTemporaryEmployee)
                {
                    listBoxInfo.Items.AddRange(employee.Display().Split('\n'));

                }
            }
            
        }

        private void FormDisplayEmployee_Load(object sender, EventArgs e)
        {
            frmMenu = (FormMenu)this.Owner;
            frmMenu.LoadFromFileEmployee(frmMenu.dataNameEmployee);
            



        }

        private void RadioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (RyanEmployee regular in frmMenu.listEmployees)
            {
                if(regular is RyanRegularEmployee)
                {
                    listBoxInfo.Items.AddRange(regular.Display().Split('\n'));

                }
            }
        }

        private void RadioButtonTemporary_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (RyanEmployee temporary in frmMenu.listEmployees)
            {
                if(temporary is RyanTemporaryEmployee)
                {
                    listBoxInfo.Items.AddRange(temporary.Display().Split('\n'));

                }
            }
        }
    }
}
