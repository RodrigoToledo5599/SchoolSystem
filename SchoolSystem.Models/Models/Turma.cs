using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolSystem.Models.Models
{
	public class Turma
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public int? AlunosId { get; set; }
		public IEnumerable<Aluno>? Alunos { get; set; }
		
	}
}
