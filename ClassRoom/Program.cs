using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassRoom classRoom = new ClassRoom("Q3", new DateTime(2019,8,26));


            Student s1 = new Student("Keits Buko", 11,23);
            Student s2 = new Student("Michael Reeves",5,31);

            classRoom.Class.Add(s1);
            classRoom.Class.Add(s2);

            Console.WriteLine(classRoom);
            foreach (Student student in classRoom.Class)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
