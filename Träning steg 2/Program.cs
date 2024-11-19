// List<string> leksaker = ["bil", "kort", "forboll", "pokmeon", "jojo"];


// Console.ReadLine();

// List<string> klassnamn = ["Aris", "Sandor", "Calin", "ägglas", "bash"];

// List<int> nmr = [1, 6, 12, 4, 55, 6, 7, 8, 9, 10];




// for (int i = 0; i < leksaker.Count; i++)
// {
//     Console.WriteLine($"{klassnamn[i]} ger {leksaker[i]} betyget {nmr[i]}");
// }


// Console.ReadLine();

List<String> cities = [];

string city = "";
while (city != "exit")
{
    city = Console.ReadLine();

    if (city != "exit")
    {
        cities.Add(city);
    }
}

Console.WriteLine("-----------------------");

for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine($"{cities[i]}");
}

Console.ReadLine();