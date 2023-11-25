



namespace Bowling
{
    internal class Scorer
    {
        internal static int CalculateScoreOfFrame(Frames frames, int frameIndex)
        {
            return Base(frames, frameIndex) + Bonus(frames, frameIndex);
        }

        private static int Bonus(Frames frames, int frameIndex)
        {
            return frames.Take(frameIndex + 1).Select(f => BonusOfEachFrame(f, frames)).Sum();
        }

        private static int BonusOfEachFrame(Frame target, Frames frames)
        {
            return frames.SkipWhile(f => f != target).Skip(1).SelectMany(f => f).Take(GetBonusCount(target)).Sum();
        }

        private static int GetBonusCount(Frame target)
        {
            if (target.IsSpare) return 1;
            if (target.IsStrike) return 2;
            return 0;
        }

        private static int Base(Frames frames, int frameIndex)
        {
            return frames.Take(frameIndex + 1).SelectMany(f => f).Sum();
        }
    }
}