using System.ComponentModel.DataAnnotations;

namespace ApiTelefone.Models
{
	public class Telefones
	{
		[Key]
		public int IdUser { get; set; }
		public string Loja { get; set; }
		public string Fone { get; set; }
		public string Cell { get; set; }

        public Telefones(){}

        public Telefones(string loja, string fone, string cell)
        {
			Loja = loja;
			Fone = fone;
			Cell = cell;
        }
	}
}