namespace MyVet.Web.Data.Entities
{
	public class Manager
	{
		public int Id { get; set; }

		// Aqui hago la relacion (1:1) entre User y Manager
		public User User { get; set; }
	}
}

