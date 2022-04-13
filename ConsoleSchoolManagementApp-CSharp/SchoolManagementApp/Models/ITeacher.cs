using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ITeacher
    {
        void SortStudents();
        float ReturnMaxAverageMajor(Major name);
        void BestAverageStudents();
        Student SearchStudent(int index);

    }
}
