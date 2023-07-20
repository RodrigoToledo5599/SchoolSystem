using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Models
{
	public class Aluno
	{
		[Key]
		public int Id { get; set; }
		public string Matricula { get; set; }
		public string Senha { get; set; }
		public int Serie { get; set; } 
		public string Name { get; set; }

		public List<Atividade> atividades { get; set; }
		/*
		public int? TurmaId { get; set; }
		[ForeignKey("TurmaId")]
		public Turma? Turma { get; set;} 

		*/











	}
}
