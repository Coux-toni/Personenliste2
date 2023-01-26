using Personenliste2;

Person p1 = new Person("Arian", "Lackner", "m");
Person p2 = new Person("Can", "Kayac", "m");
Person p3 = new Person("Fabian", "Eder", "m");
List<Person> Personen = new List<Person>();

Personen.Add(p1);
Personen.Add(p2);
Personen.Add(p3);

for(int i = 0; i < Personen.Count; i++)
{
    if (Personen[i].Geschlecht == "m")
    {
        Console.WriteLine(Personen[i].Geschlecht);
    }
}
Person p5 = new Person("Max", "Lackner", "m");
