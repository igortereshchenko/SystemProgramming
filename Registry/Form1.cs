using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Registry
{
    public partial class Form1 : Form
    {
        private bool saveState;
        public Form1()
        {
            saveState = true;

            InitializeComponent();
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            key = key.OpenSubKey(Application.ProductName);
            if (key == null)
                return;
            this.Width = Convert.ToInt16(key.GetValue("W"));
            this.Height = Convert.ToInt16(key.GetValue("H"));

            key.Close();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saveState)
                return;

            RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            key = key.CreateSubKey(Application.ProductName);
            key.SetValue("W", this.Width);
            key.SetValue("H", this.Height);
            key.Close();
        }

        private void btnClearRegistry_Click(object sender, EventArgs e)
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            key.DeleteSubKey(Application.ProductName);
            key.Close();
            saveState = false;
        }
    }
}
