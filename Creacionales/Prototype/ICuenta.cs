using System;
namespace Prototype
{
    public interface ICuenta : ICloneable
    {
        
         ICuenta clonar();

    }
}