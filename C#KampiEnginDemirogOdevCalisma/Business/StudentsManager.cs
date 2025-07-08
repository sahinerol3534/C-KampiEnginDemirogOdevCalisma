using C_KampiEnginDemirogOdevCalisma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_KampiEnginDemirogOdevCalisma.Business;

public class StudentsManager
{    
    Student[] students = new Student[8];
    public StudentsManager()
    {
       Student student1 = new Student();
        student1.StudentId = 1;
        student1.StudentNameSurname = "Ali Can";
        student1.StudentAge = 10;

        Student student2 = new Student();
        student2.StudentId = 2;
        student2.StudentNameSurname = "Ahmet Sert";
        student2.StudentAge = 12;

        Student student3 = new Student();
        student3.StudentId = 3;
        student3.StudentNameSurname = "Berk Taş";
        student3.StudentAge = 13;

        Student student4 = new Student();
        student4.StudentId = 4;
        student4.StudentNameSurname = "Can Dost";
        student4.StudentAge = 14;

        Student student5 = new Student();
        student5.StudentId = 5;
        student5.StudentNameSurname = "Cuneyt Al";
        student5.StudentAge = 15;

        Student student6 = new Student();
        student6.StudentId = 6;
        student6.StudentNameSurname = "Deniz Mavi";
        student6.StudentAge = 16;

        Student student7 = new Student();
        student7.StudentId = 7;
        student7.StudentNameSurname = "Dun Dar";
        student7.StudentAge = 17;

        Student student8 = new Student();
        student8.StudentId = 8;
        student8.StudentNameSurname = "Esma Serik";
        student8.StudentAge = 18;
        students[0] = student1;
        students[1] = student2;
        students[2] = student3;
        students[3] = student4;
        students[4] = student5;
        students[5] = student6;
        students[6] = student7;
        students[7] = student8;
        

    }

    public Student[] GetAll()
    {
        return students;
    }

}
