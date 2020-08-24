using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CerneDor.Models;

namespace CerneDor.Controllers
{
	public class ConveniosController : Controller
	{
		public IActionResult Index()
		{
			List<Convenio> list = new List<Convenio>();
			list.Add(new Convenio { ID = 1, Descricao = "Sulamérica", CodigoAns = "CodSulam" });
			list.Add(new Convenio { ID = 2, Descricao = "Unimed Recife", CodigoAns = "CodUnim" });
			list.Add(new Convenio { ID = 3, Descricao = "Amil", CodigoAns = "CodAmil" });
			list.Add(new Convenio { ID = 4, Descricao = "Bradesco", CodigoAns = "CodBra" });

			return View(list);  // vai retornar o valor do controller para a view
		}
	}
}

