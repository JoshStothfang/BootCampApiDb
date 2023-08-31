using System;
using System.ComponentModel.DataAnnotations;

namespace BootCampApiDb.Models
{
	public class Student
	{
		public int Id { get; set; }

		[StringLength(80)]
		public string Name { get; set; } = string.Empty;

		[StringLength(150)]
		public string Email { get; set; } = string.Empty;

		[StringLength(25)]
		public string Phone { get; set; } = string.Empty;
	}
}

