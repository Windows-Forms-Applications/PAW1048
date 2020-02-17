﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem1_paw
{
    class Student
    {
        int cod;
        private string nume;
        public int varsta;
        protected float medie;

        public Student()
        {
            cod = 0;
            nume = "Anonim";
            varsta = 0;
            medie = 0.0f;
        }

        public Student(int c, string n, int v, float m)
        {
            this.cod = c;
            nume = n;
            varsta = v;
            medie = m;
        }

        public Student(Student s)
        {
            cod = s.cod;
            nume = s.nume;
            varsta = s.varsta;
            medie = s.medie;
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} are codul {1}, varsta {2} si media {3}",
                nume, cod, varsta, medie);
        }
    }
}
