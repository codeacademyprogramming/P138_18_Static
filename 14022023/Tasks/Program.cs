using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student std1 = new Student { GroupNo = "P111", FullName = "Name1" };
            //Student std2 = new Student { GroupNo = "P121", FullName = "Name2"};
            //Student std3 = new Student { GroupNo = "P141", FullName = "Name3"};
            //Student std4 = new Student { GroupNo = "P123", FullName = "Name4"};
            //Student std5 = new Student { GroupNo = "P143", FullName = "Name5"};

            //Console.WriteLine(Student.Count);

            Product pr1 = new Product("Drink")
            {
                Name = "Coca cola 1L",
                Price = 12
            };

            Product pr2 = new Product("Drink")
            {
                Name = "Sirab 1L",
                Price = 4
            };

            Product pr3 = new Product("Drink")
            {
                Name = "Pepsi cola 1L",
                Price = 10
            };

            Product pr4 = new Product("Bakery");

            Console.WriteLine(pr1.No);
            Console.WriteLine(pr2.No);
            Console.WriteLine(pr3.No);
            Console.WriteLine(pr4.No);

            string str = "hIKmeT";//Hikmet



            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToCapitalize());
            Console.WriteLine(ExtentionMethods.ToCapitalize(str));


            int num = 45;

            var result = num.Add(100);
            result = ExtentionMethods.Add(100, 50);
            result = num.Add(-100);


            Console.WriteLine(result);


            Console.WriteLine("Adi daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine(name.HasDigit());
            Console.WriteLine(name.ContainsOnlyLetter());

            Console.WriteLine(name.CountChar('a'));

        }
    }
}
