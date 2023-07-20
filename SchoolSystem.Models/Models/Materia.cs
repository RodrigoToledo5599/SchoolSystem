using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Models
{
	public class Materia
	{
		[Key]
		public int Id { get; set; }
		public int Nome { get; set; }



		
		/*public int? AlunosId { get; set; }
		// [ForeignKey("IdAlunos")]
		public IEnumerable<Aluno>? Alunos { get; set; }*/
	}
}
