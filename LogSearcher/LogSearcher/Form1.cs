using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t.Columns.Add("Column1");
            t.Columns.Add("Column2");

        }
    }
}
