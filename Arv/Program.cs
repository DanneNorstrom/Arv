namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            animalList.Add(new Wolfman("Wolverine", 35, 10, false, 0.2));
            animalList.Add(new Horse("Blixten", 200, 5, "DanielN"));
            animalList.Add(new Dog("Ludde", 25, 2, "Dalmatin"));
            animalList.Add(new Dog("Lufsen", 10, 9, "Terrier"));
            animalList.Add(new Dog("Bethoven", 15, 4, "Bulldog"));
            animalList.Add(new Hedgehog("Spiken", 2, 1, 2000));
            animalList.Add(new Bird("Tweety", 1, 1, 0.2));
            animalList.Add(new Flamingo("Pinkster", 5, 3, 1, 0.5));
            animalList.Add(new Pelican("Stortruten", 5, 2, 1, 0.5));
            animalList.Add(new Swan("Svanis", 6, 3, 1, 0.5));
            animalList.Add(new Worm("Maskis", 0.01, 1, true));
            animalList.Add(new Wolf("Gråben", 35, 7, true));


            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
                //F: svar via method överlagring anropas varje animals specifika stats method

                IPerson? p = animal as IPerson;

                if (p != null)
                {
                    p.Talk();
                }

                else
                {
                    animal.DoSound();
                }
            }

            List<Dog> dogList = new List<Dog>();
            //dogList.Add(new Horse("Blixten2.0", 250, 3, "DanielN"));
            //F: svar ovanstående rad fungerar ej pga att Horse inte är av typen Dog
            //F: svar listans typ måste vara animal

            Console.WriteLine();

            foreach (Animal animal in animalList)
            {
                if (animal.GetType() == typeof(Dog))
                {
                    Console.WriteLine(animal.Stats());

                    //Console.WriteLine(animal.retString());
                    //F: Ovanstående rad fungerar ej pga att metoden ej är överlagrad

                    //lösningen för detta 
                    Dog? d = animal as Dog;
                    if (d != null)
                    {
                        Console.WriteLine(d.RetString());
                    }
                }
            }
        }
    }
}
