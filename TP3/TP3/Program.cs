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
            Plateau plateauCourant = new Plateau();
            Personnages personnageJoueurRouge = new Personnages();
            Personnages personnageJoueurBleu = new Personnages();
            Personnages personnageJoueurCourant = new Personnages();

            bool sortie = false;
            while (sortie == false)
            {
                Console.WriteLine("C'est le joueur rouge(r) ou le joueur bleu(b) qui joue?");
                string rougeOuBleu = Console.ReadLine();
                if (rougeOuBleu == "r")
                {
                    joueurCourant = joueurRouge;
                    plateauCourant = plateauRouge;
                    personnageJoueurCourant = personnageJoueurRouge;
                    sortie = true;
                }
                else if (rougeOuBleu == "b")
                {
                    joueurCourant = joueurBleu;
                    plateauCourant = plateauBleu;
                    personnageJoueurCourant = personnageJoueurBleu;
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
                    if (joueurCourant == joueurRouge)
                    {
                        personnageJoueurRouge = plateauRouge.ListeDePersonnages[numeroChoisi - 1];
                    }
                    else
                    {
                        personnageJoueurBleu = plateauBleu.ListeDePersonnages[numeroChoisi - 1];
                    }
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
                    if (joueurCourant == joueurRouge)
                    {
                        personnageJoueurRouge = plateauRouge.ListeDePersonnages[numeroChoisi - 1];
                    }
                    else
                    {
                        personnageJoueurBleu = plateauBleu.ListeDePersonnages[numeroChoisi - 1];
                    }
                    sortie = true;
                }
                else
                {
                    continue;
                }
            }
            
            Console.Write("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Le personnage du joueur rouge:");
            Console.WriteLine(personnageJoueurRouge);
            Console.WriteLine("");
            Console.WriteLine("Le personnage du joueur bleu:");
            Console.WriteLine(personnageJoueurBleu);
            Console.WriteLine("");
            Console.Write("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Console.Clear();

            //if (joueurCourant == joueurBleu)
            //{
            //    joueurCourant = joueurRouge;
            //    plateauCourant = plateauRouge;
            //}
            //else
            //{
            //    joueurCourant = joueurBleu;
            //    plateauCourant = plateauBleu;
            //}


            //Le jeu commence:

            sortie = false;

            while (sortie == false)
            {

                bool sortie2 = false;
                while (sortie2 == false)
                {
                    Console.WriteLine(joueurCourant._nomJoueur + ", voulez vous quitter la partie, ");
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        sortie = true;
                        goto AfterLoop;
                    }
                    else if (ouiOuNon == "n")
                    {
                        sortie2 = true;
                    }
                    else
                    {
                        continue;
                    }
                    
                }


                //Console.WriteLine("");
                //Console.WriteLine(joueurCourant._nomJoueur + ", choissisez une question à poser: ");

                //Console.WriteLine("");
                //personnageJoueurCourant = Questions.CreationPersonnageJoueur();
                //Console.WriteLine(personnageJoueurCourant);
                //Console.WriteLine("");

                //foreach (Personnages p in plateauCourant.ListeDePersonnages)
                //{
                //    if (personnageJoueurCourant._couleurCheveux != p._couleurCheveux)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //    else if (personnageJoueurCourant._couleurYeux != p._couleurYeux)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //    else if (personnageJoueurCourant._sexe != p._sexe)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //    else if (personnageJoueurCourant._longueurCheveux != p._longueurCheveux)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //    else if (personnageJoueurCourant._chapeau != p._chapeau)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //    else if (personnageJoueurCourant._moustache != p._moustache)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //    else if (personnageJoueurCourant._barbe != p._barbe)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //    else if (personnageJoueurCourant._lunettes != p._lunettes)
                //    {
                //        plateauCourant.ListeDePersonnages.Remove(p);
                //    }
                //}

                //Console.WriteLine(plateauBleu);
                //Console.WriteLine(plateauRouge);

                Console.WriteLine("");
                Console.WriteLine(joueurCourant._nomJoueur + ", choissisez une question à poser: ");

                Console.WriteLine("");
                personnageJoueurCourant = Questions.CreationPersonnageJoueur();
                Console.WriteLine(personnageJoueurCourant);
                Console.WriteLine("");

                Questions.EnleverPersonnagesListe(plateauCourant);

                Console.WriteLine(plateauCourant);

                if (joueurCourant == joueurBleu)
                {
                    joueurCourant = joueurRouge;
                    plateauCourant = plateauRouge;
                    personnageJoueurCourant = personnageJoueurRouge;
                }
                else
                {
                    joueurCourant = joueurBleu;
                    plateauCourant = plateauBleu;
                    personnageJoueurCourant = personnageJoueurBleu;
                }

                Console.WriteLine("C'est au tour de " + joueurCourant._nomJoueur);
            }
        //Fin du programme
        AfterLoop:

            Console.WriteLine("\nfin du programme");
        }
    }
}
