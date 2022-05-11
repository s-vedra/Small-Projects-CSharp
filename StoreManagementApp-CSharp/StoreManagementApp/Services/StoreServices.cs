using Enums;
using Models;

namespace Services
{
    public static class StoreServices
    {
        public delegate Employee ReturnEmployee();
        public delegate void EventHandle(Product product, Store store);
        public delegate void EventHandleEmployee(Employee seller);
        public delegate void EventHandleGroupingProducts(Dictionary<Product, int> grouped);
        public delegate Product ReturnProductHandler();
        public static event EventHandleEmployee OnChangeEmployee;
        public static event EventHandle OnChangePromotion;
        public static event EventHandle OnAdd;
        public static event EventHandle OnRemove;
        public static event EventHandleGroupingProducts OnGroupProducts;
        public static event DBServices<Store>.EventHandleGroupingEmployees OnGroupEmployees;
        private static LoggingServices loggingServices = new LoggingServices();
        public static Product ReturnProduct()
        {
            while (true)
            {
                try
                {
                    HelperMethods.ListProducts();
                    Console.WriteLine("Enter product ID: ");
                    int product = HelperMethods.CheckString().Parsing();
                    if (product == 0 || product > 7)
                    {
                        throw new Exception("Bad Request, please enter product ID");
                    }
                    else
                    {
                        Product prod = (Product)product;
                        return prod;
                    }
                }
                catch (Exception msg)
                {
                    loggingServices.LogError($"{msg.Message} {msg.StackTrace}");
                    loggingServices.ReadError();
                    continue;
                }
            }
        }
        public static void AddProducts(this Store store)
        {
            Product product = ReturnProduct();
            store.Products.Add(product);
            if (OnAdd != null)
            {
                Console.WriteLine("Sending message...");
                Thread.Sleep(3000);
                OnAdd.Invoke(product, store);
            }
        }
        public static void RemoveProducts(this Store store, ReturnProductHandler removedProduct)
        {
            Product product = removedProduct();
            store.Products.Remove(product);
            if (OnRemove != null)
            {
                Console.WriteLine("Sending message...");
                Thread.Sleep(3000);
                OnRemove.Invoke(product, store);
            }
        }

        public static void AddNewEmployee(ReturnEmployee employee)
        {
            Employee seller = employee();
            DBUsers.employeeList.Add(seller);
            if (OnChangeEmployee != null)
            {
                Console.WriteLine("Sending message...");
                Thread.Sleep(3000);
                OnChangeEmployee.Invoke(seller);
            }
        }
        public static void ChangeCurrentPromotion(this Store store)
        {
            Console.WriteLine($"The current product {store.CurrentPromotion} is on promotion");
            Product productForPromotion = ReturnProduct();
            if (store.CurrentPromotion == productForPromotion)
            {
                Console.WriteLine("That product is already on promotion");
            }
            else
            {
                store.CurrentPromotion = productForPromotion;
                if (OnChangePromotion != null)
                {
                    Console.WriteLine("Sending message...");
                    Thread.Sleep(3000);
                    OnChangePromotion.Invoke(store.CurrentPromotion, store);

                }
            }
            
        }
        //get the number of products in each store
        public static void GroupProducts()
        {
            Store store = DBServices<Store>.ReturnEntity(StoresDB.stores);
            Dictionary<Product, int> groupedProducts = store.Products
                .GroupBy(product => product).Select(product => new { Key = product.Key, Product = product.Count() })
                .Select(product => product).ToDictionary(product => product.Key, product => product.Product);
            if (OnGroupProducts != null)
            {
                OnGroupProducts.Invoke(groupedProducts);
            }
        }

        //get the number of employees in each store
        public static Dictionary<Store,int> GetEmployeesCount(List<Employee> employees)
        {
            Dictionary<Store, int> groupedEmployees = employees.Where(employee => employee.WorkingStore != null)
                .GroupBy(employee => employee.WorkingStore).Select(store => new { Key = store.Key, Number = store.Count() })
                  .Select(store => store).ToDictionary(store => store.Key, store => store.Number);
            if (OnGroupEmployees != null)
            {
                OnGroupEmployees.Invoke(groupedEmployees);
            }
            return groupedEmployees;
        }
        public static Store JobOffer(Dictionary<Store, int> grouped)
        {
            return grouped.SingleOrDefault(store => store.Value <= 2).Key;
        }

        public static bool SetJobOffer(Store storeJobOffer)
        {
            Dictionary<Store, int> grouped = GetEmployeesCount(DBUsers.employeeList);
           bool workers = grouped.Select(store => store.Value).All(store => store == 3);
            if (workers == true)
            {
                Console.WriteLine("Currently there aren't any job offers");
                return false;
            }
            else
            {
                Console.WriteLine($"There is a job offer for Salesman in {storeJobOffer.Name}");
                return true;
            }
        }
    }
}
