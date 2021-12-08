

using System.Collections.Generic;
using ApiTelefone.Models;
using ApiTelefone.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ApiTelefone.Controllers
{
	[Route("api/[Controller]")]
	public class TelefonesController : Controller
	{
		private readonly ITelefonesRepository _telefoneRepositorio;

		public TelefonesController(ITelefonesRepository telefoneRepo)
		{
			_telefoneRepositorio = telefoneRepo;
		}

		[HttpGet]
		public IEnumerable<Telefones> GetAll()
		{
			var listaTelefones = _telefoneRepositorio.GetAll();

			return listaTelefones;
		}

		[HttpGet("{id}", Name = "GetTelefone")]
		public IActionResult GetById(long id)
		{
			var loja = _telefoneRepositorio.Find(id);
			if (loja == null)
				return NotFound();//Retornar erro404

			return new ObjectResult(loja);//retorna codigo 200 OK
		}

		[HttpPost]
		public IActionResult Create([FromBody] Telefones loja)
		{
			if (loja == null)
				return BadRequest();

			_telefoneRepositorio.Add(loja);
			//return Json(loja);
			return CreatedAtRoute("GetLoja", new Telefones { IdUser = loja.IdUser }, loja);
		}

		[HttpPut("{id}")]
		public IActionResult Update(int id, [FromBody] Telefones loja)
		{
			if (loja == null)
			{
				return BadRequest();

			}
			var novaLoja = _telefoneRepositorio.Find(id);

			if (novaLoja == null)
			{
				return BadRequest();

			}
			novaLoja.Loja = loja.Loja;
			novaLoja.Fone = loja.Fone;
			novaLoja.Cell = loja.Cell;
			_telefoneRepositorio.Update(novaLoja);
			return Json(novaLoja);

		}
		// [HttpPut("{id}")]
		// public IActionResult Update(long id, [FromBody] Telefones loja)
		// {
		// 	if (loja == null || loja.iduser != id)
		// 		return BadRequest();

		// 	var Contatoloja = _telefoneRepositorio.Find(id);


		// 	if (loja == null)
		// 		return NotFound();

		// 	_telefoneRepositorio.


		// 	_telefoneRepositorio.Update(Contatoloja);
		// 	return new NoContentResult();

		// }

		// [HttpDelete("{id}")]
		// public IActionResult Delete(long id)
		// {
		// 	var Contatoloja = _telefoneRepositorio.Find(id);
		// 	if (loja == null)
		// 		return NotFound;

		// 	_telefoneRepositorio.Remove(id);
		// 	return new NoContentResult();
		// }


	}
}