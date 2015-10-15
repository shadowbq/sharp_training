using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyClass
    {
        public bool siprimo(long a)
        {// evaluate if the received number is prime
            bool sp = true;
            for (long k = 2; k <= a / 2; k++)
                if (a % k == 0) sp = false;
            return sp;
        }
        public long volteado(long a)
        {// swap the received number
            long v = 0;
            while (a > 0)
            {
                v = 10 * v + a % 10;
                a /= 10;
            }
            return v;
        }
    }
    
    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    class Program
    {
        // Reference http://sharp.net-tutorials.com/basics/arrays/

        //static methods because main is static
        static public int AddNumbers(int number1)
        {
            int result = number1 + 14;
            return result;
        }

        static void GreetPersons(int someUnusedParameter, params string[] names)
        {
            foreach(string name in names)
                Console.WriteLine("Hello, " + name);
        }

        static void Main(string[] args)
        {
            string username = "JohnDoe";
            string password = "InsecurePassword";

            Console.WriteLine("Hello " + username +", your password is :" + password);
            Console.WriteLine("New Password please:");
            password = Console.ReadLine();
            Console.WriteLine("Hello " + username + ", your new password is :" + password);
            Console.ReadLine();
            
            
            Car car;
            car = new Car("Red");
            Console.WriteLine(car.Describe());
            Console.WriteLine("The car getter method is exposed for color: " + car.Color);
            car.Color = "purple";
            Console.WriteLine("The car setter method is exposed for color: " + car.Color);
            
            Car car2 = new Car("Green");
            Console.WriteLine(car2.Describe());
            Console.ReadLine();
            

            GreetPersons(0);
            GreetPersons(25, "John", "Jane", "Tarzan");
            Console.ReadKey();
            
            int number1;
            do
            {
                Console.WriteLine("Please enter a number(1-10):");
                number1 = int.Parse(Console.ReadLine());
                if ((number1 > 0) && (number1 < 11))
                    Console.WriteLine("Good job!");
                else
                    Console.WriteLine("Out of range.. boo");
            
            } while ((number1 < 1) || (number1 > 10));

            int result = AddNumbers(number1);
            Console.WriteLine("Adding ?? to your number: " + result);
            Console.ReadLine();
            
            ArrayList list = new ArrayList();
            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");
            
            foreach(string name in list)
                Console.WriteLine(name);

            Console.ReadLine();

            //Class with Public methods
            MyClass cls  = new MyClass();
            Console.Write("Write a number: ");
            long a= Convert.ToInt64(Console.ReadLine()); // a is the number given by the user
            long av = cls.volteado(a);
            bool isTrue = cls.siprimo(a);
            bool isavTrue = cls.siprimo(av);
            Console.WriteLine("a: " + a + "av: " + av);
            if (isTrue == false && isavTrue == false) 
                Console.WriteLine("Both original and swapped numbers are prime.");
            else
                Console.WriteLine("One of the numbers isnt prime.");
            Console.ReadLine();

            Console.WriteLine("Do you enjoy C# ? (yes/no/maybe)");
            string input = Console.ReadLine();
            switch(input.ToLower())
            {
                case "yes":
                case "maybe":
                    Console.WriteLine("Great!");
                    break;
                case "no":
                    Console.WriteLine("Too bad!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, I don't understand that!");
                    break;
            }

            Console.ReadLine();

        }
    }
}
