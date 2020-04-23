using System;
using System.Security.Cryptography.X509Certificates;

namespace RPPOON_lv3
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCsv("TestId", "test", "10", "TestCsv.txt");
            Dataset file = new Dataset("TestCsv.txt");
            file.Clone();
            double[][] matrix = MatrixGenerator.GetInstance().GenerateMatrix(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i][j].ToString() + " ");
                }
                Console.WriteLine();
            }
            Logger logger = new Logger();
            logger.GetInstance().SetFileName("file.txt");
            logger.GetInstance().LogToFile("okej");
            ConsoleNotification notification = new ConsoleNotification("Stjepan", "Student", "txt", DateTime.Now, Category.INFO, ConsoleColor.White);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
            NotificationDirector director = new NotificationDirector();

            ConsoleNotification sample = director.CreateERRORNotification("Stjepan");
            ConsoleNotification sample0 = director.CreateINFONotification("Stjepan");
            ConsoleNotification sample1 = director.CreateALERTNotification("Stjepan");

        }
        public static void CreateCsv(string ID, string name, string age, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(ID + "," + name + "," + age);
                }
            }
            catch(Exception ex)
            {
                throw new AccessViolationException("This doesn't work:", ex);
            }
        }

    }
}
