using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBallTracker
{
    public partial class MatchHistory : Form
    {
        private string  connectionString;
        public MatchHistory()
        {

            InitializeComponent();
            string provider = ConfigurationManager.AppSettings["scores"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];

           
            DataSet dataSet = DataAdapterUsage.Adapter(connectionString);
            //TextBox box = new TextBox();
            //box.Text = filler.ToString();
           
                DataGridView DGV = new DataGridView();
                DGV.DataSource = dataSet.Tables[0];
                Controls.Add(DGV);
                DGV.Show();
 
            //Controls.Add(box);
            //box.Show();
        }
    }
}
