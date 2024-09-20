// See https://aka.ms/new-console-template for more information
using SzamelmeletProjekt;

// Nem kell példányosítani a statikus osztályokat
// Szamelmelet szamelmelet = new Szamelmelet();

// Statikus osztályokat osztálynévvel érjük el
Console.WriteLine(Szamelmelet.OsztoE(5,35));
Console.WriteLine(Szamelmelet.OsztoE(8,35));

Console.WriteLine(Szamelmelet.KiLista(Szamelmelet.GetOsztok(6)));
