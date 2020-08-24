using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerneDor.Models
{
	public class Procedimento
	{
		public int Id { get; set; }
		public string Descricao { get; set; }

		public Procedimento()
		{
		}

		public Procedimento(int id, string descricao)
		{
			Id = id;
			Descricao = descricao;
		}
	}
}
