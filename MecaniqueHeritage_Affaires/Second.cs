using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecaniqueHeritage_Affaires
{
    // ajouter l'heritage
    public class Second
    {
        // corriger la visibilite de l'attribut
        private int _valeur2;
        public int Valeur2 { get { return _valeur2; } set { _valeur2 = value; } }

        // completer la signature du constructeur
        public Second(int v1, int v2)
        {
            // completer
        }

        // completer la signature de la methode
        public int calculer()
        {
            // faire le premier calcul
            return 0;
        }
    }
}
