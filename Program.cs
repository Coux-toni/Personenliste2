using Personenliste2;
using System.ComponentModel;

Person p1 = new Person("Arian", "Lackner", "m");
Person p2 = new Person("Can", "Kayac", "m");
Person p3 = new Person("Fabian", "Eder", "m");
List<Person> Personen = new List<Person> { };

Personen.Add(p1.Vorname,p1.Nachname,p1.Geschlecht);
Personen.Add(p2.Vorname,p2.Nachname,p2.Geschlecht);
Personen.Add(p3.Vorname,p3.Nachname,p3.Geschlecht);


for(int i = 0; i >= Personen.Count; i++)
{
    if (Personen[i].Geschlecht == "m")
    {
        Console.WriteLine(Personen);
    }
}
