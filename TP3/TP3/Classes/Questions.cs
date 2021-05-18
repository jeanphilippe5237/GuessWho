using System;
using System.Collections.Generic;
using System.Text;
using TP3.Classes;
using TP3.Classes.Enums;

namespace TP3.Classes
{
    class Questions
    {
        //les questions posées à l'utilisateur
        public static string questionA = "a) A-t'il les cheveux: \n  \n     1) Noir \n     2)Brun \n     3)Blond \n     4)Roux \n     5)Châtain \n     6)Blanc \n";
        public static string questionB = "b) Es-t'il un homme? ";
        public static string questionC = "c) A-t'il les yeux: \n  \n     1) Bruns \n     2)Bleus \n     3)Verts \n     4)Gris \n";
        public static string questionD = "d) A-t'il les cheveux: \n  \n     1) Longs \n     2)Courts \n     3)Chauve (Il n'en a pas) \n";
        public static string questionE = "e) A-t'il un chapeau? ";
        public static string questionF = "f) A-t'il une moustache? ";
        public static string questionG = "g) A-t'il une barbe? ";
        public static string questionH = "h) A-t'il des lunettes? ";

        //Variables pour m'aider à comprendre/ au cas ou (??)
        public static bool vrai = true;
        public static bool faux = false;
        
        //Pour connaitre la question qui est actuellement posée au joueur
        public static string questionCourante;
        
        //Variable qui est utilisée pour connaitre la réponse du joueur à une question vraie ou faux.
        public static bool VraiOuFaux;

