namespace CPRG_211_F_Lab_3_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();


            //Dog Class inherited from IAnimal

            Console.WriteLine("Enter dog name: ");

            dog.Name = Console.ReadLine();

            Console.WriteLine("Enter dog color: ");

            dog.Colour = Console.ReadLine();

            Console.WriteLine("Enter dog height: ");

            dog.Height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter dog age: ");

            dog.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe dog's name is {dog.Name}, its colour is {dog.Colour}, is {dog.Height}cm tall, and is {dog.Age} years old.");
            dog.Eat();
            Console.WriteLine(dog.Cry());
            Console.WriteLine();



            //Cat Class inherited from IAnimal

            Console.WriteLine("Enter cat name: ");

            cat.Name = Console.ReadLine();

            Console.WriteLine("Enter cat color: ");

            cat.Colour = Console.ReadLine();

            Console.WriteLine("Enter cat height: ");

            cat.Height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter cat age: ");

            cat.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe cat's name is {cat.Name}, its colour is {cat.Colour}, is {cat.Height}cm tall, and is {cat.Age} years old.");
            cat.Eat();
            Console.WriteLine(cat.Cry());
            Console.WriteLine();



            // List of animals and prints out all of their names

            IAnimal dog2 = new Dog();
            dog2.Name = "Max";
            IAnimal cat2 = new Cat();
            cat2.Name = "Luna";
            IAnimal dog3 = new Dog();
            dog3.Name = "Buster";
            IAnimal cat3 = new Cat();
            cat3.Name = "Milo";


            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(dog2);
            animals.Add(cat2);
            animals.Add(dog3);
            animals.Add(cat3);

            foreach (IAnimal animal in animals) {

                Console.WriteLine(animal.Name);

            }

        }
    }
}
