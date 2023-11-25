using System.Collections;

namespace Bowling
{
    internal class Frame : IEnumerable<int>
    {
        private List<int> _breakCounts = new();

        public bool IsFull => _breakCounts.Count == 2 | IsStrike;

        public bool IsStrike => _breakCounts.Count == 1 & _breakCounts.Sum() == 10;

        public bool IsSpare => _breakCounts.Count == 2 & _breakCounts.Sum() == 10;

        public IEnumerator<int> GetEnumerator()
        {
            return _breakCounts.GetEnumerator();
        }

        internal void Bowl(int breakCount)
        {
            _breakCounts.Add(breakCount);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _breakCounts.GetEnumerator();
        }
    }
}