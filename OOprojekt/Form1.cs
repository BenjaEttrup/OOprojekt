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

        //Laver en variable af typen gameForm
        GameForm gameForm;

        //Når formen loader...
        private void Form1_Load(object sender, EventArgs e)
        {
            //Laver et objekt og gemmer det i gameForm variablen
            gameForm = new GameForm(this);

            //Laver et object af classen Race
            raceTemplate = new Race();

            //For hver string i arrayet racer i objektet raceTemplate
            foreach (String race in raceTemplate.racer)
            {
                //Tilføj et element til listboxen
                lstRace.Items.Add(race);
            }
        }

        //Når man trykker på knappen create...
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Hvis brugernavnet ikke indeholder intet...
            if (txtUsername.Text != "")
            {
                //Sender brugernavnet, brugeren har valgt, til Race classen
                raceTemplate.Username = txtUsername.Text;
                MessageBox.Show(raceTemplate.Username);
            }
            else//Ellers
            {
                //Vis en MessageBox der fortæller brugeren hvad der mangler
                MessageBox.Show("You need to type a username!");
            }

            //Prøv det her...
            try
            {
                //Sender racen, brugeren har valgt, til Race classen 
                raceTemplate.RaceNumberChosen = lstRace.SelectedIndex;
                MessageBox.Show(raceTemplate.RaceChosen);
            }
            //Hvis det ikke virker...
            catch 
            {
                //Vis en MessageBox der fortæller brugeren hvad der mangler
                MessageBox.Show("You need to pick a race!");
            }

            //Prøv det her...
            try
            {
                //Sender kønnet, brugeren har valgt til classen
                raceTemplate.GenderNumberChosen = lstGender.SelectedIndex;
                MessageBox.Show(raceTemplate.GenderChosen);
            }
            //Hvis ikke det virker...
            catch
            {
                //Vis en MessageBox der fortæller brugeren hvad der mangler
                MessageBox.Show("You need to pick a gender!");
            }

            //Hvis alle felterne på formen er blevet fyldt ud...
            if (raceTemplate.Username != null && raceTemplate.RaceChosen != null && raceTemplate.GenderChosen != null)
            {
                //Viser formen til brugeren
                gameForm.Show();
            }

        }

        
    }
}
