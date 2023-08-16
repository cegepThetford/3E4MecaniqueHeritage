using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecaniqueHeritage_Affaires
{
    public class Premier
    {
        // corriger la visibilite de l'attribut
        private int _valeur1;
        public int Valeur1 { get { return _valeur1; } set { _valeur1 = value; } }

        public Premier(int v)
        {
            // completer
        }

        // completer la signature
        public int calculer()
        {
            // corriger le calcul
            return 0;
        }
    }
}
