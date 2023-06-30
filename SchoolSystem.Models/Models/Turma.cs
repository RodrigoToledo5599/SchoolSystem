using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolSystem.Models.Models
{
	public class Turma
	{
		[Key]
		public int IdTurma { get; set; }
		public string Name { get; set; }
		public int Serie { get; set; } // enum
		public int Materia { get; set; } // enum
		public IEnumerable<Aluno>? Alunos { get; set; }
		public IEnumerable<Materia>? Materias { get; set; }


	}
}
