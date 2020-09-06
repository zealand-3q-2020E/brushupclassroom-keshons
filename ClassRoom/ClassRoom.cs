using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        private List<Student> _class;

        public ClassRoom(string className, DateTime semesterStart)
        {
            _class = new List<Student>();
            ClassName = className;
            SemesterStart = semesterStart;
        }

        public string ClassName { get; set; }

        public List<Student> Class
        {
            get { return _class;}
            set { _class = value; }
        }
        public DateTime SemesterStart { get; set; }

        public override string ToString()
        {
            return "Class Name: " + ClassName + " Beginning of the semester: " + SemesterStart;
        }
    }
}
