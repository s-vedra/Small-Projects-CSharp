using Enums;
using Models;
using Services;

ManagerServices managerService = new ManagerServices();
CustomerServices customerService = new CustomerServices();
UserServices userService = new UserServices();
EmployeeService employeeServices = new EmployeeService();
employeeServices.AssignStoreToEmployee();
StoreServices.OnChangePromotion += managerService.GetMessagePromotion;
StoreServices.OnChangePromotion += customerService.RecieveMessageOnPromotion;
StoreServices.OnRemove += managerService.GetMessageBought;
StoreServices.OnAdd += managerService.GetMessageAddProduct;
StoreServices.OnRemove += managerService.GetMessageRemoveProduct;
StoreServices.OnChangeEmployee += managerService.GetMessageAddedEmployee;

Store storeJobOffer = StoreServices.JobOffer(StoreServices.GetEmployeesCount(DBUsers.employeeList));
while (true)
{
    Console.WriteLine("1.Login \n2.See Job Offers");

    int answer = HelperMethods.CheckString().Parsing();
    switch (answer)
    {
        case 1:
            Console.Clear();
            Employee employee = userService.Login((user) => DBServices<Employee>.PrintSingular(user.GetInfo()));
            switch (employee.Role)
            {
                case Role.Salesman:
                    while (true)
                    {
                        
                        Console.WriteLine("1.Change current promotion \n2.Add more products \n3.Remove products \n4.Log Out");
                        int answerEmployee = HelperMethods.CheckString().Parsing();
                        switch (answerEmployee)
                        {
                            case 1:
                                Console.Clear();
                              
                                employee.WorkingStore.ChangeCurrentPromotion();
                             
                                customerService.BuyProducts(employee.WorkingStore, employee.WorkingStore.CurrentPromotion);
                                HelperMethods.MainMenu();
                                continue;
                            case 2:
                                Console.Clear();
                               
                                employee.WorkingStore.AddProducts();
                                HelperMethods.MainMenu();
                                continue;
                            case 3:
                                Console.Clear();
                                
                                employee.WorkingStore.RemoveProducts(StoreServices.ReturnProduct);
                                HelperMethods.MainMenu();
                                continue;
                            case 4:
                                break;
                            default:
                                continue;
                        }
                        break;
                    }
                    continue;
                case Role.Manager:
                    while (true)
                    {
                        Console.WriteLine("1.See Number of Employees of each store \n2.See Product statistics of each store \n3.Log Out");
                        int asnwerManager = HelperMethods.CheckString().Parsing();
                        switch (asnwerManager)
                        {
                            case 1:
                                Console.Clear();
                                StoreServices.OnGroupEmployees += managerService.GetMessageForEmployeeCount;
                                StoreServices.GetEmployeesCount(DBUsers.employeeList);
                                HelperMethods.MainMenu();
                                //Console.Clear();
                                continue;
                            case 2:
                                Console.Clear();
                                StoreServices.OnGroupProducts += managerService.GetMessageForProductCount;
                                StoreServices.GroupProducts();
                                HelperMethods.MainMenu();
                                continue;
                            case 3:
                                break;
                            default:
                                continue; 
                        }
                        break;
                    }
                    continue;
            }
            break;
        case 2:
            Console.Clear();
            if (!StoreServices.SetJobOffer(storeJobOffer))
            {
                continue;
            }
            else
            {
                Console.WriteLine("1.Accept Job Offer \n2.Go Back");
                int answerJobOffer = HelperMethods.CheckString().Parsing();
                switch (answerJobOffer)
                {
                    case 1:
                        Console.Clear();

                        StoreServices.AddNewEmployee(() => userService.AcceptJobOffer(StoreServices.JobOffer));
                        HelperMethods.MainMenu();
                        break;
                    case 2:
                        break;
                }
            }
            continue; 
        default:
            continue;
    }
    break;  
}






