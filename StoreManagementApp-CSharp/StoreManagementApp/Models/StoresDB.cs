using Enums;

namespace Models
{
    public static class StoresDB
    {
        public static List<Store> stores = new List<Store>()
        {
            new Store(1, "Anhoch", Product.CPU)
            {
                Products = new List<Product>()
                {
                    Product.CPU,
                    Product.CPU,
                    Product.CPU,
                    Product.CPU,
                    Product.CPU,
                    Product.Motherboard,
                    Product.Motherboard,
                    Product.Motherboard,
                    Product.Motherboard,
                    Product.Coolers,
                    Product.Coolers,
                    Product.Coolers,
                    Product.Coolers,
                    Product.GPU,
                    Product.GPU,
                    Product.PSU,
                    Product.PSU,
                    Product.PSU,
                    Product.RAM,
                    Product.RAM,
                    Product.RAM,
                    Product.RAM,
                    Product.RAM,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                }
            },
            new Store(2, "Neptun", Product.Peripherals)
            {
                Products = new List<Product>()
                {
                    Product.CPU,
                    Product.CPU,
                    Product.Motherboard,
                    Product.Motherboard,
                    Product.Coolers,
                    Product.Coolers,
                    Product.Coolers,
                    Product.Coolers,
                    Product.GPU,
                    Product.GPU,
                    Product.PSU,
                    Product.PSU,
                    Product.PSU,
                    Product.RAM,
                    Product.RAM,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                }
            },
            new Store(3, "Setec", Product.Motherboard)
            {
                Products = new List<Product>()
                {
                    Product.CPU,
                    Product.CPU,
                    Product.Motherboard,
                    Product.Motherboard,
                    Product.Motherboard,
                    Product.Motherboard,
                    Product.Coolers,
                    Product.Coolers,
                    Product.Coolers,
                    Product.Coolers,
                    Product.GPU,
                    Product.GPU,
                    Product.PSU,
                    Product.PSU,
                    Product.PSU,
                    Product.RAM,
                    Product.RAM,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                    Product.Peripherals,
                }
            }
        };
    }
}
