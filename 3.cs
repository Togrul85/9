
using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname, groupNo;
            int age;
            do
            {
                Console.Write("Fullname:");
                fullname = Console.ReadLine();
            } while (!Student.CheckFullname(fullname));

            do
            {
                Console.Write("Group No: ");
                groupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupNo));


            do
            {
                Console.Write("age: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age <= 0 || age > 100);

            Student st = new Student ( groupNo, fullname, age);

        }
    }
}
