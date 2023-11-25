
using System.Collections;

namespace Bowling
{
    internal class Frames : IEnumerable<Frame>
    {
        private List<Frame> _frames = new List<Frame>() { new() };
        public IEnumerator<Frame> GetEnumerator()
        {
            return _frames.GetEnumerator();
        }

        internal void Bowl(int breakCount)
        {
            var last = GetLastNonFullFrame();
            last.Bowl(breakCount);
        }

        private Frame GetLastNonFullFrame()
        {
            var last = _frames.Last();
            if (!last.IsFull) return last;
            var newFrame = new Frame();
            _frames.Add(newFrame);
            return newFrame;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _frames.GetEnumerator();
        }
    }
}