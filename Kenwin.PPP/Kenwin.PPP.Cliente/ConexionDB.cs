using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kenwin.PPP.Cliente
{
    public partial class ConexionDB : Form
    {
        public ConexionDB()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = radioButton1.Checked;
        }

        private void ConexionDB_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PPPObjectContext"].ConnectionString;
            var asdasd = "connection string=&quot;Data Source=VEMNSQL;Initial Catalog=Kenwin_PPP2;Integrated Security=True;MultipleActiveResultSets=True&quot";
            Regex.Match(connectionString, "Data Source=(.*);");
            Regex.Match(connectionString, "Initial Catalog=(.*);");
            Regex.Match(connectionString, "Data Source=(.*);");
        }
    }
}
