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

        public static bool vrai = true;
        public static bool faux = false;
        public static string questionCourante;

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
                        return false;
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