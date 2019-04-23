using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOprojekt
{
    public partial class GameForm : Form
    {
        Form1 form1;

        public GameForm(Form1 refForm1)//Laver en reference til den første form
        {
            InitializeComponent();
            form1 = refForm1;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form1.raceTemplate.Username);

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            form1.Hide();
        }
    }
}
