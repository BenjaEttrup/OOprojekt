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
        GameForm gameForm;

        Race race;

        public bool monsterIsDead = false;

        public FightSystem(GameForm RefGameForm, Race RefRace)
        {
            InitializeComponent();

            gameForm = RefGameForm;

            race = RefRace;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            gameForm.UpdateAfterMonster();

            this.Close();
        }

        private void FightSystem_Load(object sender, EventArgs e)
        {
            lblMonsterName.Text = "Name: " + gameForm.monsterName;
            txbMonsterDescription.Text = gameForm.monsterDescription;
            lblMonsterCP.Text = "CP: " + gameForm.monsterCP;
            lblMonsterLvl.Text = "Lvl: " + gameForm.monsterLvl;
            lblMonsterHealth.Text = "MaxHeath: " + gameForm.monsterHealth;

            prbMonsterHealth.Maximum = gameForm.monsterHealth;
            prbMonsterHealth.Value = gameForm.monsterHealth;

            lblPlayerHealth.Text = "Health: " + gameForm.playerHealth;
            lblPlayerCP.Text = "CP: " + gameForm.playerCP;
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            int tempHealth = prbMonsterHealth.Value;

            tempHealth -= gameForm.playerCP;
            
            

            if(tempHealth <= 0)
            {
                prbMonsterHealth.Value = 0;

                MessageBox.Show("Monsteret er dødt!");

                monsterIsDead = true;

                gameForm.UpdateAfterMonster();

                this.Close();
            }
            else
            {
                prbMonsterHealth.Value = tempHealth;
            }

            gameForm.playerHealth -= gameForm.monsterCP;

            lblPlayerHealth.Text = "Health: " + gameForm.playerHealth;

            if(gameForm.playerHealth <= 0)
            {
                gameForm.UpdateAfterMonster();

                MessageBox.Show("You died!");
                
                Application.Exit();
            }
        }
    }
}
