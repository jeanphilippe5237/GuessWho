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
            /*
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
            Console.WriteLine(plateauRouge); 
            int indicePersoRouge = plateauRouge.PigerPersonnage();
            Console.WriteLine(plateauRouge.AfficherPersonnagePige(indicePersoRouge));


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
            Console.WriteLine(plateauBleu);
            int indicePersoBleu = plateauBleu.PigerPersonnage();
            Console.WriteLine(plateauBleu.AfficherPersonnagePige(indicePersoBleu));
            */

            //string reponse = Questions.DemanderQuestions();
            //Console.WriteLine("");
            //Console.WriteLine("Voici la question actuelle");
            //Console.WriteLine(Questions.questionCourante);
            //Console.WriteLine("Et le numéro: " + reponse[1]);

            bool reponse = Questions.ReponseVraiFaux();
            Console.WriteLine(reponse);
           

        }
    }
}
