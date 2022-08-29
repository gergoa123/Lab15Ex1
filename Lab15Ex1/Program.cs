using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab15Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(new Guid(),"Ion","Luca",22,"Informatica"),
                new Student(new Guid(),"Paul","Pop",20,"Informatica"),
                new Student(new Guid(),"Musso","Lini",21,"Litere"),
                new Student(new Guid(),"Fjodor","Dostojevskij",30,"Litere"),
                new Student(new Guid(),"Emilio","Bocanci",45,"Constructii"),
                new Student(new Guid(),"Antonio","Banderas",16,"Constructii")

            };

            // 1. Afisati cel mai in varsta student de la Informatica
            Student oldInfo = (from student in students
                               where student.Specializare1 == "Informatica"
                               orderby student.Varsta1
                               select student).Last<Student>();

            Console.WriteLine(oldInfo);

            // 2. Afisati cel mai tanar student
            //    • In mai multe moduri
            // Metoda a)
            Student youngestStudentA = (from student in students
                                       orderby student.Varsta1
                                       select student).First<Student>();

            Console.WriteLine("Youngest student = " + youngestStudentA);
            // Metoda b)
            var youngestStudentB = students.Min(student => student.Varsta1);

            Console.WriteLine("Youngest student = " + youngestStudentB);

            // 3. Afisati in ordine crescatoare a varstei toti, studentii de la litere.
            Console.WriteLine("Toti studentii de la Litere in ordinea crescatoare a varstei: ");
            foreach (Student student in students.OrderBy(s => s.Varsta1).Where(s => s.Specializare1 == "Litere"))
            {
                Console.WriteLine(student);
            }

            // 4. Afisati primul student de la constructii cu varsta de peste 20 de ani
            Student firstOldConstStud = (from student in students
                               where student.Specializare1 == "Constructii" && student.Varsta1 > 20
                               orderby student.Varsta1
                               select student).First<Student>();

            Console.WriteLine(firstOldConstStud);


            // 5. Afisati studentii avand varsta egala cu varsta medie a studentilor
            var avgStuds = from student in students
                           where student.Varsta1 == students.Average(s => s.Varsta1)
                           select student;
            Console.WriteLine("Studentii cu varsta egala cu varsta medie sunt : ");
            foreach(Student student in avgStuds) {
                Console.WriteLine(student);
            }

            // 6. Afisati, in ordinea descrescatoare a varstei, si in ordine alfabetica, dupa numele de
            // familie si dupa numele mic, toti studentii cu varsta cuprinsa intre 18 si 35 de ani
            Console.WriteLine("Studenti crescat. = ");
           
            var studentiDescVarsta = from student in students
                                  where student.Varsta1 >= 18 && student.Varsta1 <= 35
                                  orderby student.Varsta1
                                  select student;

            var studentiDescPrenume = from student in studentiDescVarsta
                                     orderby student.Prenume1
                                     select student;

            var studentiDescNume = from student in studentiDescPrenume
                                     orderby student.Nume1
                                     select student;

            foreach(Student s in studentiDescNume)
            {
                Console.WriteLine(s);
            }

            // 7. Afisati ultimul elev din lista folosind linq
            Student lastStudent = (from student in students                            
                               select student).Last<Student>();

            Console.WriteLine("Ultimul elev in lista este = " + lastStudent);

            // 8. Afisati mesajul “Exista si minori” daca in lista creeata exista si persone cu varsta mai mica de 18 ani.In caz contar afesati “Nu exista minori”
            if (students.Where(s => s.Varsta1 < 18).Count() > 0)
            {
                Console.WriteLine("Exista si minori");
            } else
            {
                Console.WriteLine("Nu exista minori");
            }
            

        }
    }
}
