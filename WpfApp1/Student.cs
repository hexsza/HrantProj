using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFApp
{
    public class Student : IComparable<Student>
    {
        public Student(int id, string name, Gender gender)
        {
            StudentId = id;
            name = name;
            Gender = gender;

        }

        public int StudentId { get; private set; }

        public string Name { get; private set; }

        public Gender Gender { get; private set; }

        public int CopareTo(Student other)
        {
            return StudentId.CompareTo(other.StudentId);
        }

        public int CompareTo(Student? other)
        {
            throw new NotImplementedException();
        }
    }
}
