// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DotNetOO3;
PersonHandler personHandler = new PersonHandler();

//Person mats = new Person(45, "mats", "skogfeldt", 180, 115);
Person adam = personHandler.CreatePerson(25, "Adam", "Allbäck", 170, 70);
Person bertil = personHandler.CreatePerson(35, "Bertil", "Barsebäck", 180, 80);
personHandler.SetAge(adam, 26);
personHandler.HaveBirthday(bertil);
Console.WriteLine("Adams is age: " + adam.age);
Console.WriteLine("Adams is age: " + bertil.age);

List<UserError> errors = new List<UserError>();

errors.Add(new NumericInputError());
errors.Add(new TextInputError());
errors.Add(new IAmSoSmartThatIOnlydoesOneextraClassOfINputErrors());

foreach (UserError error in errors)
{
    error.UEMessage();
}