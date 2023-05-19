using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly VtContext _context;

        public GenericRepository(VtContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            //_context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void MultiUpdate(List<T> entities)
        {
            _context.UpdateRange(entities);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            //_context.SaveChanges();
        }
    }
}
