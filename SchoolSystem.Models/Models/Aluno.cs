using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Models
{
	public class Aluno
	{
		[Key]
		public int IdAluno { get; set; }
		public string Matricula { get; set; }
		public string Senha { get; set; }
		public int Serie { get; set; } // enum
		public string Name { get; set; }
		public IEnumerable<Turma> Turmas { get; set;} // enum


	}
}
