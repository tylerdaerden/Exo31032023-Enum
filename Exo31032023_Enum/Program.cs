#region Exos_Enumérations

#region 1.1

//1.1 Créer une énumération pour les couleurs ( Coeur , Carreau, Pique, Trefle)

using Exo31032023_Enum;

//foreach ( string val in Enum.GetNames(typeof(couleurs)))
//{
//    Console.WriteLine(val);
//}

//foreach (int val2 in Enum.GetValues(typeof(couleurs)))
//{
//    Console.WriteLine(val2);
//}

//Console.WriteLine(  );
//Console.WriteLine("____________________________________________________");
//Console.WriteLine(  );




#endregion

#region 1.2

//1.2 Créer une énumération pour les valeurs (as = 14, deux = 2, trois = 3, ..., Roi = 13)

//foreach (string val3 in Enum.GetNames(typeof(valeurs)))
//{
//    Console.WriteLine(val3);
//}

//foreach (int val4 in Enum.GetValues(typeof(valeurs)))
//{
//    Console.WriteLine(val4);
//}

//Console.WriteLine();
//Console.WriteLine("____________________________________________________");
//Console.WriteLine();





#endregion

#region 1.3 

//1.3 Créer une structure Carte qui contient deux variables publiques :
//Couleur de type Couleurs
//Valeur de type Valeurs
//Déclarer un tableau de Carte d'une taille de 52
//À l'aide d'une boucle « foreach » définir les couleurs et les valeurs de chacune des cartes
//Afficher les cartes (Définir si cela fonctionne : si oui pourquoi, sinon pourquoi)

Cartes[] jeuDeCartes = new Cartes[52];

int i = 0;
foreach (Cartes.Couleurs couleur in Enum.GetValues(typeof(Cartes.Couleurs)))
{
    foreach (Cartes.Valeurs valeur in Enum.GetValues(typeof(Cartes.Valeurs)))
    {
        jeuDeCartes[i].Couleur = couleur;
        jeuDeCartes[i].Valeur = valeur;
        i++;
    }
}

// Affichage du contenu du tableau de Cartes
foreach (Cartes carte in jeuDeCartes)
{
    Console.WriteLine(carte.Valeur + " de " + carte.Couleur);
}

Console.WriteLine(  );
Console.WriteLine("______________________________________");

#endregion

#endregion