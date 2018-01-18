using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManager
{
    public partial class Form1 : Form
    {

        Process[] processes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void GetProcesses()
        {
            processes = Process.GetProcesses();
            if (Convert.ToInt32(lblProcess.Text)!=processes.Length)
            {
                lstBoxProcesses.Items.Clear();
                for (int i = 0; i < processes.Length; i++)
                {
                    lstBoxProcesses.Items.Add(processes[i].ProcessName);
                }
                lblProcess.Text = processes.Length.ToString();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            processes[lstBoxProcesses.SelectedIndex].Kill();
        }
    }
}
