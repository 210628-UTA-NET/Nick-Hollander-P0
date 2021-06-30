using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProjectModels
{
    public class Customer
    {
        public string Name{get; set;}
        public string Address{get; set;}
        public string Contact{get; set;}
        private List<string> Orders = new List<string>();
        public List<Customer> Customers = new List<Customer>();
    }
    public class StoreFront
    {
        public string Name{get; set;}
        public string Address{get; set;}
        public string Inventory{get; set;}
        private List<string> Orders = new List<string>();
        
    }
    public class Orders
    {
        public List<string> OrderLineItems = new List<string>();
        public List<double> Prices = new List<double>();
        public string Location{get; set;}
        public double TotalPrice{get; set;}
    }
    public class LineItems
    {
        public string product{get; set;}
        public int quantity{get; set;}
    }
}
