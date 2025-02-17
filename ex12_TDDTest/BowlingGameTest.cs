using ex12_TDD;

namespace ex12_TDDTest
{
    [TestClass]
    public sealed class BowlingGameTest
    {
        [TestMethod]
        public void Constructor()
        {
            var bowlingGame = new BowlingGame();

            Assert.IsNotNull(bowlingGame);
        }

        [TestMethod]
        public void Play_All0Pts_0Points()
        {
            var bowlingGame = new BowlingGame();
            
            Lancers(bowlingGame, 20, 0);

            var score = bowlingGame.GetScore();

            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void Play_All1Pts_20Points()
        {
            var bowlingGame = new BowlingGame();

            Lancers(bowlingGame, 20, 1);

            var score = bowlingGame.GetScore();

            Assert.AreEqual(20, score);
        }

        [TestMethod]
        public void Play_1Spare_13Points()
        {
            var bowlingGame = new BowlingGame();
            bowlingGame.Jouer(8);
            bowlingGame.Jouer(2);
            bowlingGame.Jouer(3);

            Lancers(bowlingGame, 17, 0);

            var score = bowlingGame.GetScore();

            Assert.AreEqual(16, score);
        }

        [TestMethod]
        public void Play_1Strike_24Points()
        {
            var bowlingGame = new BowlingGame();
            bowlingGame.Jouer(10);
            bowlingGame.Jouer(4);
            bowlingGame.Jouer(3);

            Lancers(bowlingGame, 16, 0);

            var score = bowlingGame.GetScore();

            Assert.AreEqual(24, score);
        }

        [TestMethod]
        public void Play_AllSpare_150Points()
        {
            var bowlingGame = new BowlingGame();

            Lancers(bowlingGame, 21, 5);

            var score = bowlingGame.GetScore();

            Assert.AreEqual(150, score);
        }

        [TestMethod]
        public void Play_AllStrike_150Points()
        {
            var bowlingGame = new BowlingGame();

            Lancers(bowlingGame, 22, 10);

            var score = bowlingGame.GetScore();

            Assert.AreEqual(300, score);
        }

        private void Lancers(BowlingGame bowlingGame, int nb, int quilles)
        {
            for (int i = 0; i < nb; i++)
            {
                bowlingGame.Jouer(quilles);
            }
        }
    }
}
