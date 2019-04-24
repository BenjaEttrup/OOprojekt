using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOprojekt
{
    public class Race
    {

        //====================
        //  CLASS VARIABLES
        //====================
        
        //Array til at opbevare de racer brugeren kan vælge mellem
        public string[] racer;
        //Indeholder den valgte race
        private string currentRace;

        //Array til at opbevare de køn brugeren kan vælge mellem
        private string[] gender;
        //Indeholder det valgte køn
        private string currentGender;

        //Indeholder det brugernavn brugeren har skrevet
        private string username;

        //=========================
        //  DEFAULT CONSTRUCTOR
        //=========================

        //Bliver kørt når der bliver lavet et objekt af denne class
        public Race()
        {
            //Sætter værdierne på de forskellige racer brugeren kan vælge
            racer = new string[3];
            racer[0] = "Ork";
            racer[1] = "Elf";
            racer[2] = "Human";

            //Sætter værdierne på de forskellige køn brugeren kan vælge
            gender = new string[2];
            gender[0] = "Female";
            gender[1] = "Male";

        }

        //=========================
        //      METHODS
        //=========================

        //Sætter currentRace variablen til den valgte race ud fra det nummer den får i input
        private void raceChoser(int RaceNumber)
        {
            currentRace = racer[RaceNumber];
        }

        //Sætter currentGender variablen til det valgte køn ud fra det nummer den får i input
        private void genderChoser(int GenderNumber)
        {
            currentGender = gender[GenderNumber];
        }

        //==============================
        //  READ AND WRITE PROPERTY
        //==============================

        //Giver raceChoser et int input fra en anden classe som f.eks. form1
        //Den for et nummer alt efter hvad race brugeren har valgt
        public int RaceNumberChosen
        {
            set { raceChoser(value); }
        }
        //Gør currentRace tilgængelig for andre classes som f.eks. form1
        public string RaceChosen
        {
            get { return currentRace; }
        }

        //Giver genderChoser et int input fra en anden classe som f.eks. form1
        //Den for et nummer alt efter hvad køn brugeren har valgt
        public int GenderNumberChosen
        {
            set { genderChoser(value); }
        }
        //Gør currentGender tilgængelig for andre classes som f.eks. form1
        public string GenderChosen
        {
            get { return currentGender; }
        }

        //Sætter username variablen i denne class lige med værdien denne propety får
        //Den gør også username variablen tilgængelig til andre classes som f.eks form1
        public string Username
        {
            set { username = value; }
            get { return username; }
        }

    }
}
