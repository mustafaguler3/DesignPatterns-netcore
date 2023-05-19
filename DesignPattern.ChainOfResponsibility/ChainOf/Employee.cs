using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOf
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee superVisior)
        {
            this.NextApprover = superVisior;
        }

        public abstract void ProcessRequest(CustomerProccessViewModel req);
    }
}
