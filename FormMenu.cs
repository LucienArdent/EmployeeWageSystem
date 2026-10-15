using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanEmployeeWageSystem
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public List<RyanEmployee> listEmployees = new List<RyanEmployee>();
        public string dataNameEmployee = "Employee.dat";
      
        private void InputEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputEmployee form = new FormInputEmployee();
            form.Owner = this;
            form.ShowDialog();
        }

        private void DisplayEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayEmployee form = new FormDisplayEmployee();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public void SaveToFileRegEmployee(string dataName)
        //{
        //    FileStream fs = new FileStream(dataName, FileMode.Create, FileAccess.Write);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(fs, listEmployees);
        //    fs.Close();

        //}
        //public void LoadFromFileRegEmployee(string dataName)
        //{
        //    if (File.Exists(dataName))
        //    {
        //        FileStream fs = new FileStream(dataName, FileMode.Open, FileAccess.Read);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        listEmployees = (List<RyanRegularEmployee>)bf.Deserialize(fs);
        //        fs.Close();
        //    }

        //}

        public void SaveToFileEmployee(string dataName)
        {
            FileStream fs = new FileStream(dataName, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listEmployees);
            fs.Close();

        }

        public void LoadFromFileEmployee(string dataName)
        {
            if (File.Exists(dataName))
            {
                FileStream fs = new FileStream(dataName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                listEmployees = (List<RyanEmployee>)bf.Deserialize(fs);
                fs.Close();
            }

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
