
namespace Bowling
{
    public class Game
    {
        private Frames _frames = new();

        public Game()
        {
        }

        public void Bowl(int breakCount)
        {
            _frames.Bowl(breakCount);
        }

        public int CalculateScoreOfFrame(int frameIndex)
        {
            return Scorer.CalculateScoreOfFrame(_frames, frameIndex);
        }
    }
}