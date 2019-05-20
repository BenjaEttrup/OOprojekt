using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOprojekt
{
    class Monsters
    {
        //====================
        //  CLASS VARIABLES
        //====================

        //Variabler til at holde informationen om det valgte monster
        private string monsterName;
        private int monsterHealth;
        private string monsterDescription;
        private int monsterCP;
        private int monsterLvl;

        //Laver et objekt der kan lave tilfældige tal
        Random random = new Random();

        //Laver en variabel til at holde det tilfældige nummer
        private int randomNumber;

        //Laver en variabel der indeholder navnet på det item monsteret dropper når det er dødt
        private string itemDrop;

        


        //=========================
        //  DEFAULT CONSTRUCTOR
        //=========================

        //Det kode der bliver kørt når der bliver lavet et objekt af classen
        public Monsters()
        {
            //Vælger et tilfældigt til mellem 1 og 2 og gemmer det i variablen randomNumber
            randomNumber = random.Next(1, 3);
        }


        //=========================
        //      METHODS
        //=========================

        //En metode til at vælge et nemt monster
        public void monsterChooserEasy()
        {
            //En switch der vælger et monster ud fra det tilfældige tal
            switch (randomNumber)
            {
                //Dette er de forskellige lette monstre
                case 1:
                    monsterName = "Monkeyman";
                    monsterHealth = 10;
                    monsterDescription = "Monkeyman is a wierd experiment gone wrong.";
                    monsterCP = 5;
                    monsterLvl = 1;
                    itemDrop = "Monster organs";

                    break;

                case 2:
                    monsterName = "Monkeyman2";
                    monsterHealth = 20;
                    monsterDescription = "Monkeyman is a wierd experiment gone wrong.";
                    monsterCP = 10;
                    monsterLvl = 2;
                    itemDrop = "Monster organs";

                    break;

                
            }
        }

        //En metode til at vælge de svære monstre
        public void monsterChooserMedium()
        {
            //En switch der vælger et monster ud fra det tilfældige tal
            switch (randomNumber)
            {
                //Dette er de forskellige svære monstre
                case 1:
                    monsterName = "Monkeyman M";
                    monsterHealth = 65;
                    monsterDescription = "Monkeyman is a wierd experiment gone very wrong.";
                    monsterCP = 10;
                    monsterLvl = 5;
                    itemDrop = "Monster organs M";

                    break;

                case 2:
                    monsterName = "Monkeyman2 M";
                    monsterHealth = 50;
                    monsterDescription = "Monkeyman is a wierd experiment gone wrong.";
                    monsterCP = 15;
                    monsterLvl = 6;
                    itemDrop = "Monster organs M";

                    break;
            }
        }


        //==============================
        //  READ AND WRITE PROPERTY
        //==============================

        //Dette er propeties til at andre classes kan læse værdierne
        public string MonsterName
        {
            get { return monsterName; }
        }
        public int MonsterHealth
        {
            get { return monsterHealth; }
        }
        public string MonsterDescription
        {
            get { return monsterDescription; }
        }
        public int MonsterCP
        {
            get { return monsterCP; }
        }
        public int MonsterLvl
        {
            get { return monsterLvl; }
        }
        public string ItemDrop
        {
            get { return itemDrop; }
        }

    }
}
