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

namespace FrendlyPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var nameKana = this.txtNameKana.Text;

            var path = "user.csv";
            using (var writer = new StreamWriter(path,false,Encoding.UTF8))
            {
                writer.WriteLine($"{name},{nameKana}");
            }

        }
    }
}
