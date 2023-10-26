using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_dados_prestadores.Models
{
    public class Prestador
    {
        [Key]
        public int NumeroContrato { get; set; }
        public string NumeroDocumento { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeDivulgacao {  get; set; }
        public string InscricaoMunicipal {  get; set; }
        
        [DataType(DataType.Date)]
        [JsonIgnore]
        public DateTime DataCredenciamento { get; set; }
        
        [DataType(DataType.Date)]
        [JsonIgnore]
        public DateTime DataDescredenciamento { get; set; }
        
        public string DataCredenciamentoFormatado
        {
            get { return  DataCredenciamento.ToShortDateString();}
        }

        public string DataDescredenciamentoFormatado
        {
            get { return DataDescredenciamento.ToShortDateString(); }
        }

        public ICollection<Endereco> Enderecos {  get; set; }
    }
}
