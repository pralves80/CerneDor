using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerneDor.Models.ViewModels
{
	public class Paciente
	{

		public int Id { get; set; }
		public string Nome { get; set; }
		public string Logradouro { get; set; }
		public string Endereco { get; set; }
		public int Numero { get; set; }
		public string Complemento { get; set; }
		public int Cep { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string UF { get; set; }
		public string Email { get; set; }
		public string Fone { get; set; }
		public string Celular { get; set; }

		public Paciente()
		{ 
		}

		public Paciente(int id, string nome, string logradouro, string endereco, int numero, string complemento, int cep, string bairro, string cidade, string uF, string email, string fone, string celular)
		{
			Id = id;
			Nome = nome;
			Logradouro = logradouro;
			Endereco = endereco;
			Numero = numero;
			Complemento = complemento;
			Cep = cep;
			Bairro = bairro;
			Cidade = cidade;
			UF = uF;
			Email = email;
			Fone = fone;
			Celular = celular;
		}
	}
}
