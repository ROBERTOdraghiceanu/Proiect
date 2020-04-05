using System;
using System.Collections.Generic;
using System.Text;

namespace ClassImplementation.Interfaces
{
    public interface IModel<T>
    {
        IEnumerable<T> GetAll();
        T Add(T itemToAdd);
        T Update(T itemToUpdate);
        bool Delete(T itemToDelete);
    }
}
