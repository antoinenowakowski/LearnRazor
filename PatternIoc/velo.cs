using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoc
{
    internal class velo : IMoyenDeDeplacement
    {
        public void Emmener(Person person, Destination destination)
        {
            Console.WriteLine($"moi vélo, j'emmène la personne {person.Prenom} ici {destination.Adresse}");
        }

    }
}