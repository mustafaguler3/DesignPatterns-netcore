using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
        void MultiUpdate(List<T> entities);
    }
}
