using ProLab2SavasOyunu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab2SavasOyunu
{
    public partial class LogForm : Form
    {
        public LogForm(List<SavasLog> loglar)
        {
            InitializeComponent();
            dataGridViewLogs.DataSource = loglar;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
           
        }
    }
}
