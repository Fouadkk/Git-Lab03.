using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appconsoleheritage
{
    internal class Personne
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }
        public virtual void Afficherdetail()
        {
            Console.WriteLine($"Mon nom est {Nom} et Mon age {Age}");

        }
    }
}



