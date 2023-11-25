using Bowling;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstBowl()
        {
            var game = new Game();
            game.Bowl(3);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(3));
        }

        [Test]
        public void SecondBowl()
        {
            var game = new Game();
            game.Bowl(3);
            game.Bowl(1);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(4));
        }

        [Test]
        public void SecondFrame()
        {
            var game = new Game();
            game.Bowl(3);
            game.Bowl(1);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(4));
            game.Bowl(4);
            game.Bowl(2);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(4));
            Assert.That(game.CalculateScoreOfFrame(1), Is.EqualTo(10));
        }

        [Test]
        public void Spare()
        {
            var game = new Game();
            game.Bowl(3);
            game.Bowl(7);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(10));
            game.Bowl(4);
            game.Bowl(2);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(14));
            Assert.That(game.CalculateScoreOfFrame(1), Is.EqualTo(20));
        }

        [Test]
        public void Strike()
        {
            var game = new Game();
            game.Bowl(10);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(10));
            game.Bowl(4);
            game.Bowl(2);
            Assert.That(game.CalculateScoreOfFrame(0), Is.EqualTo(16));
            Assert.That(game.CalculateScoreOfFrame(1), Is.EqualTo(22));
        }

        [Test]
        public void Perfect()
        {
            var game = new Game();
            foreach (var i in Enumerable.Range(0, 12))
            {
                game.Bowl(10);
            }
            Assert.That(game.CalculateScoreOfFrame(9), Is.EqualTo(300));
        }
    }
}