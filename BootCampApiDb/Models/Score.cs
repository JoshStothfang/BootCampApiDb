using System;
using System.Text.Json.Serialization;

namespace BootCampApiDb.Models
{
	public class Score
	{
		public int Id { get; set; }

		public int StudentId { get; set; }
		[JsonIgnore]
		public virtual Student? Student { get; set; }

		public int AssessmentId { get; set; }
		[JsonIgnore]
		public virtual Assessment? Assessment { get; set; }

		public int Points { get; set; } 
	}
}

