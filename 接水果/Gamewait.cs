using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 接水果
{
    public partial class Gamewait : Form
    {
        public Gamewait()
        {
            InitializeComponent();
        }
        private void Import_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Gameload().Show();
        }

        private void Gamewait_Load(object sender, EventArgs e)
        {
            
        }
    }
}
