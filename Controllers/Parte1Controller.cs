using Microsoft.AspNetCore.Mvc;
using ProvaPub.Services;
using System;

namespace ProvaPub.Controllers
{
	/// <summary>
	/// Ao rodar o código abaixo o serviço deveria sempre retornar um número diferente, mas ele fica retornando sempre o mesmo número.
	/// Faça as alterações para que o retorno seja sempre diferente
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	public class Parte1Controller :  ControllerBase
	{
		private readonly RandomService _randomService;

		public Parte1Controller(RandomService randomService)
		{
            Random aleatorio = new Random();
            int seed = aleatorio.Next(1, 100);
            Console.WriteLine($"O valor aleatorio eh {seed}");
        }
		
	}
}
