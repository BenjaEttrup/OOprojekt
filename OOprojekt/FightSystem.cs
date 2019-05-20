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
    public partial class FightSystem : Form
    {
        //Laver en variabel til at holde objekter af typen GameForm
        GameForm gameForm;

        //Laver en variabel til at holde objekter af typen race
        Race race;

        //Laver en variabel til at sige om monsteret er dødt og den bliver sat til false 
        //til at starte med fordi monsteret ikke er dødt med det samme
        public bool monsterIsDead = false;

        //Laver refferencer til både den tidligere GameForm og det tidligere race objekt
        public FightSystem(GameForm RefGameForm, Race RefRace)
        {
            InitializeComponent();

            //Gemmer referencerne i en variabel i denne form
            gameForm = RefGameForm;
            race = RefRace;
        }

        //Når man klikker på knappen Run...
        private void btnRun_Click(object sender, EventArgs e)
        {
            //Den kører metoden UpdateAfterMonster for at opdatere playeren liv og andre ting
            gameForm.UpdateAfterMonster();

            //Denne form bliver lukket
            this.Close();
        }

        //Når Formen loader...
        private void FightSystem_Load(object sender, EventArgs e)
        {
            //Updaterer alle visuelle ting med de rigtige værdier
            lblMonsterName.Text = "Name: " + gameForm.monsterName;
            txbMonsterDescription.Text = gameForm.monsterDescription;
            lblMonsterCP.Text = "CP: " + gameForm.monsterCP;
            lblMonsterLvl.Text = "Lvl: " + gameForm.monsterLvl;
            lblMonsterHealth.Text = "MaxHeath: " + gameForm.monsterHealth;

            //Sætter det liv monsteret starter med til maxværdien på progressbaren og valuen til det samme
            prbMonsterHealth.Maximum = gameForm.monsterHealth;
            prbMonsterHealth.Value = gameForm.monsterHealth;

            lblPlayerHealth.Text = "Health: " + gameForm.playerHealth;
            lblPlayerCP.Text = "CP: " + gameForm.playerCP;
        }

        //Når knappen Fight bliver trykket på
        private void btnFight_Click(object sender, EventArgs e)
        {
            //Laver en variabel til at holde den midlertidige mængde liv monsteret har
            //Så programmet ikke chrasher grundet at progressbarens value bliver under nul
            int tempHealth = prbMonsterHealth.Value;

            //Minusser playerens Combat Power med monsterets liv
            tempHealth -= gameForm.playerCP;
            
            
            //Hvis monsterets liv er under nul
            if(tempHealth <= 0)
            {
                //Sæt progressbarens value til nul
                prbMonsterHealth.Value = 0;

                //Vis en MessageBox der fortæller at et monster er dødt
                MessageBox.Show("You killed the Monster!");

                //Variablen der fortæller om monsteret er dødt sættes til true
                monsterIsDead = true;

                //Laver refferencer til både den tidligere GameForm og det tidligere race objekt
                gameForm.UpdateAfterMonster();

                //Lukker denne Form
                this.Close();
            }
            //Hvis ikke monsterets liv er under nul
            else
            {
                //Så sæt progressbarens value til monsterens liv
                prbMonsterHealth.Value = tempHealth;
            }

            //Minusser playerens liv med monsterets CP
            gameForm.playerHealth -= gameForm.monsterCP;

            //Opdaterer playerens liv
            lblPlayerHealth.Text = "Health: " + gameForm.playerHealth;

            //Hvis playerens liv er lig med eller under nul
            if(gameForm.playerHealth <= 0)
            {
                //Updater Gameformen så der står nul i liv
                gameForm.UpdateAfterMonster();

                //Hvis en MessageBox der fortæller brugeren at De er død
                MessageBox.Show("You died!");
                
                //Lukker programmet
                Application.Exit();
            }
        }
    }
}
