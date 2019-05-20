using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOprojekt
{
    class Items
    {

        //====================
        //  CLASS VARIABLES
        //====================

        //Laver en variabel der indeholder itemets navn
        private string itemName;

        //Værdien i denne variabel styrer hvor meget der skal lægges til eller trækkes fra spillerens liv
        private int healthEffect;

        //Værdien i denne variabel styrer hvor meget der skal lægges til eller trækkes fra spillerens CP
        private int CPEffect;


        //=========================
        //  DEFAULT CONSTRUCTOR
        //=========================

        //Constructoren er den kode der bliver kørt når et objekt bliver lavet af classen
        public Items()
        {
            //Sætter variablen til 0 så hvis ikke den bliver ændret så sker der ikke noget
            healthEffect = 0;
            CPEffect = 0;
        }
        
        
        //=========================
        //      METHODS
        //=========================

        //Laver en metode som tager imod en string parameter
        private void ItemChoosen(string itemName)
        {
            //Laver en switch som skal mache navnet på Itemet så programmet ved hvad den skal gemme i hvilke variabler
            switch (itemName)
            {
                //Dette er de forskellige Items
                case "Apple":
                    healthEffect = 20;

                    break;

                case "Sword":
                    CPEffect = 3;

                    break;

                case "Monster organs":
                    healthEffect = 5;

                    break;

                case "Monster organs M":
                    healthEffect = 10;

                    break;
                    
                
            }
        }


        //==============================
        //  READ AND WRITE PROPERTY
        //==============================

        //Propertyen giver ItemChoosen metoden en værdi
        public string ItemNameProp
        {
            set { ItemChoosen(value); itemName = value; }
            get { return itemName; }
        }

        //Propertyen gør så GameFormen kan få information om hvor meget Health og CP skal ændres
        public int HealthEffectProp
        {
            get { return healthEffect; }
        }
        public int CPEffectProp
        {
            get { return CPEffect; }
        }
    }
}
