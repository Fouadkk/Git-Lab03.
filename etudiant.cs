using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appconsoleheritage
{
    internal class Etudiant:Personne
    {
        public string NiveauEtude { get; set; }
        public Etudiant (string nom ,int age,string niveau):base(nom,age)
        {
            NiveauEtude = niveau;
        }
            
            public override void Afficherdetail() {
            Console.WriteLine($"Etudiant : {Nom},age {Age} ,niveau detudes :{NiveauEtude}");


        }
    }
}
