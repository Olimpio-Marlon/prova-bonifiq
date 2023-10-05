using Microsoft.Identity.Client;
using static ProvaPub.Services.CustomerService;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using ProvaPub.Models;

namespace ProvaPub.Tests
{
    public class CustomerServiceTests
    {
        private object customerId;

        public object Customers { get; private set; }
        public object Assert { get; private set; }

        public void Parte4Controller() => Assert.Equals(null, Customers.FindAsync(customerId));
    }
}
