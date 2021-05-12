using System;
using System.Collections.Generic;
using System.Text;
using TP3.Classes;

namespace TP3.Classes
{
    class Questions
    {
        public static string questionA = "a) A-t'il les cheveux: \n  \n     1) Noir \n     2)Brun \n     3)Blond \n     4)Roux \n     5)Châtain \n     6)Blanc \n";
        public static string questionB = "b) Es-t'il un homme? ";
        public static string questionC = "c) A-t'il les yeux: \n  \n     1) Bruns \n     2)Bleus \n     3)Verts \n     4)Gris \n";
        public static string questionD = "d) A-t'il les cheveux: \n  \n     1) Longs \n     2)Courts \n     3)Chauve (Il n'en a pas) \n";
        public static string questionE = "e) A-t'il un chapeau? ";
        public static string questionF = "f) A-t'il une moustache? ";
        public static string questionG = "g) A-t'il une barbe? ";
        public static string questionH = "h) A-t'il des lunettes? ";

        
        public static void ReponseQuestionVraiFaux()
        {
            
        }
        public static string ReponseQuestion()
        {
            string reponse = DemanderQuestions();
            Console.Clear();
            
            if (reponse == "a")
            {
                Console.WriteLine(questionA);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }

            else if (reponse == "b")
            {
                Console.WriteLine(questionB);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }

            else if (reponse == "c")
            {
                Console.WriteLine(questionC);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }

            else if (reponse == "d")
            {
                Console.WriteLine(questionD);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }

            else if (reponse == "e")
            {
                Console.WriteLine(questionE);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }
            else if (reponse == "f")
            {
                Console.WriteLine(questionF);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }

            else if (reponse == "g")
            {
                Console.WriteLine(questionG);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }

            else
            {
                Console.WriteLine(questionH);
                bool sortie = false;
                while (sortie == false)
                {
                    Console.WriteLine("Oui (o) ou Non (n)?");
                    string ouiOuNon = Console.ReadLine();
                    if (ouiOuNon == "o")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else if (ouiOuNon == "n")
                    {
                        return ouiOuNon;
                        sortie = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                return null;
            }

        }
        public static string DemanderQuestions()
        {
            try
            {
               
                bool sortie = false;
                
                while (sortie == false)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Choisissez une question...");
                    Console.WriteLine("");
                    AfficherQuestions();
                    Console.WriteLine("");
                    string reponse = Console.ReadLine();
                    
                    if (reponse == "a")
                    {
                        Console.WriteLine("Choissisez une couleur de 1 à 6...");
                        reponse = reponse + Console.ReadLine();
                        Console.WriteLine(reponse);
                        return reponse;
                        sortie = true;
                    }
                    
                    else if (reponse == "b")
                    {
                        return reponse;
                        sortie = true;
                    }
                    
                    else if (reponse == "c")
                    {
                        return reponse;
                        sortie = true;
                    }
                    
                    else if (reponse == "d")
                    {
                        return reponse;
                        sortie = true;
                    }
                    
                    else if (reponse == "e")
                    {
                        return reponse;
                        sortie = true;
                    }
                    else if (reponse == "f")
                    {
                        return reponse;
                        sortie = true;
                    }

                    else if (reponse == "g")
                    {
                        return reponse;
                        sortie = true;
                    }

                    else if (reponse == "h")
                    {
                        return reponse;
                        sortie = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Veuillez rentrer une lettre de a-h");
                        continue;
                    }
                }
                
                
            } catch (FormatException)
            {
                Console.WriteLine("Une erreur de format est survenue");
            } catch (Exception)
            {
                Console.WriteLine("Une erreur est survenue");
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
