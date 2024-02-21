using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoc
{
    internal class VoitureElectrique : IMoyenDeDeplacement
    {
        public void Emmener(Person person, Destination destination) 
        {
            Console.WriteLine("plus de batterie");
        }
    }
}
