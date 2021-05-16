﻿using System;
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
            
            while (joueurBleu._nbVictoires < 3 && joueurRouge._nbVictoires < 3)
            {
                //Création des 2 plateaux de jeu 
                Plateau plateauRouge = new Plateau(CouleurPlateau.Rouge);
                plateauRouge.RemplirPlateau();
                Plateau plateauBleu = new Plateau(CouleurPlateau.Bleu);
                plateauBleu.RemplirPlateau();

                Plateau plateauGabarit = new Plateau();
                plateauGabarit.RemplirPlateau();

                Joueur joueurCourant = new Joueur();
                Plateau plateauCourant = new Plateau();
                Personnages personnageJoueurRouge = new Personnages();
                Personnages personnageJoueurBleu = new Personnages();
                Personnages personnageJoueurCourant = new Personnages();
                Personnages jR = new Personnages();
                Personnages jB = new Personnages();
                int nbDeQuestionsRouges = 0;
                int nbDeQuestionsBleues = 0;
                int nbDeQuestionsCourantes = 0;

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


                if (joueurCourant == joueurBleu)
                {
                    joueurCourant = joueurRouge;
                    plateauCourant = plateauRouge;
                    personnageJoueurCourant = jR;
                }
                else
                {
                    joueurCourant = joueurBleu;
                    plateauCourant = plateauBleu;
                    personnageJoueurCourant = jB;
                }


                sortie = false;

                while (sortie == false)
                {

                    bool sortie2 = false;
                    while (sortie2 == false)
                    {
                        bool sortie3 = false;
                        while (sortie3 == false)
                        {
                            Console.WriteLine("Voulez vous afficher la liste des 24 personnages? ");
                            Console.WriteLine("Oui (o) ou (n)?");
                            string reponse = Console.ReadLine();
                            if (reponse == "o")
                            {
                                Console.WriteLine(plateauGabarit);
                                sortie3 = true;
                            }
                            else if (reponse == "n")
                            {
                                sortie3 = true;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine(joueurCourant._nomJoueur + ", voulez vous quitter la partie, ");
                        Console.WriteLine("Oui (o) ou (n)?");
                        string ouiOuNon = Console.ReadLine();
                        if (ouiOuNon == "o")
                        {
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
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Voici les personnages restants: ");
                    Console.WriteLine(plateauCourant);
                    Console.WriteLine("");
                    Console.WriteLine(joueurCourant._nomJoueur + ", choissisez une question à poser: ");
                    Console.WriteLine("");
                    personnageJoueurCourant = Questions.CreationPersonnageJoueur();
                    Console.WriteLine("");

                    if (joueurCourant == joueurBleu)
                    {
                        joueurCourant = joueurRouge;
                        plateauCourant = plateauRouge;
                        personnageJoueurCourant = jR;
                        nbDeQuestionsBleues += 1;
                        nbDeQuestionsCourantes = nbDeQuestionsRouges;
                    }
                    else
                    {
                        joueurCourant = joueurBleu;
                        plateauCourant = plateauBleu;
                        personnageJoueurCourant = jB;
                        nbDeQuestionsRouges += 1;
                        nbDeQuestionsCourantes = nbDeQuestionsBleues;
                    }

                    Questions.EnleverPersonnagesListe(plateauCourant);

                    Console.WriteLine("Voici les personnages restants: ");
                    Console.WriteLine(plateauCourant);

                    int nbDePersonnagesRestants = 0;

                    foreach (Personnages p in plateauCourant.ListeDePersonnages)
                    {
                        nbDePersonnagesRestants += 1;
                    }
                    if (nbDePersonnagesRestants == 1)
                    {
                        if (joueurCourant == joueurBleu)
                        {
                            joueurCourant = joueurRouge;
                            plateauCourant = plateauRouge;
                            personnageJoueurCourant = personnageJoueurRouge;
                            nbDeQuestionsBleues += 1;
                            nbDeQuestionsCourantes = nbDeQuestionsRouges;
                        }
                        else
                        {
                            joueurCourant = joueurBleu;
                            plateauCourant = plateauBleu;
                            personnageJoueurCourant = personnageJoueurBleu;
                            nbDeQuestionsRouges += 1;
                            nbDeQuestionsCourantes = nbDeQuestionsBleues;
                        }
                        
                        if (joueurCourant == joueurBleu)
                        {
                            if (plateauRouge.ListeDePersonnages[0] == personnageJoueurRouge)
                            {
                                Console.WriteLine("Le joueur " + joueurCourant._nomJoueur + " a gagné avec " + nbDeQuestionsCourantes + " questions! ");
                                joueurCourant._nbVictoires += 1;
                                joueurCourant.CompteurVictoire();
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (joueurCourant == joueurRouge)
                        {
                            if (plateauBleu.ListeDePersonnages[0] == personnageJoueurBleu)
                            {
                                Console.WriteLine("Le joueur " + joueurCourant._nomJoueur + " a gagné avec " + nbDeQuestionsCourantes + " questions! ");
                                joueurCourant._nbVictoires += 1;
                                joueurCourant.CompteurVictoire();
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("C'est au tour de " + joueurCourant._nomJoueur);
                        continue;

                    }

                }
            }
            goto AfterLoop;

        //Fin du programme
        AfterLoop:

            Console.WriteLine("\nfin du programme");
        }
    }
}
