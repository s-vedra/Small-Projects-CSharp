using Enums;
using Models;
using Services.Interfaces;

namespace Services
{
    public class EmployeeService : IEmployeeServices
    {
        public void AssignStoreToEmployee()
        {

            foreach (Employee emp in DBUsers.employeeList)
            {
                if (emp.Id == 1 || emp.Id == 2 || emp.Id == 3)
                {
                    emp.WorkingStore = DBServices<Store>.AssignEntity(1, StoresDB.stores);
                }
                else if (emp.Id == 4 || emp.Id == 5 || emp.Id == 6)
                {
                    emp.WorkingStore = DBServices<Store>.AssignEntity(2, StoresDB.stores);
                }
                else if (emp.Id == 7 || emp.Id == 8)
                {
                    emp.WorkingStore = DBServices<Store>.AssignEntity(3, StoresDB.stores);
                }
                else
                {
                    emp.ManagingStores = new List<Store>()
                    {
                        DBServices<Store>.AssignEntity(1, StoresDB.stores),
                        DBServices<Store>.AssignEntity(2, StoresDB.stores),
                        DBServices<Store>.AssignEntity(3, StoresDB.stores)
                    };
                }
            }
        }
    }
}
