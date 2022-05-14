using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MoviesFunction.Models
{
	public class Movie
	{
            [JsonPropertyName("adult")]
            public bool Adult;

            [JsonPropertyName("backdrop_path")]
            public object BackdropPath;

            [JsonPropertyName("belongs_to_collection")]
            public object BelongsToCollection;

            [JsonPropertyName("budget")]
            public int Budget;

            [JsonPropertyName("genres")]
            public List<Genre> Genres;

            [JsonPropertyName("homepage")]
            public string Homepage;

            [JsonPropertyName("id")]
            public int Id;

            [JsonPropertyName("imdb_id")]
            public string ImdbId;

            [JsonPropertyName("original_language")]
            public string OriginalLanguage;

            [JsonPropertyName("original_title")]
            public string OriginalTitle;

            [JsonPropertyName("overview")]
            public string Overview;

            [JsonPropertyName("popularity")]
            public double Popularity;

            [JsonPropertyName("poster_path")]
            public object PosterPath;

            [JsonPropertyName("production_companies")]
            public List<ProductionCompany> ProductionCompanies;

            [JsonPropertyName("production_countries")]
            public List<ProductionCountry> ProductionCountries;

            [JsonPropertyName("release_date")]
            public string ReleaseDate;

            [JsonPropertyName("revenue")]
            public int Revenue;

            [JsonPropertyName("runtime")]
            public int Runtime;

            [JsonPropertyName("spoken_languages")]
            public List<SpokenLanguage> SpokenLanguages;

            [JsonPropertyName("status")]
            public string Status;

            [JsonPropertyName("tagline")]
            public string Tagline;

            [JsonPropertyName("title")]
            public string Title;

            [JsonPropertyName("video")]
            public bool Video;

            [JsonPropertyName("vote_average")]
            public double VoteAverage;

            [JsonPropertyName("vote_count")]
            public int VoteCount;
        }
}


