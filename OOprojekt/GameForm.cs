using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOprojekt
{
    public partial class GameForm : Form
    {
        //Laver en variable af typen Form1
        Form1 form1;

        //Laver en variable af typen Race
        Race race;

        //Laver en variable af typen Items
        Items items;

        //Laver en liste til at holde variabler af typen Items
        List<Items> itemList = new List<Items>();

        //Laver en variable af typen Events
        Events events;

        //Laver et objekt som kan lave et tilfældigt tal
        Random random = new Random();

        //Laver en variabel af typen fightSystem som kan indeholde en Form
        FightSystem fightSystem;

        //Laver en variabel til at holde typen Monster
        Monsters monsters;

        //Info om monsteret som formen fightSystem skal bruge
        public string monsterName;
        public string monsterDescription;
        public int monsterCP;
        public int monsterHealth;
        public int monsterLvl;

        //Info om Playeren som formen fightSystem skal bruge
        public int playerHealth;
        public int playerCP;

        
        public GameForm(Form1 refForm1)//Laver en reference til den første form
        {
            InitializeComponent();

            //Gemmer referencen til form1 i en variable
            form1 = refForm1;
        }

        

        //Når formen loader...
        private void GameForm_Load(object sender, EventArgs e)
        {
            //Gemmer form1 så brugeren ikke kan se den
            form1.Hide();

            //Kopirer race vriablen fra form1 over i race variablen i denne form
            //Så jeg ikke skal referer over i den første for hvis jeg skal bruge race variablen
            race = form1.race;

            //Kører metoden UpdateGUI
            UpdateGUI();

            //Laver et objekt af Events
            events = new Events();

            //Sætter informationen fra den sidste form til de labels på Gameformen
            lblName.Text = "Name: " + race.Username;
            lblRace.Text = "Race:   " + race.RaceChosen;
        }

        //Laver en metode der hedder UpdateGUI
        public void UpdateGUI()
        {
            //Sætter Health værdien fra race objektet til GUIens health
            lblHealthNumber.Text = race.HealthProp.ToString();

            //Sætter CP værdien fra race objektet til GUIens CP
            lblCPNumber.Text = race.CPProp.ToString();
        }

        //Laver en metode der skal køre når FightSytem formen lukker til at opdatere GameFormen
        public void UpdateAfterMonster()
        {
            //Gør playerens liv fra fightSystem formen til den samme som livet i race objektet
            race.HealthProp = playerHealth;

            //Kører metoden UpdateGUI
            UpdateGUI();

            //Hvis monsteret er dødt skal playeren have et item som monsteret dropper
            if (fightSystem.monsterIsDead)
            {
                //Prøv...
                try
                {
                    //Laver et nyt Objekt af typen Items
                    items = new Items();

                    //Ligger navnet på itemen man får af et monster over til item objektet 
                    //så det kan blive tilføjet til inventory listen og item listen
                    items.ItemNameProp = monsters.ItemDrop;

                    //Adder itemet til både listBoxen på gameformen og listen itemList
                    itemList.Add(items);
                    lstInventory.Items.Add(items.ItemNameProp);
                }
                //Hvis der skete en fejl fortæl det til brugeren med en MessageBox
                catch
                {
                    MessageBox.Show("Der gik noget galt med monster item droppet!");

                }
            }
            
        }

        //Når knappen Next turn er trykket på...
        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            //Bruger random objektet til at gemme et tilfældigt tal i variablen randomNumber
            int randomNumber = random.Next(1, 7);

            //Kører en metode kaldt eventChooser og giver den variablen randomNumber
            //Det er til at vælge eventet der kommer til at ske
            events.eventChooser(randomNumber);

            //Hvis eventet indeholder et monster...
            if (events.IsMonster == true)
            {
                //Laver et nyt objekt af typen monster
                monsters = new Monsters();

                //Hvis playerens Combat Power er under 15 så vælg en af de svage monstre fra monster classen
                if (race.CPProp <= 15)
                {
                    monsters.monsterChooserEasy();
                }
                //Ellers hvis playeren CP er over 15 så vælg en af de lidt svære monstre
                else if (race.CPProp > 15)
                {
                    monsters.monsterChooserMedium();
                }

                //Lægger informationen om monsteret fra monster classen over i variablerne i denne form 
                //så FightSystem formen kan bruge dem
                monsterName = monsters.MonsterName;
                monsterDescription = monsters.MonsterDescription;
                monsterCP = monsters.MonsterCP;
                monsterHealth = monsters.MonsterHealth;
                monsterLvl = monsters.MonsterLvl;

                //Den gør det samme med playeren
                playerHealth = race.HealthProp;
                playerCP = race.CPProp;

                //Laver Formen og viser den til brugeren
                fightSystem = new FightSystem(this, race);
                fightSystem.Show();


            }

            //Hvis ikke itemCollectet variablen er tom...
            if (events.ItemCollected != "")
            {
                //Laver et nyt Objekt af typen Items
                items = new Items();

                //Ligger navnet på itemen man får af et event over til item objektet 
                //så det kan blive tilføjet til inventory listen og item listen
                items.ItemNameProp = events.ItemCollected;

                //Adder itemet til både listBoxen på gameformen og listen itemList
                itemList.Add(items);
                lstInventory.Items.Add(items.ItemNameProp);
            }

            //Viser event beskrivelsen til brugeren
            MessageBox.Show(events.EventDescription);
        }

        //Når knappen Use item er trykket på...
        private void btnUseItem_Click(object sender, EventArgs e)
        {
            //Tjekker om listen er tom
            if (lstInventory.Items.Count == 0)
            {
                //Hvis listen er tom så vis en MessageBox til brugeren
                MessageBox.Show("You have no items");

                //Gå til labelen NoItems
                goto NoItems;
            }

            //Prøv...
            try
            {
                //For hver item i itemListen...
                foreach (Items item in itemList)
                {
                    //Hvis navnet på itemet er det samme som itemet i listBoxens navn...
                    if (item.ItemNameProp == lstInventory.SelectedItem.ToString())
                    {
                        //Sæt Værdierne fra race objektet til item objektets værdier
                        race.HealthProp += item.HealthEffectProp;
                        race.CPProp = item.CPEffectProp;

                        //Sletter det valgte/brugte item fra både itemListen og listBoxen
                        itemList.Remove(item);
                        lstInventory.Items.Remove(lstInventory.SelectedItem.ToString());

                        //Bryder foreach loopet
                        break;
                    }
                }
            }
            //Hvis ikke det virker...
            catch
            {
                //Vis en MessageBox til brugeren
                MessageBox.Show("Choose an item");
                
            }

            //Kører metoden UpdateGUI så Health og CP bliver opdateret
            UpdateGUI();

            //Labelen NoItems
            NoItems:;
        }

        
    }
}
