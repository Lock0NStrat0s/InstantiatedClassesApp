using ConsoleUI;

//building a house from the blueprint
//PersonModel person = new PersonModel();

//List<PersonModel> people = new List<PersonModel>();

////variable holds the street address
//PersonModel person = new PersonModel();

//person.firstName = "Mohammad";

//people.Add(person);

List<PersonModel> people = new List<PersonModel>();
string firstName = "";

do
{
    Console.Write("What is your first name (e to exit): ");
    firstName = Console.ReadLine();

    Console.Write("What is your last name (e to exit): ");
    string lastName = Console.ReadLine();

    if (firstName.ToLower() != "e")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
    }
} while (firstName.ToLower() != "e");

foreach (PersonModel p in people)
{
    ProcessPerson.GreetPerson(p);
}