namespace UML.Herencia
{
    // Herencia
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }

    public class Fish : Animal
    {
        public void swing()
        {
            Console.WriteLine("The fish is swimming.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat(); // Método heredado de la clase Animal
            dog.Bark(); // Método específico de la clase Dog
        }
    }

}
