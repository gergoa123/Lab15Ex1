using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15Ex1
{
    class Student
    {
        private Guid Id;
        private string Nume;
        private string Prenume;
        private int Varsta;
        private string Specializare;

        public Student(Guid id, string nume, string prenume, int varsta, string specializare)
        {
            Id1 = id;
            Nume1 = nume;
            Prenume1 = prenume;
            Varsta1 = varsta;
            Specializare1 = specializare;
        }

        public Guid Id1 { get => Id; set => Id = value; }
        public string Nume1 { get => Nume; set => Nume = value; }
        public string Prenume1 { get => Prenume; set => Prenume = value; }
        public int Varsta1 { get => Varsta; set => Varsta = value; }
        public string Specializare1 { get => Specializare; set => Specializare = value; }

        public override string ToString()
        {
            return "ID: " + Id1 + "\nNume: " + Nume1 + "\nPrenume: " + Prenume1 + "\nVarsta: " + Varsta1 + "\nSpecializare: " + Specializare1 + "\n";
        }
    }
}
