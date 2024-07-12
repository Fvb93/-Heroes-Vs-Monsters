using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dé
    {
        #region Propriétés
        public int Minimum { get; }
        public int Maximum { get; }
        #endregion
        #region Méthodes
        public int Jetdedes (int mininum, int maximum)
        {
            Random random = new Random();
            int aleatoire = random.Next(mininum, maximum + 1);
            return aleatoire;
        }
        #endregion
    }
}
