using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoc
{
    internal class Person
    {

        private IMoyenDeDeplacement moyenDeDeplacement;

        public Person(string prenom, IMoyenDeDeplacement moyenDeDeplacement)
        {

            this.Prenom = prenom;
            this.moyenDeDeplacement = moyenDeDeplacement;
        }


        /* constructeur avant interfaces
        public Person(string prenom, velo velo, bus bus)
        {

            this.Prenom = prenom;
            this.velo = velo;
            this.bus = bus;
        }
        // séparer le quoi du comment : 
        // quoi, qu'est-ce que j'ai besoin ? Un moyen de déplacement
        // comment ? à travers le bus ou le vélo
        */


        public void AllerAuTravail(Destination destination)
        {
            // séparer le quoi du comment : 
            // quoi, qu'est-ce que j'ai besoin ? Un moyen de déplacement
            // comment ? à travers le bus ou le vélo
            Console.WriteLine($"{this.Prenom}, je vais ici : {destination.Adresse} ");

            //this.velo.Emmener(this, destination);
            //this.bus.Emmener(this, destination);
            this.moyenDeDeplacement.Emmener(this, destination);
        }
        public string Prenom { get; set; }
    }
}