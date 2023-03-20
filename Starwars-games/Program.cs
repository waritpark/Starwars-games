// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

// ---------------------- cours ----------------------
//Console.ForegroundColor = ConsoleColor.DarkRed;

// string ou var
// var monTitre = "Starwars game !".ToUpper();

// 1ere méthode : concaténation
// monTitre = monTitre + " (" + DateTime.Now.ToString() + ")";
// Console.WriteLine(monTitre);

// 2eme méthode : format string
// string format = "{0} ({1})";
// monTitre = string.Format(format, monTitre, DateTime.Now);
// Console.WriteLine(monTitre);

//3eme méthode : c'est très laid
// Console.WriteLine($"{monTitre.ToUpper()} ({DateTime.Now.ToString("dd/MM/yyyy")})");


// ---------------------- partie titre et sous titre ----------------------
// variables contenant le titre et le sous titre
string monTitre = "Starwars game !";
string sousTitre = "Le retour de Francois !".ToLower();
// affichage du titre avec la couleur par défaut
Console.WriteLine("Titre du jeu : " + monTitre);
// affichage du sous titre en jaune
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Sous titre du jeu : " + sousTitre);

// ---------------------- partie personne ----------------------

// affichage de la question en blanc
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Quelle est ta date de naissance ? (annees,mois,jours) ");
//variable contenant la naissance 
var naissance = Console.ReadLine();
// condition pour vérifier que l'utilisateur a entrée des données
if (naissance != null)
{
    // demande de l'age
    Console.WriteLine("Quel est votre prénom ?");
    // variable contenant l'age
    var prenom = Console.ReadLine();
    // transformation de la date de naissance recu et DateTime
    var parsedDate = DateTime.Parse(naissance);
    // Récupération de la date d'aujourd'hui pour calculer
    var today = DateTime.Now;
    // calcul de l'age
    TimeSpan age = (today - parsedDate) / 365;
    // modification de la variable en string
    string agestring = age.ToString();
    // modification de la variable pour avoir que les 2 premieres valeurs
    string extractage = agestring.Substring(0, 2);
    // affichage des informations
    Console.WriteLine("Ton prénom est bien : " + prenom + " ? Tu es agé de "+ extractage + " ans");
}
else
{
    // affichage d'une erreur si l'utilisateur n'a pas rempli sa date de naissance
    Console.WriteLine("Erreur ! fin du programme");
}

// fonction Extract qui permet de récuperer le nombre de caractères voulu dans une string
