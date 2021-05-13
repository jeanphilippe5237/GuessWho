using System;
using TP3.Classes.Enums;
using TP3.Classes;
using System.IO;
using System.Text;

//Jean-Philippe Chiasson

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création des 2 plateaux de jeu 
            Plateau plateauRouge = new Plateau(CouleurPlateau.Rouge);
            plateauRouge.RemplirPlateau();
            Plateau plateauBleu = new Plateau(CouleurPlateau.Bleu);
            plateauBleu.RemplirPlateau();


            //Entrez le nom du joueur rouge, affichage du contenu de son plateau 
            //et affichage du personnage choisi au hasard. 
            Console.Write("Entrez le nom du joueur du plateau Rouge: ");
            string nom = Console.ReadLine();
            Joueur joueurRouge = new Joueur(nom);
            //Console.WriteLine(plateauRouge); 
            //int indicePersoRouge = plateauRouge.PigerPersonnage();
            //Console.WriteLine(plateauRouge.AfficherPersonnagePige(indicePersoRouge));


            //Le joueur doit appuyer sur une touche pour effacer l'écran 
            //et permettre au joueur bleu d'entrer ses infos. 
            Console.Write("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Console.Clear();


            //Entrez le nom du joueur bleu, affichage du contenu de son plateau 
            //et affichage du personnage choisi au hasard. 
            Console.Write("Entrez le nom du joueur du plateau Bleu: ");
            nom = Console.ReadLine();
            Joueur joueurBleu = new Joueur(nom);
            //Console.WriteLine(plateauBleu);
            //int indicePersoBleu = plateauBleu.PigerPersonnage();
            //Console.WriteLine(plateauBleu.AfficherPersonnagePige(indicePersoBleu));

            
            //Le joueur doit appuyer sur une touche pour effacer l'écran  
            Console.Write("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Console.Clear();

            
            Joueur joueurCourant = new Joueur();

            bool sortie = false;
            while (sortie == false)
            {
                Console.WriteLine("C'est le joueur rouge(r) ou le joueur bleu(b) qui joue?");
                string rougeOuBleu = Console.ReadLine();
                if (rougeOuBleu == "r")
                {
                    joueurCourant = joueurRouge;
                    sortie = true;
                }
                else if (rougeOuBleu == "b")
                {
                    joueurCourant = joueurBleu;
                    sortie = true;
                }
                else
                {
                    continue;
                }

            }

            Console.Clear();

            sortie = false;
            while (sortie == false)
            {
                Console.WriteLine(joueurCourant._nomJoueur + " ,choisissez un personnage avec son numéro, de 1 à 24");
                int numeroChoisi = int.Parse(Console.ReadLine());
                if (numeroChoisi <= 24 && numeroChoisi > 0)
                {
                    Console.WriteLine("Voici ton personnage choisi: ");
                    Console.WriteLine(plateauBleu.AfficherPersonnage(numeroChoisi));
                    sortie = true;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            if (joueurCourant == joueurBleu)
            {
                joueurCourant = joueurRouge;
            }
            else
            {
                joueurCourant = joueurBleu;
            }

            sortie = false;
            while (sortie == false)
            {
                Console.WriteLine(joueurCourant._nomJoueur + " ,choisissez un personnage avec son numéro, de 1 à 24");
                int numeroChoisi = int.Parse(Console.ReadLine());
                if (numeroChoisi <= 24 && numeroChoisi > 0)
                {
                    Console.WriteLine("Voici ton personnage choisi: ");
                    Console.WriteLine(plateauBleu.AfficherPersonnage(numeroChoisi));
                    sortie = true;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("");
            Console.Write("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Console.Clear();

            if (joueurCourant == joueurBleu)
            {
                joueurCourant = joueurRouge;
            }
            else
            {
                joueurCourant = joueurBleu;
            }

            Console.WriteLine("");
            Console.WriteLine(joueurCourant._nomJoueur + ", choissisez une question à poser: ");
            bool reponse = Questions.ReponseVraiFaux();
            Console.WriteLine(reponse);

            if (joueurCourant == joueurBleu)
            {
                joueurCourant = joueurRouge;
            }
            else
            {
                joueurCourant = joueurBleu;
            }
            Console.WriteLine("");
            Console.WriteLine(joueurCourant._nomJoueur + ", choissisez une question à poser: ");
            reponse = Questions.ReponseVraiFaux();
            Console.WriteLine(reponse);
        }
    }
}
