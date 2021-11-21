using patronesComportamiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesComportamiento.Interfaces
{
    public interface IUserObserver
    {
        void Update(Dollar dollar);
    }
}
