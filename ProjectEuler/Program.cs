using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of the task");
            string taskName =  "ProjectEuler." + Console.ReadLine();

            Type typeForTask = (Type.GetType(taskName));
            
            if (typeForTask != null && typeof(EulerTask).IsAssignableFrom(typeForTask))
            {
                EulerTask task = Activator.CreateInstance(typeForTask) as EulerTask;

                task.Run();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("That task couldn't be found");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
