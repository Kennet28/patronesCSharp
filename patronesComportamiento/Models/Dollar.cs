using patronesComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesComportamiento.Models
{
    public class Dollar : IDollar
    {
        private List<IUserObserver> _users;

        public Dollar(string name, double price)
        {
            _users = new List<IUserObserver>();
            Name = name;
            _price = price;

        }
        public string Name { get; set; }
        private double _price { get; set; }

        public double Price
        {
            get { return _price; }
            set 
            {
                _price = value;
                this.Notify();
            }
        }
        //override toString
        public override string ToString()
        {
            return $"{Name}: ${_price}";
        }
        public void Add(IUserObserver user)
        {
            if (!_users.Contains(user))
                _users.Add(user);
            else
                throw new Exception($"Ya existe una subscripcion para {((User)user)}");
        }

        public void Notify()
        {
            foreach (var user in _users) 
                user.Update(this);
            //TODO: implements
            //if (_users.Count == 0)
                
        }

        public void Remove(IUserObserver user)
        {
            if (_users.Contains(user))
                _users.Remove(user);
            else
                throw new Exception($"No existe una subscripcion para {((User)user)}");

        }
    }
}
