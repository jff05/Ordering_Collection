using System;
using System.Collections.Generic;

namespace JFF_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de ma liste de Candidatures

            List<Candidature> maLst = new List<Candidature>();

            Candidature cdt = new Candidature("Amine", 64);
            maLst.Add(cdt);

            cdt = new Candidature("Richard", 654);
            maLst.Add(cdt);

            cdt = new Candidature("Mathieu", 999);
            maLst.Add(cdt);

            cdt = new Candidature("Jean-Luc", 782);
            maLst.Add(cdt);

            cdt = new Candidature("William", 1000);
            maLst.Add(cdt);

            cdt = new Candidature("Richard", 782);
            maLst.Add(cdt);

            cdt = new Candidature("Nicolas", 782);
            maLst.Add(cdt);

            cdt = new Candidature("Mohamed", 654);
            maLst.Add(cdt);


            
            // Affichage de ma list initiale

            string txt = String.Empty;

            txt += "Avant le tri : \nParticipant\tScore \n";

            foreach (Candidature c in maLst)
            {
                txt += c.ToString() + "\n";
            }


            // Triage de ma liste

            // Utilisation d'une méthode non maîtrisée 
            //
            //malst.Sort();


            // Triage par score descendant
            //
           // TrierParScore(maLst);

            // Triage par score descendant
            //
            //TrierParParticipant(maLst);

            //Triage par scores descendant, puis participants en ordre alphabétique (== ascendant)
            TrierScoresEtParticipants(maLst);

            // Affichage de ma liste après triage
            //
            txt += "\nAprès un tri avec Sort : \nParticipant\tScore \n";
        
            foreach (Candidature c in maLst)
            {
                txt += c.ToString() + "\n";
            }

            Console.WriteLine(txt);
        }

        private static List<Candidature> TrierScoresEtParticipants(List<Candidature> maLst)
        {
            bool enOrdre;
            do
            {
                enOrdre = true;
                List<Candidature> listTemp = new List<Candidature>();
                Candidature tempCdt = new Candidature("",0);
                listTemp.Add(tempCdt);

                for (int i = 0; i < maLst.Count - 1; i++)
                {

                    if (maLst[i].Score < maLst[i + 1].Score)
                    {
                        // Inversion des candidatures sur la base du Participant alphabétiquement ordonné.
                        listTemp[0] = maLst[i];
                        maLst[i] = maLst[i + 1];
                        maLst[i + 1] = listTemp[0];
                        enOrdre = false;
                    }
                    else if(maLst[i].Score == maLst[i + 1].Score)
                    {
                        int comp = string.Compare(maLst[i].Participant, maLst[i + 1].Participant);
                        if (comp > 0)
                        {
                            listTemp.Add(tempCdt);

                            // Inversion des candidatures sur la base du Participant alphabétiquement ordonné.
                            listTemp[0] = maLst[i];
                            maLst[i] = maLst[i + 1];
                            maLst[i + 1] = listTemp[0];
                            enOrdre = false;
                        }
                    }
                }

            } while (!enOrdre);

            return maLst;

        }

        private static List<Candidature> TrierParParticipant(List<Candidature> maLst)
        {
            bool enOrdre;
            // Triage par ordre alphabétique du participant 
            do
            {
                enOrdre = true;

                for (int i = 0; i < maLst.Count - 1; i++)
                {
                    int comp = string.Compare(maLst[i].Participant, maLst[i + 1].Participant);
                    if (comp < 0)
                    {
                        List<Candidature> listTemp = new List<Candidature>();
                        Candidature tempCdt = new Candidature(" ", 0);
                        listTemp.Add(tempCdt);

                        // Inversion des candidatures sur la base du Participant alphabétiquement ordonné.
                        listTemp[0] = maLst[i];
                        maLst[i] = maLst[i + 1];
                        maLst[i + 1] = listTemp[0];
                        enOrdre = false;
                    }
                }

            } while (!enOrdre);

            return maLst;
        }

        private static List<Candidature> TrierParScore(List<Candidature> maLst)
        {
            bool enOrdre;
            do
            {
                enOrdre = true;
                List<Candidature> listTemp = new List<Candidature>();
                Candidature tempCdt = new Candidature("test", 0);
                listTemp.Add(tempCdt);

                for (int i = 0; i < maLst.Count - 1; i++)
                {

                    if (maLst[i].Score < maLst[i + 1].Score)
                    {
                        // Inversion des candidatures sur la base du Score non Strictement Inférieur
                        listTemp[0] = maLst[i];
                        maLst[i] = maLst[i + 1];
                        maLst[i + 1] = listTemp[0];
                        enOrdre = false;
                    }
                }

            } while (!enOrdre);

            return maLst;
        }

        
    }
}
