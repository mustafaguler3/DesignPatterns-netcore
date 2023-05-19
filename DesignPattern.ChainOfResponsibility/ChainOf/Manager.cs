using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOf
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProccessViewModel req)
        {
            VtContext context = new VtContext();
            if (req.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Mustafa";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Mustafa";
                customerProcess.Description = "Para çekme tutarı şube müdürünün günlük ödeyebileceği limiti aştığı için işlem bölge müdürüne yönlendirildi";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
