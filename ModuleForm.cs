using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }

        private void btnModuleFormReturn_Click(object sender, EventArgs e)
        {
            Menu Menu_Form = new Menu();
            Menu_Form.Show();
            this.Hide();
        }
    }
}
