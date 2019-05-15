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
        //Laver en variable af typen Form1
        Form1 form1;

        //Laver en variable af typen Race
        Race race;

        public GameForm(Form1 refForm1)//Laver en reference til den første form
        {
            InitializeComponent();

            //Gemmer referencen til form1 i en variable
            form1 = refForm1;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(race.Username);

        }

        //Når formen loader...
        private void GameForm_Load(object sender, EventArgs e)
        {
            //Gemmer form1 så brugeren ikke kan se den
            form1.Hide();

            //Kopirer race vriablen fra form1 over i race variablen i denne form
            //Så jeg ikke skal referer over i den første for hvis jeg skal bruge race variablen
            race = form1.race;
        }
    }
}
