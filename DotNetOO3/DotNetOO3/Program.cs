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


//F 13: antar vi lägger det på Bird
//F 14: På animal


Bird blueBird = new Bird(2, "domherre", 1);
Dog fido = new Dog(12, "Labrados", 25);
Flamingo pinkBeuty = new Flamingo(1, "National Animal of India", 2);
Horse skuggFaxe = new Horse(5, "Ardener", 500);
Wolf bigBad = new Wolf(5, "Varg", 45);
Wolfman teenWolf = new Wolfman(16, "Scotty", 50);

List<Animal> animals = new List<Animal>() { blueBird, fido, pinkBeuty, skuggFaxe, bigBad, teenWolf };

foreach (Animal animal in animals)
{
    Console.WriteLine("Test to get the animal: " + animal.ToString);
    Console.WriteLine("Data Type of animal: " + animal.GetType());
    
    if(animal.GetType() is Dog)
    {
        Dog doggie = (Dog)animal;
        doggie.Fetch();
    }
    animal.DoSound();
    if(animal is IPerson )
    {
        IPerson ani = (IPerson)animal;
        ani.Talk();
    }
        
}
Dog lassie = new Dog(11, "Collie", 24);

List<Dog> dogs = new List<Dog>() { fido, lassie };
// F9 För att häst inte är en hund, och datatype and something something, stack and heap and pointers!
// f10 Animal!

foreach (Animal animal in animals)
{
    animal.Stats();
}   

//F13 den loppar genom listan och kallar på funktion som ligger på objecten, som är en print

//f17 för att den inte 

