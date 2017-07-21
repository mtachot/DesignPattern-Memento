using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Classes
{
    public class Originator
    {
        private string state;
        public void setState(string state)
        {
            this.state = state;
        }

        public string getState()
        {
            return this.state;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(this.state);
        }

        public void getStateFromMemento(Memento memento)
        {
            this.state = memento.getState();
        }
    }
}
