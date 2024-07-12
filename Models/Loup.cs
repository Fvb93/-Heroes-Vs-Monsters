﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Loup : Personnage
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
        public override int Cuir { get; set; }
        #endregion
        #region Méthodes
        public override void CreationPersonnage()
        {
            base.CreationPersonnage();
            Dé d = new Dé();
            Cuir = d.Jetdedes(1,4);
        }
        #endregion
    }
}
