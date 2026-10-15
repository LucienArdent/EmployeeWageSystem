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
    public partial class FormInputEmployee : Form
    {
        public FormInputEmployee()
        {
            InitializeComponent();
        }
        FormMenu frmMenu;
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            RyanEmployee newEmployee;
            string id = textBoxId.Text;
            string name = textBoxName.Text;
            int basicSalary = int.Parse(textBoxBasicSalary.Text);
            

            if (radioButtonRegular.Checked)
            {
                int numOfChildren = (int)numericUpDownNumberOfChildren.Value;
                newEmployee = new RyanRegularEmployee(basicSalary, id, name, numOfChildren);
                frmMenu.listEmployees.Add(newEmployee);
                frmMenu.SaveToFileEmployee(frmMenu.dataNameEmployee);
                listBoxInfo.Items.AddRange(newEmployee.Display().Split('\n'));


            }
            if (radioButtonTemporary.Checked)
            {
                DateTime start = dateTimePickerStartDate.Value;
                DateTime end = dateTimePickerEndDate.Value;
                newEmployee= new RyanTemporaryEmployee(basicSalary, id, name, end, start);
                frmMenu.listEmployees.Add(newEmployee);
                frmMenu.SaveToFileEmployee(frmMenu.dataNameEmployee);
                listBoxInfo.Items.AddRange(newEmployee.Display().Split('\n'));
            }


        }

        private void FormInputEmployee_Load(object sender, EventArgs e)
        {
            frmMenu = (FormMenu)this.Owner;
            frmMenu.LoadFromFileEmployee(frmMenu.dataNameEmployee);
           

        }

        private void RadioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRegular.Enabled = true;
            groupBoxTemporary.Enabled = false;
            numericUpDownNumberOfChildren.Focus();
            listBoxInfo.Items.Clear();
            foreach(RyanEmployee regular in frmMenu.listEmployees)
            {
                listBoxInfo.Items.AddRange(regular.Display().Split('\n'));
            }
        }

        private void RadioButtonTemporary_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTemporary.Enabled = true;
            groupBoxRegular.Enabled = false;
            dateTimePickerEndDate.Focus();
            dateTimePickerStartDate.Focus();
            listBoxInfo.Items.Clear();
            foreach(RyanEmployee temporary in frmMenu.listEmployees)
            {
                listBoxInfo.Items.AddRange(temporary.Display().Split('\n'));
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
