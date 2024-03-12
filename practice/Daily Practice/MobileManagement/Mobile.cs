using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement
{
    internal class Mobile
    {
        public int id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ManufacturedBy { get; set; }

        public double price{ get; set; }

        public string SearchElement { get; set; }

        static List<Mobile> Mobilelist = new List<Mobile>();  

        public int AddMobile()
        {
           id=Mobilelist.Count==0?1:Mobilelist.Max(x => x.id)+1;
           var count=Mobilelist.Count(mname => mname.Name==Name &&mname.ManufacturedBy==ManufacturedBy); 
            if(count==0)
            {
                Mobilelist.Add(new Mobile()
                {
                    id= id,
                    Name = Name,
                    Description = Description,
                    ManufacturedBy = ManufacturedBy,
                    price=price,
                });

            }
            return count;
           
        }
        public List<Mobile> ViewAllMobiles()
        { 
            return Mobilelist;
        }

        public List <Mobile> SearchByPrice()
        {
            var maxPrice=Mobilelist.Max(x=>x.price);
            var countList=Mobilelist.FindAll(xprice=>xprice.price<maxPrice);
            return countList;

        }
        public List<Mobile>SearchByManufacturer()
        {
            var element = Mobilelist.FindAll(x => x.ManufacturedBy.ToLower() == SearchElement.ToLower());
            return element;

        }
        public List<Mobile>ViewByPrice()
        {
            var max=Mobilelist.Max(x=>x.price);
            var min = Mobilelist.Min(x => x.price);
            var priceList=Mobilelist.FindAll(x=>x.price >  min && x.price < max);
            return priceList;
        }
        public int  RemoveMobile()
        {
            int priceList=0;
            if (Mobilelist.Count > 0)
            {
                var max = Mobilelist.Max(x => x.price);
                var min = Mobilelist.Min(x => x.price);
                priceList = Mobilelist.RemoveAll(x => x.price > min && x.price < max);
            }
            return priceList;

            
        }
    }
}
