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

        //
        private string eventName;

        //Laver en string der skal indeholde en beskrivelse om eventet
        private string eventDescription;

        //Laver en string der skal indeholde navnet på det item man får
        private string itemCollected;

        
        //=========================
        //      METHODS
        //=========================

        //Laver en metode til at vælge hvilket event der sker ud fra det tilfældige tal den får
        public void eventChooser(int randomNumber)
        {
            //En switch der matcher det tilfældige tal med et event
            switch (randomNumber)
            {
                case 1:
                    eventDescription = "You found an Apple!";
                    itemCollected = "Apple";

                    break;

                case 2:
                    eventDescription = "You found a Sword!";
                    itemCollected = "Sword";

                    break;
            }
        }


        //==============================
        //  READ AND WRITE PROPERTY
        //==============================

        //Gør så man kan læse variablerne fra en anden form
        public string EventName
        {
            get { return eventName; }
        }
        public string EventDescription
        {
            get { return eventDescription; }
        }
        public string ItemCollected
        {
            get { return itemCollected; }
        }

    }
}
