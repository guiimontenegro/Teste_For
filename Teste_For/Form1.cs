using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_For
{
    public partial class btnTeste : Form
    {
        public btnTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0;  i < 50;  i++)
            {
                MessageBox.Show("O valor do contador é: ", + i);
            }
        }
    }
}
