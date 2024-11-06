using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Créer la liste contenant toutes les informations données par le responsable
        List<string> couleurs = new List<string> { "vert claire", "jaune", "XXL", "cendre" };

        // 2. XXL est une erreur de saisie. Supprimer la de la liste
        couleurs.Remove("XXL");

        // 3. Insérer à la place de XXL la couleur grise
        couleurs.Insert(2, "grise"); // On insère "grise" à l'index 2, là où XXL était

        // 4. Ensuite compléter la liste avec les couleurs blanche et marron
        couleurs.Add("blanche");
        couleurs.Add("marron");

        // 5. Supprimer la deuxième couleur de la nouvelle liste
        couleurs.RemoveAt(1); // On supprime l'élément à l'index 1 (la deuxième couleur)

        // 6. Afficher l’index de la couleur "cendre"
        int indexCendre = couleurs.IndexOf("cendre");
        Console.WriteLine($"L'index de la couleur 'cendre' est : {indexCendre}");

        // Affichage final de la liste pour vérification
        Console.WriteLine("Liste des couleurs finales :");
        foreach (var couleur in couleurs)
        {
            Console.WriteLine(couleur);
        }
    }
}
