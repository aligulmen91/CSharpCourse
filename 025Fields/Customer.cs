using System.Collections.Generic;

namespace _025Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); /*Normally we should create a constructor and emtpy list, but if we forget to call that constructor anywhere, it will cause a problem
                                                        So, we can write in place of " public List<Order> Orders;"   ---->    public readonly List<Order> Orders = new List<Order>();
                                                        It wil always be empty list and no need to call that constructor everytime*/


        public Customer(int id)
        {
            this.Id = id;
        }


        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    
    public void Promote()
        {
            //......
        }



    }
}
