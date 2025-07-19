using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

public class ListUsersResponse
{

    public class Rootobject
    {
        public User[] data { get; set; }
        public string totalItems { get; set; }
        public string currentPage { get; set; }
        public string totalPages { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Name name { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string status { get; set; }
        public string role { get; set; }
    }

    public class Name
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
    }

    public class Address
    {
        public string city { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string zipcode { get; set; }
        public Geolocation geolocation { get; set; }
    }

    public class Geolocation
    {
        public string lat { get; set; }
        public string _long { get; set; }
    }

}
