using Enums;

namespace Models
{
    public static class DBUsers
    {
        public static List<Customer> customerList = new List<Customer>()
        {
            new Customer(1, "Bob", "Bobsky", Product.CPU),
            new Customer(2, "Ana", "Ansky", Product.Motherboard),
            new Customer(3, "Jill", "Jillsky", Product.Coolers),
            new Customer(4, "Emily", "Bwern",  Product.GPU),
            new Customer(5, "Jack", "Jacksky",  Product.CPU),
            new Customer(6, "David", "Davisky", Product.GPU),
            new Customer(7, "Johnny", "Johnnsky", Product.RAM),
            new Customer(8, "Ned", "Nedsky", Product.Peripherals),
            new Customer(9, "Rachel", "Rae", Product.GPU),
            new Customer(10,"April", "Rae", Product.RAM)
        };

        public static List<Employee> employeeList = new List<Employee>()
        {
            new Employee(1, Role.Salesman,"JimJimsky", "jimJimsky12345"),
            new Employee(2, Role.Salesman,"KatieBrook", "katieBrook12345"),
            new Employee(3, Role.Salesman,"JoshBrook", "joshBrook12345"),
            new Employee(4, Role.Salesman,"TimTimsky","timTimsky12345"),
            new Employee(5, Role.Salesman,"LaurenRandolff", "laurenRandolff12345"),
            new Employee(6, Role.Salesman,"JimmyJimmsky","jimmyJimmsky12345"),
            new Employee(7, Role.Salesman,"GregoryRandolff", "gregoryRandolff12345"),
            new Employee(8, Role.Salesman,"JeffJeffsky","jeffJeffsky12345"),
            new Employee(9, Role.Manager, "LucyHale", "lucyHale12345"),
            new Employee(10, Role.Manager, "PoppyJames", "poppyJames12345"),

        };

    }
};
