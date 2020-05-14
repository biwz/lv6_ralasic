using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv6_Ralasic
{
    class CareTaker
    {
        private List<Memento> history;

        public CareTaker() { this.history = new List<Memento>(); }
        public CareTaker(List<Memento> history)
        {
            this.history = history;
        }
        public void Store(Memento state)
        {
            this.history.Add(state);
        }
        public void RemoveLast()
        {
            this.history.RemoveAt(this.history.Count - 1);
        }
        public Memento PreviousState()
        {
            Console.WriteLine(this.history.Count);
            if (history.Count == 0)
            {
                throw new Exception("Empty history");
            }
            Memento last = this.history[this.history.Count - 1];
            RemoveLast();
            return last;
        }
    }
}
