using System.Text.Json.Serialization;

namespace MoviesFunction.Models
{
    public class ProductionCompany
    {
        [JsonPropertyName("id")]
        public int Id;

        [JsonPropertyName("logo_path")]
        public object LogoPath;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("origin_country")]
        public string OriginCountry;
    }
}