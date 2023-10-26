using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_dados_prestadores.Models
{
    public enum UF
    {
        SP, RJ
    }
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Prestador")]
        [JsonIgnore]
        public int NumeroDoContrato { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public UF UF {  get; set; }
        public string Bairro {  get; set; }
        public string Logradouro {  get; set; }
        public string Numero {  get; set; }
        public Prestador Prestador { get; set; }
    }
}
