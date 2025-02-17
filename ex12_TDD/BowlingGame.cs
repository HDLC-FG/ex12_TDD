namespace ex12_TDD
{
    public class BowlingGame
    {
        private IList<int> lancers = new List<int>();

        public int GetScore()
        {
            var score = 0;

            int i = 0;
            for (int tour = 0; tour < 10; tour++)
            {
                if (lancers[i] == 10)
                {
                    score += 10 + lancers[i + 1] + lancers[i + 2];
                    i++;
                }
                else if (lancers[i] + lancers[i + 1] == 10)
                {
                    score += 10 + lancers[i + 2];
                    i += 2;
                }
                else
                {
                    score += lancers[i] + lancers[i + 1];
                    i += 2;
                }
            }

            return score;
        }

        public void Jouer(int pts)
        {
            lancers.Add(pts);
        }
    }
}
