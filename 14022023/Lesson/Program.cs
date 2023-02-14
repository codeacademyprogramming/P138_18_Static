using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgrammingCourse course = new ProgrammingCourse();

            Group group1 = new Group();
            Group group2 = new Group();
            Group group3 = new Group();
            Group group4 = new Group();
            Group group5 = new Group();


            Console.WriteLine(group1.AvgPoint);
            Console.WriteLine(group2.AvgPoint);
            Console.WriteLine(group3.AvgPoint);

            Console.WriteLine(Group.Count);



            string opt;
            do
            {
                Console.WriteLine("1. Qrup elave et");
                Console.WriteLine("2. Qruplara bax");
                Console.WriteLine("0. Cix");

                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":

                       
                        string no;
                        do
                        {
                            Console.Write("No: ");
                            no = Console.ReadLine();
                        } while (!Group.CheckNo(no));
                       

                        //byte point=0;
                        //bool hasError = false;
                        //do
                        //{
                        //    Console.Write("AvgPoint: ");
                        //    try
                        //    {
                        //        point = Convert.ToByte(Console.ReadLine());
                        //        hasError = false;
                        //    }
                        //    catch (Exception)
                        //    {
                        //        hasError = true;
                        //    }

                        //} while (hasError);
                        byte point;
                        string pointStr;
                        do
                        {
                            Console.Write("AvgPoint: ");
                            pointStr = Console.ReadLine();

                        } while (!byte.TryParse(pointStr,out point) || point>100);
                       

                        Group group = new Group
                        {
                            AvgPoint = point,
                            No = no
                        };

                        course.AddGroup(group);
                        break;
                    case "2":
                        foreach (var item in course.Groups)
                        {
                            Console.WriteLine(item.No+" - "+item.AvgPoint);
                        }
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }

            } while (opt!="0");
        }

        //static bool CheckNo(string no)
        //{
        //    if (no == null)
        //        return false;

        //    if (no.Length != 4)
        //        return false;

        //    if (char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
        //        return true;

        //    return false;
        //}
    }
}
