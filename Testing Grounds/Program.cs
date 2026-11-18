namespace Testing_Grounds
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your First Grade");
            int grade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Second Grade");
            int grade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your THird Grade");
            int grade3 = int.Parse(Console.ReadLine());


            int totalG = grade1 + grade2 + grade3;
            int Avg = totalG / 3;


            string AgeNum;
            if (age >= 18 )
            {
                AgeNum = "(Adult)";
            }
            else
            {
                AgeNum = "(Minor)"; ;
            }


            string Total;
            if (totalG > 50)
            {
                Total = "Passed";
            }
            else
            {
                Total = "Failed";
            }



            Console.WriteLine("---------------------------");
            Console.WriteLine($"Student's name : {name.ToUpper()}");
            Console.WriteLine($"Student's Age  : {age}  {AgeNum}\n");
            
            Console.WriteLine($"Total Grades   : {totalG}");
            Console.WriteLine($"AVG            : {Avg}\n");
            
            
            Console.WriteLine($"Status         : {Total}");

            Console.WriteLine("---------------------------");




























        }
    }
}
