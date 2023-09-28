namespace Part_3___Console_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age;
            int year;
            int num1, num2, num3;
            int dist1, dist2, dist3;
            int length1, length2;

            Console.WriteLine("Hello, please enter your name below: ");
            name = Console.ReadLine();
            Console.WriteLine("Now enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Finally, enter the current year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You were born in the year " + (year - age));
            Console.WriteLine("Enter in 3 numbers and I'll print the total");
            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hold on, give me a second.");
            Console.WriteLine();
            Console.WriteLine("The total of the three numbers is " + (num1 + num2 + num3));
            Console.WriteLine();
            Console.WriteLine("Now give me three distances in km and I'll print the average");
            dist1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a distance:");
            dist2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a distance:");
            dist3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The average of the three distances is " + (dist1 + dist2 + dist3) + " km.");
            Console.WriteLine();
            Console.WriteLine("Put in two legs of a right triangle and I'll print out the length of the hypotenuse");
            length1 = Convert.ToInt32(Console.ReadLine());
            length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The length of the hypotenuse is {Math.Sqrt(length1 + length2)}");
        }
    }
}