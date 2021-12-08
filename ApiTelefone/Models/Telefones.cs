using System.ComponentModel.DataAnnotations;

namespace ApiTelefone.Models
{
	public class Telefones
	{
		[Key]
		public int iduser { get; set; }
		public string loja { get; set; }
		public string Fone { get; set; }
		public string cell { get; set; }
	}
}