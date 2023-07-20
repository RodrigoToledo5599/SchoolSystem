using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Models
{
	public class Atividade
	{
		[Key]
		public int Id { get; set; }


		public int AlunoId { get; set; }
		[ForeignKey("AlunoId")]
		public Aluno Aluno { get; set; }


		public string CodigoMateria { get; set; }
		public string NomeTeste { get; set;}
		public double Peso { get; set; }
		public int Nota { get; set; }
		public DateTime? Prazo { get; set; } 

	}
}
