using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTraining1
{
    class DescComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.Surname.CompareTo(x.Surname);
        }
    }
}
