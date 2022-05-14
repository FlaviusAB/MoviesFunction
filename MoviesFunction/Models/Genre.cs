using System;
using System.Text.Json.Serialization;

namespace MoviesFunction.Models
{
	public class Genre
	{
		
            [JsonPropertyName("id")]
			public int Id;

			[JsonPropertyName("name")]
			public string Name;
		
	}
}

