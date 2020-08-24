using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerneDor.Models
{
	public class Usuario
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Login { get; set; }
		public string Senha { get; set; }
		public string Email { get; set; }
		public int Fone { get; set; }

		public Usuario()
		{

		}

		public Usuario(int id, string nome, string login, string senha, string email, int fone)
		{
			Id = id;
			Nome = nome;
			Login = login;
			Senha = senha;
			Email = email;
			Fone = fone;
		}
	}

}
