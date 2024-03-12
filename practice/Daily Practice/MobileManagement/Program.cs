namespace MobileManagement
{
    enum Choice
    {
        add_mobile=1,
        viewAll,
        searchByPrice,
        searchByManufacturer,
        viewByPrice,
        Remove,
        Exit

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Choice choice = 0;
            Mobile mobile=new Mobile();
            MobileException e=new MobileException();
            do
            {
                try
                {
                    Console.WriteLine("Enter the option\n" +
                        "1.Add Mobile\n" +
                        "2.View All Mobile\n" +
                        "3.Search bY Price\n" +
                        "4.Search bY Manufacturer\n" +
                        "5.View by Price\n" +
                        "6.Remove\n" +
                        "7.Exit");
                    choice = (Choice)Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case Choice.add_mobile:
                            try
                            {
                                GetDetails();
                                e.MException(mobile);
                                var count = mobile.AddMobile();
                                if (count > 0)
                                {
                                    Console.WriteLine("Alredy exist");
                                }
                                else
                                {
                                    Console.WriteLine("Mobile added successfully");
                                }
                            }
                            catch (MobileValidation ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        case Choice.viewAll:
                            var newList = mobile.ViewAllMobiles();
                            if (newList.Count > 0)
                            {
                                foreach (var item in newList)
                                {
                                    Console.WriteLine($"Mobile_id:{item.id}\n" +
                                        $"Name:{item.Name}\n" +
                                        $"Description:{item.Description}\n" +
                                        $"Manufacturer:{item.ManufacturedBy}\n" +
                                        $"Price:{item.price}");

                                }

                            }
                            else
                            {
                                Console.WriteLine("No record found");
                            }
                            break;
                        case Choice.searchByPrice:
                            var priceList = mobile.SearchByPrice();
                            if (priceList.Count > 0)
                            {
                                string file = @"C:\\VS2022Assignments\\Textfile1.txt";
                                using (StreamWriter writer = new StreamWriter(file))

                                    foreach (var item in priceList)
                                    {
                                        writer.WriteLine($"Mobile_id:{item.id}\n" +
                                            $"Name:{item.Name}\n" +
                                            $"Description:{item.Description}\n" +
                                            $"Manufacturer:{item.ManufacturedBy}\n" +
                                            $"Price:{item.price}");

                                    }

                            }
                            else
                            {
                                Console.WriteLine("No record Found");
                            }
                            break;
                        case Choice.searchByManufacturer:
                            Console.WriteLine("Enter the name to search:");
                            mobile.SearchElement = Console.ReadLine();
                            var newCount = mobile.SearchByManufacturer();
                            if (newCount.Count > 0)
                            {
                                string file = @"C:\Users\249211\Desktop\dotnet\practice\Daily Practice\MobileManagement\file2.txt";
                                using(StreamWriter writer = new StreamWriter(file))
                                foreach (var item in newCount)
                                {
                                    writer.WriteLine($"Mobile_id:{item.id}\n" +
                                        $"Name:{item.Name}\n" +
                                        $"Description:{item.Description}\n" +
                                        $"Manufacturer:{item.ManufacturedBy}\n" +
                                        $"Price:{item.price}");

                                }
                            }
                            else
                            {
                                Console.WriteLine("No record found");
                            }
                            break;
                        case Choice.viewByPrice:
                            var viewList = mobile.ViewByPrice();
                            if (viewList.Count > 0)
                            {
                                foreach (var item in viewList)
                                {
                                    Console.WriteLine($"Mobile_id:{item.id}\n" +
                                        $"Name:{item.Name}\n" +
                                        $"Description:{item.Description}\n" +
                                        $"Manufacturer:{item.ManufacturedBy}\n" +
                                        $"Price:{item.price}");

                                }
                            }
                            else
                            {
                                Console.WriteLine("No record found");
                            }
                            break;
                        case Choice.Remove:
                            var removeCount = mobile.RemoveMobile();
                            if (removeCount == 0)
                            {
                                Console.WriteLine("Nothing to delete");
                            }
                            else
                            {
                                Console.WriteLine("Deleted susccessfully");
                            }
                            break;
                        case Choice.Exit:break;

                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (choice !=Choice.Exit);
            void GetDetails()
            {
                Console.Write("Enter the Name:");
                mobile.Name = Console.ReadLine();
                Console.Write("Enter the Description");
                mobile.Description = Console.ReadLine();
                Console.Write("Enter the manufacturer");
                mobile.ManufacturedBy = Console.ReadLine();
                Console.Write("Enter the price");
                bool IsPrice=double.TryParse(Console.ReadLine(), out var result);
                if(IsPrice)
                {
                    mobile.price = result;
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }


            }

        }

    }
}