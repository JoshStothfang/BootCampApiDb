using System;
using System.ComponentModel.DataAnnotations;

namespace BootCampApiDb.Models
{
	public class Assessment
	{
		public int Id { get; set; }

		[StringLength(50)]
		public string Topic { get; set; } = string.Empty;
	}
}

