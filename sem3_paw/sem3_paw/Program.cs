using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(123, 'M', 21, "Gigel",
                new int[3] { 7, 9, 10 });
            Student s3 = (Student)s2.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s3);
            s2.SpuneAnNastere();
            Console.WriteLine("A 2-a nota a lui s2 este: " + s2[1]);
            s3[2] = 5;
            s3 = s3 + 6;
            s3 += 8;
            s3++;
            Console.WriteLine(s3);

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach (Student s in listaStud)
                Console.WriteLine(s);
        }
    }
}
