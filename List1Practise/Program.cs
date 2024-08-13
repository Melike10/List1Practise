// See https://aka.ms/new-console-template for more information

// create new string list
List<string> davetliler = new List<string>()
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};

// we can also Add() methods

davetliler.Add("Ceza");
davetliler.Add("Tan Taşçı");

// print all guest list

Console.WriteLine("---DAVETLİLER---");
foreach (var item in davetliler)
{
    Console.WriteLine(item);
}



