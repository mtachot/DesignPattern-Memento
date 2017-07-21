using MementoPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker caretaker = new CareTaker();

            originator.setState("State #1");
            originator.setState("State #2");
            caretaker.Add(originator.saveStateToMemento());

            originator.setState("State #3");
            caretaker.Add(originator.saveStateToMemento());

            originator.setState("State #4");
            Console.WriteLine(String.Format("Current state: {0}", originator.getState()));

            originator.getStateFromMemento(caretaker.Get(0));
            Console.WriteLine(String.Format("First saved state: {0}", originator.getState()));
            originator.getStateFromMemento(caretaker.Get(1));
            Console.WriteLine(String.Format("Second saved state: {0}", originator.getState()));

            Console.ReadLine();
        }
    }
}
