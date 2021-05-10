using System;
using System.Collections.Generic;
using System.Text;

namespace TP3.Classes
{
    class Joueur
    {
        private string _nomJoueur = "";
        private int _nbVictoires = 0;

        public Joueur() { }

        public Joueur(string nom)
        {
            SetNomJoueur(nom);
        }
        public Joueur(string nom, int nbV)
        {
            SetNomJoueur(nom);
            SetNbDeVictoires(nbV);
        }

        //Setters
        void SetNomJoueur(string nom)
        {
            _nomJoueur = nom;
        }
        void SetNbDeVictoires(int nbV)
        {
            _nbVictoires = nbV;
        }
        //Getters
        string GetNomJoueur()
        {
            return _nomJoueur;
        }
        int GetNbDeVictoires()
        {
            return _nbVictoires;
        }

        //----------------------------------
        public void ResetNbVictoire()
        {
            _nbVictoires = 0;
        }
        public void CompteurVictoire()
        {
            Console.WriteLine("Le joueur " + _nomJoueur + " a " + _nbVictoires + " victoires.");
        }

        public override string ToString()
        {
            string txt = "Nom du joueur: " + _nomJoueur + "Nombre de victoires: " + _nbVictoires;
            return txt;
        }

    }
}
