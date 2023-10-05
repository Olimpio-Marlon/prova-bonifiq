using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			if (paymentMethod == "pix" || paymentMethod == "creditcard" || paymentMethod == "paypal")
			{
				//Faz pagamento...
			}
		

			return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}
}