        //Cette fonction est utilisée pour enlever des personnages dans la liste du plateau du joueur, qui est passée en paramètre.
        public static void EnleverPersonnagesListe(Plateau pl)
        {
            Personnages noP = new Personnages();
            List<Personnages> liste = new List<Personnages>(24);
            
            if (questionCourante == "A-t'il les cheveux noirs?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Noir");
                    noP.SetCouleurCheveux(coulChe);
                }

                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurCheveux == noP._couleurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les cheveux bruns?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Brun");
                    noP.SetCouleurCheveux(coulChe);
                }

                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurCheveux == noP._couleurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les cheveux blonds?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Blond");
                    noP.SetCouleurCheveux(coulChe);
                }
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurCheveux == noP._couleurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les cheveux roux?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Roux");
                    noP.SetCouleurCheveux(coulChe);
                }

                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurCheveux == noP._couleurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les cheveux châtains?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Châtain");
                    noP.SetCouleurCheveux(coulChe);
                }
                 
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurCheveux == noP._couleurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les cheveux blancs?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Blanc");
                    noP.SetCouleurCheveux(coulChe);
                }

                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurCheveux == noP._couleurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les yeux bruns?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Bruns");
                    noP.SetCouleurYeux(coulY);
                }

                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurYeux == noP._couleurYeux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les yeux bleus?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Bleus");
                    noP.SetCouleurYeux(coulY);
                }
                    
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurYeux == noP._couleurYeux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les yeux verts?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Verts");
                    noP.SetCouleurYeux(coulY);
                }

                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurYeux == noP._couleurYeux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les yeux gris?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Gris");
                    noP.SetCouleurYeux(coulY);
                }
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._couleurYeux == noP._couleurYeux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les cheveux longs?")
            {
                if (VraiOuFaux == true)
                {
                    LongueurCheveux lon = (LongueurCheveux)Enum.Parse(typeof(LongueurCheveux), "Long");
                    noP.SetLongueurCheveux(lon);
                }
                    
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._longueurCheveux == noP._longueurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "A-t'il les cheveux courts?")
            {
                if (VraiOuFaux == true)
                {
                    LongueurCheveux lon = (LongueurCheveux)Enum.Parse(typeof(LongueurCheveux), "Court");
                    noP.SetLongueurCheveux(lon);
                }
                    
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._longueurCheveux == noP._longueurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == "Est-il chauve?")
            {
                if (VraiOuFaux == true)
                {
                    LongueurCheveux lon = (LongueurCheveux)Enum.Parse(typeof(LongueurCheveux), "Chauve");
                    noP.SetLongueurCheveux(lon);
                }
                    
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._longueurCheveux == noP._longueurCheveux)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionB)
            {
                if (VraiOuFaux == true)
                {
                    Sexe s = (Sexe)Enum.Parse(typeof(Sexe), "Homme");
                    noP.SetSexe(s);
                }
                else
                {
                    Sexe s = (Sexe)Enum.Parse(typeof(Sexe), "Femme");
                    noP.SetSexe(s);
                }
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._sexe == noP._sexe)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionE)
            {
                if (VraiOuFaux == true)
                {
                    noP.SetChapeau(true);
                }
                else
                {
                    noP.SetChapeau(false);
                }
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._chapeau == noP._chapeau)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionF)
            {
                if (VraiOuFaux == true)
                {
                    noP.SetMoustache(true);
                }
                else
                {
                    noP.SetMoustache(false);
                }
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._moustache == noP._moustache)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            else if (questionCourante == questionG)
            {
                if (VraiOuFaux == true)
                {
                    noP.SetBarbe(true);
                }
                else
                {
                    noP.SetBarbe(false);
                }
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._barbe == noP._barbe)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionH)
            {
                if (VraiOuFaux == true)
                {
                    noP.SetLunettes(true);
                }
                else
                {
                    noP.SetLunettes(false);
                }
                foreach (Personnages p in pl.ListeDePersonnages)
                {
                    if (p._lunettes == noP._lunettes)
                    {
                        liste.Add(p);
                        pl.ListeDePersonnages = liste;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        
        }

        public static Personnages CreationPersonnageJoueur()
        {
            VraiOuFaux = ReponseVraiFaux();
            Personnages p = new Personnages();
            if (questionCourante == "A-t'il les cheveux noirs?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Noir");
                    p.SetCouleurCheveux(coulChe);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les cheveux bruns?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Brun");
                    p.SetCouleurCheveux(coulChe);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les cheveux blonds?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Blond");
                    p.SetCouleurCheveux(coulChe);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les cheveux roux?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Roux");
                    p.SetCouleurCheveux(coulChe);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les cheveux châtains?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Châtain");
                    p.SetCouleurCheveux(coulChe);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les cheveux blancs?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurCheveux coulChe = (CouleurCheveux)Enum.Parse(typeof(CouleurCheveux), "Blanc");
                    p.SetCouleurCheveux(coulChe);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les yeux bruns?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Bruns");
                    p.SetCouleurYeux(coulY);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les yeux bleus?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Bleus");
                    p.SetCouleurYeux(coulY);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les yeux verts?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Verts");
                    p.SetCouleurYeux(coulY);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les yeux gris?")
            {
                if (VraiOuFaux == true)
                {
                    CouleurYeux coulY = (CouleurYeux)Enum.Parse(typeof(CouleurYeux), "Gris");
                    p.SetCouleurYeux(coulY);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les cheveux longs?")
            {
                if (VraiOuFaux == true)
                {
                    LongueurCheveux lon = (LongueurCheveux)Enum.Parse(typeof(LongueurCheveux), "Long");
                    p.SetLongueurCheveux(lon);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "A-t'il les cheveux courts?")
            {
                if (VraiOuFaux == true)
                {
                    LongueurCheveux lon = (LongueurCheveux)Enum.Parse(typeof(LongueurCheveux), "Court");
                    p.SetLongueurCheveux(lon);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == "Est-il chauve?")
            {
                if (VraiOuFaux == true)
                {
                    LongueurCheveux lon = (LongueurCheveux)Enum.Parse(typeof(LongueurCheveux), "Chauve");
                    p.SetLongueurCheveux(lon);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            else if (questionCourante == questionB)
            {
                if (VraiOuFaux == true)
                {
                    Sexe s = (Sexe)Enum.Parse(typeof(Sexe), "Homme");
                    p.SetSexe(s);
                    return p;
                }
                else
                {
                    Sexe s = (Sexe)Enum.Parse(typeof(Sexe), "Femme");
                    p.SetSexe(s);
                    return p;
                }
            }
            else if (questionCourante == questionE)
            {
                if (VraiOuFaux == true)
                {
                    p.SetChapeau(true);
                    return p;
                }
                else
                {
                    p.SetChapeau(false);
                    return p;
                }
            }
            else if (questionCourante == questionF)
            {
                if (VraiOuFaux == true)
                {
                    p.SetMoustache(true);
                    return p;
                }
                else
                {
                    p.SetMoustache(false);
                    return p;
                }
            }
            else if (questionCourante == questionG)
            {
                if (VraiOuFaux == true)
                {
                    p.SetBarbe(true);
                    return p;
                }
                else
                {
                    p.SetBarbe(false);
                    return p;
                }
            }
            else if (questionCourante == questionH)
            {
                if (VraiOuFaux == true)
                {
                    p.SetLunettes(true);
                    return p;
                }
                else
                {
                    p.SetLunettes(false);
                    return p;
                }
            }
            return null;
        }
        public static bool ReponseVraiFaux()
        {
            AfficherQuestionCourante();
            Console.WriteLine(questionCourante);
            if (questionCourante == questionA)
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return faux;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionB)
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionC)
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionD)
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionE)
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionF)
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (questionCourante == questionG)
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return vrai;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return vrai;
        }

        public static string AfficherQuestionCourante()
        {
            string reponse = DemanderQuestions();
            
            if (questionCourante == questionA)
            {
                if  (reponse == "a1")
                {
                    questionCourante = "A-t'il les cheveux noirs?";
                    return questionCourante;
                }
                else if (reponse == "a2")
                {
                    questionCourante = "A-t'il les cheveux bruns?";
                    return questionCourante;
                }
                else if (reponse == "a3")
                {
                    questionCourante = "A-t'il les cheveux blonds?";
                    return questionCourante;
                }
                else if (reponse == "a4")
                {
                    questionCourante = "A-t'il les cheveux roux?";
                    return questionCourante;
                }
                else if (reponse == "a5")
                {
                    questionCourante = "A-t'il les cheveux châtains?";
                    return questionCourante;
                }
                else
                {
                    questionCourante = "A-t'il les cheveux blancs?";
                    return questionCourante;
                }

            }
            else if (questionCourante == questionC)
            {
                
                if (reponse == "c1")
                {
                    questionCourante = "A-t'il les yeux bruns?";
                    return questionCourante;
                }
                else if (reponse == "c2")
                {
                    questionCourante = "A-t'il les yeux bleus?";
                    return questionCourante;
                }
                else if (reponse == "c3")
                {
                    questionCourante = "A-t'il les yeux verts?";
                    return questionCourante;
                }
                else
                {
                    questionCourante = "A-t'il les yeux gris?";
                    return questionCourante;
                }

            }
            else if (questionCourante == questionD)
            {
                if (reponse == "d1")
                {
                    questionCourante = "A-t'il les cheveux longs?";
                    return questionCourante;
                }
                else if (reponse == "d2")
                {
                    questionCourante = "A-t'il les cheveux courts?";
                    return questionCourante;
                }
                else
                {
                    questionCourante = "Est-il chauve?";
                    return questionCourante;
                }
            }
            
            else
            {
                return questionCourante;
            }
        }
        public static string DemanderQuestions()
        {
            try
            {
                AfficherQuestions();
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Choissisez une question...");
                    string reponse = Console.ReadLine();

                    if (reponse == "a")
                    {
                        questionCourante = questionA;
                        bool sortie2 = false;
                        while (sortie2 == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Choissisez un numéro de question de 1 à 6");
                            int numeroDeQuestion = int.Parse(Console.ReadLine());
                            if (numeroDeQuestion <= 6 && numeroDeQuestion > 0)
                            {
                                reponse = reponse + numeroDeQuestion;
                                return reponse;
                            }
                        }
                        sortie = true;
                    }
                    else if (reponse == "b")
                    {
                        questionCourante = questionB;
                        return reponse;
                        sortie = true;
                    }
                    else if (reponse == "c")
                    {
                        questionCourante = questionC;
                        bool sortie2 = false;
                        while (sortie2 == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Choissisez un numéro de question de 1 à 4");
                            int numeroDeQuestion = int.Parse(Console.ReadLine());
                            if (numeroDeQuestion <= 4 && numeroDeQuestion > 0)
                            {
                                reponse = reponse + numeroDeQuestion;
                                return reponse;
                            }
                        }
                        sortie = true;
                    }
                    else if (reponse == "d")
                    {
                        questionCourante = questionD;
                        bool sortie2 = false;
                        while (sortie2 == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Choissisez un numéro de question de 1 à 3");
                            int numeroDeQuestion = int.Parse(Console.ReadLine());
                            if (numeroDeQuestion <= 3 && numeroDeQuestion > 0)
                            {
                                reponse = reponse + numeroDeQuestion;
                                return reponse;
                            }
                        }
                        sortie = true;
                    }
                    else if (reponse == "e")
                    {
                        questionCourante = questionE;
                        return reponse;
                        sortie = true;
                    }
                    else if (reponse == "f")
                    {
                        questionCourante = questionF;
                        return reponse;
                        sortie = true;
                    }
                    else if (reponse == "g")
                    {
                        questionCourante = questionG;
                        return reponse;
                        sortie = true;
                    }
                    else if (reponse == "h")
                    {
                        questionCourante = questionH;
                        return reponse;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                    return null;
                }
            } catch (FormatException erreur)
            {
                Console.WriteLine("Une erreur de format est survenue.");
            } catch (Exception erreur)
            {
                Console.WriteLine("Une erreur est survenue.");
            }
            return null;
        }
        public static void AfficherQuestions()
        {
            Console.WriteLine(questionA);
            Console.WriteLine(questionB);
            Console.WriteLine(questionC);
            Console.WriteLine(questionD);
            Console.WriteLine(questionE);
            Console.WriteLine(questionF);
            Console.WriteLine(questionG);
            Console.WriteLine(questionH);
        }
    }
}