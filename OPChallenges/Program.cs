using System;

namespace OPChallenges
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;
            
            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine("DEBUG, created name: " + name);
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("woof");
                happiness += 0.2;
            }
            public void Wiggle()
            {
                Console.WriteLine("wiggle");
            }
            public void Rename(string NewName)
            {
                name = NewName;
            }
            public void DataDisplay()
            {
                Console.WriteLine("DEBUG, name: " + name);
                Console.WriteLine("DEBUG, spots: " + spots);
                Console.WriteLine("DEBUG, happiness: " + happiness);
            }
        }
        static void Main(string[] args)
        {
            Dog newDog = new Dog("põld", 10);
            while (newDog.Happiness !< 1)
            {
                newDog.Barks();
                Console.WriteLine("DEBUG, Happiness: " + newDog.Happiness);
            }
            newDog.Rename("attention retard, write a new name" + Console.ReadLine());
            newDog.DataDisplay();
        }
    }
}
