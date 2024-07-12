namespace Models
{
    public class Personnage
    {
        #region Propriétés
        public virtual int Endurance { get; set; }
        public virtual int Force { get; set; }
        public virtual int PointsDeVie { get; set; }
        public virtual int Or { get; set; }
        public virtual int Cuir { get; set; }
        #endregion
        #region Méthodes
        public virtual void CreationPersonnage()
        {
            Endurance = CalculForceouEndu();
            Force = CalculForceouEndu();
            int modificateur = Modificateur(Endurance);
            
            PointsDeVie = Endurance + modificateur;
        }
        private static int CalculForceouEndu()
        {
            List<int> ListLancer = new List<int>();
            Dé d = new Dé();

            for (int jetdedes = 1; jetdedes <= 4; jetdedes++)
            {
                int lancer = d.Jetdedes(1, 6);
                ListLancer.Add(lancer);
            }
            
            int lancermin = ListLancer.Min();
            ListLancer.Remove(lancermin);

            int totalpoints = ListLancer.Sum();   // Si pas de Linq, faire une boucle
            return totalpoints;
        }
        private static int Modificateur(int attribut)
        {
            int modificateur = 0;
            if (attribut < 5)
            {
                modificateur = -1;
            }
            else if (attribut < 10)
            {
                modificateur = 0;
            }
            else if (attribut < 15)
            {
                modificateur = 1;
            }
            else
            {
                modificateur = 2;
            }
            return modificateur;
        }
        public int Frappe()
        {
            Dé d = new Dé();
            int modificateur = Modificateur(Force);
            int degat = d.Jetdedes(1, 4) + modificateur;
            return degat;
        }
        public void RecevoirDegat (int degat)
        {
            PointsDeVie -= degat;      
        }
        #endregion
    }

}
