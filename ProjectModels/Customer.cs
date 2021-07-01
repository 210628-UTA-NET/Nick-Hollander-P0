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
    }