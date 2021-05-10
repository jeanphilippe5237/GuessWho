using System;
using System.Collections.Generic;
using System.Text;
using TP3.Classes;
using TP3.Classes.Enums;
using System.IO;

namespace TP3.Classes
{
    class Plateau
    {
        private CouleurPlateau _couleurPlateau;
        public List<Personnages> ListeDePersonnages = new List<Personnages>(24);

        public Plateau() { }
        public Plateau(CouleurPlateau couPla)
        {
            SetCouleurPlateau(couPla);
        }

        //Setters
        void SetCouleurPlateau(CouleurPlateau couPla)
        {
            _couleurPlateau = couPla;
        }

        //Getters
        CouleurPlateau GetCouleurPlateau()
        {
            return _couleurPlateau;
        }

        //----------------------------------------------
        public void RemplirPlateau()
        {
            //changer les données pour classe personnage
            
            Personnages unPersonnage = new Personnages();

            string path = "C:/Users/jeanp_anr3ihn/Desktop/Prog ou whatever/GuessWho3/TP3/TP3/Personnages.txt";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] uneLigne = new string[3];
            string value;

            foreach (string line in lines)
            {
                uneLigne = line.Split(",");
                Personnages nouveauPersonnage = new Personnages();
                nouveauPersonnage.SetNumero(int.Parse(uneLigne[0]));
                nouveauPersonnage.SetPrenom(uneLigne[1]);
                value = uneLigne[2];
                CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), value);
                nouveauPersonnage.SetCouleurCheveux(coulChe);

                value = uneLigne[3];
                CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), value);
                nouveauPersonnage.SetCouleurYeux(coulY);

                value = uneLigne[4];
                Sexe s = (Sexe)Enum.Parse(typeof(Sexe), value);
                nouveauPersonnage.SetSexe(s);

                value = uneLigne[5];
                LongueurCheveux lon = (LongueurCheveux)Enum.Parse(typeof(LongueurCheveux), value);
                nouveauPersonnage.SetLongueurCheveux(lon);

                nouveauPersonnage.SetChapeau(bool.Parse(uneLigne[6]));
                nouveauPersonnage.SetMoustache(bool.Parse(uneLigne[7]));
                nouveauPersonnage.SetBarbe(bool.Parse(uneLigne[8]));
                nouveauPersonnage.SetLunettes(bool.Parse(uneLigne[9]));


                ListeDePersonnages.Add(nouveauPersonnage);
            }

        }
        public int PigerPersonnage()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 24);
            return rand;
        }
        public Personnages AfficherPersonnagePige(int numeroPerso)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Personnage pigé au hasard: ");
            Console.WriteLine(" ");
            foreach(Personnages p in ListeDePersonnages)
            {
                if(p._numero == numeroPerso)
                {
                    return p;
                }
                
            }
            return null;
        }

         
        public override string ToString()
        {
            Console.WriteLine("Couleur du plateau: " + _couleurPlateau + "\n" + "Personnages: ");
            foreach (Personnages nP in ListeDePersonnages)
            {
                Console.WriteLine(" Numero: " + nP.GetNumero() + ", Nom: " + nP.GetPrenom() + ", Couleur des cheveux: " + nP.GetCouleurCheveux() + ",\n Couleur des yeux: " + nP.GetCouleurYeux() + ", Sexe: " + nP.GetSexe() + ", Longueur des Cheveux: " + nP.GetLongueurCheveux() + ", \n Chapeau: " + nP.GetChapeau() + ", Moustache: " + nP.GetMoustache() + ", \n Barbe: " + nP.GetBarbe() + ", Lunettes: " + nP.GetLunettes() + "\n");
            }
            string txt = "";
            return txt;
        }
    }
}
