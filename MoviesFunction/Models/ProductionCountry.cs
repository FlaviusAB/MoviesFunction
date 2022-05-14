using System.Text.Json.Serialization;

namespace MoviesFunction.Models
{
    public class ProductionCountry
    {
        [JsonPropertyName("iso_3166_1")]
        public string Iso31661;

        [JsonPropertyName("name")]
        public string Name;
    }
}