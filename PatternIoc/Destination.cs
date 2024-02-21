using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoc
{
    internal class Destination
    {

        public Destination(string adresse)
        {
            this.Adresse = adresse;
        }
        public string Adresse { get; set; }
    }
}
