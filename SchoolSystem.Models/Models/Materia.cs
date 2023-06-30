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
		public int IdMateria { get; set; }
		public int MateriaCode { get; set; }
		[NotMapped]
		public IEnumerable<int> notas { get; set; }
	}
}
