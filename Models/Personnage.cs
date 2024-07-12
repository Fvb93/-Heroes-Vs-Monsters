namespace Models
{
    public class Personnage
    {
        #region Propriétés
        public int Endurance { get; set; }
        public int Force { get; set; }
        public int PointsDeVie { get; set; }
        #endregion
        #region Méthodes
        public void CreationPersonnage()
        {
            Endurance = CalculForceouEndu();
            Force = CalculForceouEndu();

            int modificateur = 0;
            if (Endurance < 5)
            {
                modificateur = -1;
            }
            else if (Endurance < 10)
            {
                modificateur = 0;
            }
            else if (Endurance < 15)
            {
                modificateur = 1;
            }
            else
            {
                modificateur = 2;
            }
            PointsDeVie = Endurance + modificateur;
        }
        private int CalculForceouEndu(Dé d)
        {
            List<int> ListLancer = new List<int>();

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
        public int Frappe()
        {
            int degat = 0;

            return degat;
        }
        #endregion
    }

}
