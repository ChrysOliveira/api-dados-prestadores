using api_dados_prestadores.Models;
using System.Diagnostics;

namespace api_dados_prestadores.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PrestadorContext context)
        {
            if (context.Prestadores.Any())
            {
                return;   
            }

            var prestadores = new Prestador[]
            {
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 1 Ltda",NomeDivulgacao="Clinica BemStar 1",DataCredenciamento=DateTime.Parse("2021-10-25"),DataDescredenciamento=DateTime.Parse("2021-11-25"),InscricaoMunicipal="984191"},
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 2 Ltda",NomeDivulgacao="Clinica BemStar 2",DataCredenciamento=DateTime.Parse("2022-10-25"),DataDescredenciamento=DateTime.Parse("2022-11-25"),InscricaoMunicipal="984191"},
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 3 Ltda",NomeDivulgacao="Clinica BemStar 3",DataCredenciamento=DateTime.Parse("2023-10-25"),DataDescredenciamento=DateTime.Parse("2023-11-25"),InscricaoMunicipal="984191"},
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 4 Ltda",NomeDivulgacao="Clinica BemStar 4",DataCredenciamento=DateTime.Parse("2024-10-25"),DataDescredenciamento=DateTime.Parse("2024-11-25"),InscricaoMunicipal="984191"},
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 5 Ltda",NomeDivulgacao="Clinica BemStar 5",DataCredenciamento=DateTime.Parse("2025-10-25"),DataDescredenciamento=DateTime.Parse("2025-11-25"),InscricaoMunicipal="984191"},
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 6 Ltda",NomeDivulgacao="Clinica BemStar 6",DataCredenciamento=DateTime.Parse("2026-10-25"),DataDescredenciamento=DateTime.Parse("2026-11-25"),InscricaoMunicipal="984191"},
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 7 Ltda",NomeDivulgacao="Clinica BemStar 7",DataCredenciamento=DateTime.Parse("2027-10-25"),DataDescredenciamento=DateTime.Parse("2027-11-25"),InscricaoMunicipal="984191"},
                new Prestador{NumeroDocumento="32.123.321/4213-59",RazaoSocial="Clinica Dados Presatdor 8 Ltda",NomeDivulgacao="Clinica BemStar 8",DataCredenciamento=DateTime.Parse("2028-10-25"),DataDescredenciamento=DateTime.Parse("2028-11-25"),InscricaoMunicipal="984191"}
            };

            context.Prestadores.AddRange(prestadores);
            context.SaveChanges();

            var enderecos = new Endereco[]
            {
                new Endereco{NumeroDoContrato=1,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"},
                new Endereco{NumeroDoContrato=2,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"},
                new Endereco{NumeroDoContrato=3,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"},
                new Endereco{NumeroDoContrato=4,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"},
                new Endereco{NumeroDoContrato=5,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"},
                new Endereco{NumeroDoContrato=6,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"},
                new Endereco{NumeroDoContrato=7,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"},
                new Endereco{NumeroDoContrato=8,Cep="04431090",Municipio="São Paulo", UF=UF.SP, Bairro="Jardim Selma", Logradouro="Rua Manoel Rodrigues Mexelhao", Numero="263"}
            };

            context.Enderecos.AddRange(enderecos);
            context.SaveChanges();
        }
    }
}
