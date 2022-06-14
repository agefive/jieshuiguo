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
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Gamewait().Show();
        }

        private void Gameover_Load(object sender, EventArgs e)
        {
            label1.Text = "最终得分:"+Gameload.money;
        }
    }
}
