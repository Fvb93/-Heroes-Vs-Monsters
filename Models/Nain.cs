using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Nain : Personnage
    {
        #region Propriétés
        public override int Endurance
        {
            get
            {
                return base.Endurance;
            }
            set
            {
                base.Endurance = value;
            }
        }
        public override int Force
        {
            get
            {
                return base.Force;
            }
            set
            {
                base.Force = value;
            }
        }
        public override int PointsDeVie
        {
            get
            {
                return base.PointsDeVie;
            }
            set
            {
                base.PointsDeVie = value;
            }
        }
        #endregion 
        #region Méthodes
        public override void CreationPersonnage()
        {
            base.CreationPersonnage();
            Endurance += 2;
        }
        #endregion
    }
}
