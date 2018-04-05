using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybridCarEstimator
{
    public partial class carEstimator : Form
    {

        public carEstimator()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            formNew fn = new formNew();
            fn.MdiParent = this;
            fn.Show();
        }

        private void carEstimator_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
        }

        private void enuItemLoad_Click(object sender, EventArgs e) //Load option
        {

            string[,] fileArray = new string[17, 7];
            int counter = 0;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader("E:\\hello.txt.txt");
            StringBuilder sb = new StringBuilder();

            string line = "";
           
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Length > 0)
                    {
                        sb.Append(line);
                        counter++;
                    }
                }


            file.Close();

            // Suspend the screen.
            Console.ReadLine();

            formNew previousData = new formNew();
        }
    }
}
