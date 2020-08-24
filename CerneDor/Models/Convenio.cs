using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerneDor.Models
{
	public class Convenio
	{
		public int ID { get; set; }
		public string Descricao { get; set; }
		public string CodigoAns { get; set; }

		public Convenio()
		{
		}

		public Convenio(int iD, string descricao, string codigoAns)
		{
			ID = iD;
			Descricao = descricao;
			CodigoAns = codigoAns;
		}
	}

}
