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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Gør at jeg fremover kan referere til classen Race med navnet raceTemplate
        public Race raceTemplate;

        GameForm gameForm;

        //Når man trykker på knappen create...
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Laver et object af classen Race
            raceTemplate = new Race();

            //Sender brugernavnet, brugeren har valgt, til Race classen
            raceTemplate.Username = txtUsername.Text;
            MessageBox.Show(raceTemplate.Username);

            //Sender racen, brugeren har valgt, til Race classen 
            raceTemplate.RaceNumberChosen = lstRace.SelectedIndex;
            MessageBox.Show(raceTemplate.RaceChosen);

            //Sender kønnet, brugeren har valgt til classen
            raceTemplate.GenderNumberChosen = lstGender.SelectedIndex;
            MessageBox.Show(raceTemplate.GenderChosen);

            gameForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameForm = new GameForm(this);
        }
    }
}
