using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Dé
    {
        #region Propriétés
        internal int Minimum { get; } 
        internal int Maximum { get; }
        #endregion
        #region Méthodes
        internal int Jetdedes (int mininum, int maximum)
        {
            Random random = new Random();
            int aleatoire = random.Next(mininum, maximum + 1);
            return aleatoire;
        }
        #endregion
    }
}
