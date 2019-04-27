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

        //Laver en variable af typen Race
        //Den er public fordi den bliver brugt i den anden form
        public Race race;

        //Laver en variable af typen gameForm
        GameForm gameForm;

        //Når formen loader...
        private void Form1_Load(object sender, EventArgs e)
        {
            //Laver et objekt og gemmer det i gameForm variablen
            gameForm = new GameForm(this);

            //Laver et object af classen Race og gemmer det i variablen race
            race = new Race();

            //For hver string i arrayet racer i objektet raceTemplate
            foreach (String race in race.racer)
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
                race.Username = txtUsername.Text;
                MessageBox.Show(race.Username);
            }
            else//Ellers
            {
                //Vis en MessageBox der fortæller brugeren hvad der mangler
                MessageBox.Show("You need to type a username!");
                //Spring til Fail labelen
                goto Fail;
            }

            //Prøv det her...
            try
            {
                //Sender racen, brugeren har valgt, til Race classen 
                race.RaceNumberChosen = lstRace.SelectedIndex;
                MessageBox.Show(race.RaceChosen);
            }
            //Hvis det ikke virker...
            catch 
            {
                //Vis en MessageBox der fortæller brugeren hvad der mangler
                MessageBox.Show("You need to pick a race!");
                //Spring til Fail labelen
                goto Fail;
            }

            //Prøv det her...
            try
            {
                //Sender kønnet, brugeren har valgt til classen
                race.GenderNumberChosen = lstGender.SelectedIndex;
                MessageBox.Show(race.GenderChosen);
            }
            //Hvis ikke det virker...
            catch
            {
                //Vis en MessageBox der fortæller brugeren hvad der mangler
                MessageBox.Show("You need to pick a gender!");
                //Spring til Fail labelen
                goto Fail;
            }

            //Hvis alle felterne på formen er blevet fyldt ud...
            if (race.Username != null && race.RaceChosen != null && race.GenderChosen != null)
            {
                //Viser formen til brugeren
                gameForm.Show();
            }

            //Fail labelen
            Fail:;


        }

        
    }
}
