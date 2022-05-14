using System.Text.Json.Serialization;

namespace MoviesFunction.Models
{
    public class SpokenLanguage
    {
        [JsonPropertyName("english_name")]
        public string EnglishName;

        [JsonPropertyName("iso_639_1")]
        public string Iso6391;

        [JsonPropertyName("name")]
        public string Name;
    }
}