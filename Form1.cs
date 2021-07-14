using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 전화번호목록_Click(object sender, EventArgs e)
        {
            전화번호목록 button = new 전화번호목록();
        }

        private void 입국심사_Click(object sender, EventArgs e)
        {
            입국심사 button = new 입국심사();
        }
    }
}
