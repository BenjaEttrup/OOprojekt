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

        private string monsterName;

        private int monsterHealth;

        private string monsterDescription;

        private int monsterCP;

        private int monsterLvl;

        Random random = new Random();

        private int randomNumber;

        private string itemDrop;

        


        //=========================
        //  DEFAULT CONSTRUCTOR
        //=========================

        public Monsters()
        {
            randomNumber = random.Next(1, 3);
        }


        //=========================
        //      METHODS
        //=========================

        public void monsterChooserEasy()
        {
            switch (randomNumber)
            {
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

        public void monsterChooserMedium()
        {
            switch (randomNumber)
            {
                case 1:
                    monsterName = "Monkeyman Medium";
                    monsterHealth = 50;
                    monsterDescription = "Monkeyman is a wierd experiment gone very wrong.";
                    monsterCP = 15;
                    monsterLvl = 5;
                    itemDrop = "Monster organs Medium";

                    break;

                case 2:
                    monsterName = "Monkeyman2 Medium";
                    monsterHealth = 65;
                    monsterDescription = "Monkeyman is a wierd experiment gone wrong.";
                    monsterCP = 20;
                    monsterLvl = 6;
                    itemDrop = "Monster organs Medium";

                    break;
            }
        }


        //==============================
        //  READ AND WRITE PROPERTY
        //==============================

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
