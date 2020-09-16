using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTesteRH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnviarData(object sender, MouseEventArgs e)
        {
            DateTime dt = dateInput.Value;
            textOut.Text = DiaUtil.GetQuintoDiaUtil(dt).ToString("dddd", new CultureInfo("pt-BR")) + " - 5º dia útil - Data: " + DiaUtil.GetQuintoDiaUtil(dt);
        }
    }
}
