using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerManager(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Delete(Customer entity)
        {
            customerRepository.Delete(entity);
            unitOfWork.Save();
        }

        public List<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return customerRepository.GetById(id);
        }

        public void Insert(Customer entity)
        {
            customerRepository.Insert(entity);
            unitOfWork.Save();
        }

        public void MultiUpdate(List<Customer> entities)
        {
            customerRepository.MultiUpdate(entities);
            unitOfWork.Save();
        }

        public void Update(Customer entity)
        {
            customerRepository.Update(entity);
            unitOfWork.Save();
        }
    }
}
