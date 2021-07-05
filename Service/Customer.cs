using System;


namespace Service.Function
{
     public class Customer
    {
        public string id { get; set; }
        public string phonenumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Service[] service{ get; set; }
        public Sale[] sale{ get; set; }
        public Address Address { get; set; }
        
    }

    public class Service
    {
        public string ServiceNumber {get; set;}
        public string ServiceType {get; set;}
        public string ServiceDate {get; set;}
        public string status {get; set;}

    }

    public class Sale
    {
        public string SaleNumber {get; set;}
        public string SaleDate {get; set;}
        public string SaleType {get; set;}
        public string status {get; set;}
    }

    public class Address
    {
        public string State { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}