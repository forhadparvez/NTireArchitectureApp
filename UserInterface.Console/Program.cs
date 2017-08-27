
using Core.Library;
using ManagerLibrary;

namespace UserInterface.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, regNo;

            var studentManager = new StudentManager();
            System.Console.WriteLine("Enter Studet Name and Reg No:\n");
            // get input from console
            System.Console.Write("Name: ");
            name = System.Console.ReadLine();
            System.Console.Write("Reg No: ");
            regNo = System.Console.ReadLine();

            bool isRegNoExist = studentManager.IsRegNoExist(regNo);
            if (isRegNoExist)
            {
                System.Console.WriteLine("\nThis Reg No Alredy Exist");
            }
            else
            {
                var aStudent = new Student();
                aStudent.Name = name;
                aStudent.RegNo = regNo;

                int successCount = studentManager.Save(aStudent);
                if (successCount > 0)
                {
                    System.Console.WriteLine("\nSave Success");
                }
                else
                {
                    System.Console.WriteLine("\nSave Fail");
                }
            }

            System.Console.ReadLine();
        }
    }
}
