    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesComportamiento.Interfaces
{
    public interface IDollar
    {
        void Add(IUserObserver user);
        void Remove(IUserObserver user);
        void Notify();
    }
}
