using patronesComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesComportamiento.Models
{
    public class Number
    {
        private List<IObserver> _observers;
        private int _state;

        public Number() => _observers = new List<IObserver>();
        public void add(IObserver o)
        {
            _observers.Add(o);
        }

        public int getState()
        {
            return _state;
        }

        public void setState(int value)
        {
            this._state = value;
            execute();
        }

        private void execute()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
