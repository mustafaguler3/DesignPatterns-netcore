using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOf
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProccessViewModel req)
        {
            VtContext context = new VtContext();
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Hakan";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Hakan";
                customerProcess.Description = "Para çekme tutarı şube müdür yardımcısının günlük ödeyebileceği limiti aştığı için işem şube müdürüne yönlendirildi";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
