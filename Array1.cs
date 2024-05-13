
/* Fichier Arrayl.cs
 * Exemple de tri e: de recherche avec System.Array

     * Cas des vrais tableaux d'objers    :    a venir plus card

     * Par LVN pour IFT 1179

     */
using System;

class Array1
static void Afficher(string[]       tableau,      string message)
          {
                      Console.WriteLine("Les journees de la semaine " +
                                  message + "     :   ");
                      for (int i = 0; i < tableau.Length; i++)
                            Console.WriteLine("{0, 5:D] {l, 15}",                   i,
                                         tableau[i]);
                      Console.WriteLine();
          }

          static void Demo2()
          {
               Console.WriteLine("\nDemo 2 : Tableau des string(s}:\n"}:
               string[] journee = {"Lundi", "Mardi", "Mercredi", "Jeudi",
                                    "Vendredi", "Samedi", "Dimanche”};
               Afficher(journee, "avant le tri");
               Array.Sort(journee):
               Afficher(journee,    "apres le tri"):
                int indice = Array.BinarySearch(journee,"Samedi");
                Console.WriteLine("On trouve Samedi a l'indice :" + indice);
                indice = Array.BinarySearch(journee, "Lunch");
                Console.WriteLine("L'indice de Lunch est : " + indice);
                Console.WriteLine("L'indice de Mars est : " + Array.BinarySearch(journee,"Mars"));
                Console.WriteLine();
}
                                     

 static void Afficher(double[] tableau, string message) {
   Console.WriteLine("Les poids " + message + ":");
   for (int i = 0; i < tableau.Length; i++)
     Console.WriteLine("{0, 5:D} {1, 15:F2}",i,tableau[i]);
     Console.WriteLine();
  }

 static void Demol() {
 Console.WriteLine("Demo 1: Tableau des double(s):\n");
 double[] poids = { 123.45,  65.2, 67.9,  98.4,  75.2,  90.5 };

 Afficher(poids, "avant le tri");
 Array.Sort(poids);
 Afficher(poids, "apres le tri");
 int indice = Array.BinarySearch(poids, 67.9);
 Console.WriteLine("On trouve ce poids 67.9 a l'indice : "+indice);
 indice = Array.BinarySearch(poids, 567.89);
 Console.WriteLine("L'indice de 567.89 est      :    " + indice);
Console.WriteLine();
}

 static void Main(string[] args)
{
 Demol():
 Demo2()]:
                                     }
}

/* Execution:

Demo 1                                     :   Tableau des double(s):
L"
(D
     U]

          U‘I If.) U) N |—‘ ”3'75




                                    -oids avant le tri
                                               123,65
                                                65,20
                                                67,90
                                                98,40
                                                75,20
                                                90,50
                    0
                                     |_|




Les                                   'ds apres le tri
          UIn wlvrech




                                                65,20
                                                61,90
                                                75,20
                                                90,50
                                                98,40
                                               123,45

