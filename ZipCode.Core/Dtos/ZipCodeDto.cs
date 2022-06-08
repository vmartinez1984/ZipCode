using System.Text.Json.Serialization;

namespace ZipCode.Core.Dtos
{
    public class ZipCodeDto
    {
        [JsonPropertyName("CodigoPostal")]
         public string ZipCode { get; set; }

        [JsonPropertyName("estado")]
        public string State { get; set; }

        [JsonPropertyName("Alcaldia")]
        public string Municipality { get; set; }

        [JsonPropertyName("TipoDeAsentamiento")]
        public string SettementType { get; set; }

        [JsonPropertyName("Colonia")]
        public string Settement { get; set; }
    }
}