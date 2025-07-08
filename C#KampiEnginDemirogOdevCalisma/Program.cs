
using C_KampiEnginDemirogOdevCalisma.Business;
using C_KampiEnginDemirogOdevCalisma.Entities;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("             Şahin Erol Çalışma Sayfasına Hoş Geldiniz...");

StudentsManager studentsManager = new ();
Student[] students = studentsManager.GetAll();

Console.WriteLine("     Döngüler");
Console.WriteLine("     ----------------- for döngüsü -----------------");
Console.WriteLine($"{" ", 5} {"ID",-5} {"StudentNameSurname",-20} {"StudentAge",-10}");
for (int i = 0; i < students.Length; i++)
{
    
    Console.WriteLine($"{" ",5} {students[i].StudentId, -5} {students[i].StudentNameSurname, -20} { students[i].StudentAge, -10}");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("     ----------------- foreach döngüsü  -----------------");
Console.WriteLine($"{" ",5} {"ID",-5} {"StudentNameSurname",-20} {"StudentAge",-10}");
foreach (Student student in students)
{
    
    Console.WriteLine($"{" ",5} {student.StudentId, -5} {student.StudentNameSurname, -20} {student.StudentAge, -10}");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("     ----------------- while döngüsü -----------------");
int j = 1;
Console.WriteLine($"{" ",5} {"ID",-5} {"StudentNameSurname",-20} {"StudentAge",-10}");
while (j < students.Length)
{
    
    Console.WriteLine($"{" ",5} {students[j].StudentId,-5} {students[j].StudentNameSurname,-20} {students[j].StudentAge,-10}");
    j++;
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("     ----------------- do...while döngüsü -----------------");
int k = 1;
Console.WriteLine($"{" ",5} {"ID",-5} {"StudentNameSurname",-20} {"StudentAge",-10}");
do
{
    
    Console.WriteLine($"{" ",5} {students[k].StudentId,-5} {students[k].StudentNameSurname,-20} {students[k].StudentAge,-10}");
    k++;
}
while ( k< students.Length);

