using System;

namespace C0732134
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            bool cond = true;
            while (cond)
            {
                Console.WriteLine("Enter the name: ");
                ds.name = Console.ReadLine();
                Console.WriteLine("Enter the GPA: ");
                ds.gpa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Grade in Integer : ");
                ds.grade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you wish to Continue press [y, n]");
                if (Console.ReadLine() != "y")
                    cond = false;
            }

            for (int i = 0; i <  ; i++)
            {

            }
            Console.WriteLine("\n\nName : "+ ds.name);
            Console.WriteLine("\n\nName : " + ds.gpa); 
            Console.WriteLine("\n\nName : " + ds.grade);
        }
    }

    class DataSet
    {
       public string name = "";
       public double gpa = 0.0f;
       public int grade = 0;
    }
}
