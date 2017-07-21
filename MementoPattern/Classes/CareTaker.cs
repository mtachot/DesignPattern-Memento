using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Classes
{
    public class CareTaker
    {
        private List<Memento> listMemento = new List<Memento>();

        public void Add(Memento state)
        {
            listMemento.Add(state);
        }

        public Memento Get(int index)
        {
            return listMemento.ElementAt(index);
        }
    }
}
