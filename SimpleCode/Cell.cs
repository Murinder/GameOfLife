using System;

namespace SimpleCode
{
    public class Cell
    {
        public string Stage = "Empty";
        private int starve = 0;
        private int age = 0;
        public Cell(string stage = "Empty")
        {
            Stage = stage;
        }
        public void StarveUp()
        {
            starve++;
        }
        public void AgeUp()
        {
            age++;
        }
        public int KnowAge()
        {
            int a = age;
            return a;
        }
        public void IsDead()
        {
            Random rnd = new Random();
            if (age > Probability.AgeCell || (starve == Probability.Starve && Stage != "Plant"))
            {
                Stage = rnd.Next(100 - Probability.Decomposition) == 0 ? "Plant" : "Empty";
                StarveNull();
                AgeNull();
            }
        }
        public void StarveNull()
        {
            starve = 0;
        }
        public void AgeNull()
        {
            age = 0;
        }
        public bool IsEatable()
        {
            if(Stage == "Plant" && starve > Probability.GrowthTime)
            {
                return true;
            }
            return false;
        }
    }
}
