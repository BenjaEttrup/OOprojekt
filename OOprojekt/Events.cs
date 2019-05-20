using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOprojekt
{
    class Events
    {
        //====================
        //  CLASS VARIABLES
        //====================
        
        //Laver en string der skal indeholde en beskrivelse om eventet
        private string eventDescription;

        //Laver en string der skal indeholde navnet på det item man får
        private string itemCollected;

        //Laver en Bool variabel til at tjekke om man møder et monster i eventet
        private bool isMonster;

        
        //=========================
        //      METHODS
        //=========================

        //Laver en metode til at vælge hvilket event der sker ud fra det tilfældige tal den får
        public void eventChooser(int randomNumber)
        {
            //En switch der matcher det tilfældige tal med et event
            switch (randomNumber)
            {
                //De forskellige events
                case 1:
                    eventDescription = "You found an Apple!";
                    itemCollected = "Apple";
                    isMonster = false;

                    break;

                case 2:
                    eventDescription = "You found a Sword!";
                    itemCollected = "Sword";
                    isMonster = false;

                    break;

                case 3:
                    eventDescription = "You found a monster";
                    itemCollected = "";
                    isMonster = true;

                    break;

                case 4:
                    eventDescription = "You found a monster";
                    itemCollected = "";
                    isMonster = true;

                    break;

                case 5:
                    eventDescription = "You found a monster";
                    itemCollected = "";
                    isMonster = true;

                    break;

                case 6:
                    eventDescription = "You found an Apple!";
                    itemCollected = "Apple";
                    isMonster = false;

                    break;
            }
        }


        //==============================
        //  READ AND WRITE PROPERTY
        //==============================

        //Gør så man kan læse variablerne fra en anden form
        public string EventDescription
        {
            get { return eventDescription; }
        }
        public string ItemCollected
        {
            get { return itemCollected; }
        }
        public bool IsMonster
        {
            set { isMonster = value; }
            get { return isMonster; }
        }

    }
}
