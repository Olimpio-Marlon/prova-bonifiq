namespace ProvaPub.Services
{
	public class RandomService
	{
		///int seed;
		public RandomService()
		{
			//seed = Guid.NewGuid().GetHashCode();
			Random aleatorio = new Random();
			int seed = aleatorio.Next(1, 100);
			Console.WriteLine($"O valor aleatorio eh {seed}");
		}
		/*public int GetRandom()
		{
			return new Random(seed).Next(100);
		}*/

	}
}
