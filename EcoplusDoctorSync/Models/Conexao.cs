using Newtonsoft.Json;
using System.Collections.Generic;

namespace EcoplusDoctorSync.Models
{
    public class Conexao
    {
        [JsonProperty("Apelido")]
        public string Apelido { get; set; }

        [JsonProperty("Servidor")]
        public string Servidor { get; set; }

        [JsonProperty("Usuario")]
        public string Usuario { get; set; }

        [JsonProperty("Senha")]
        public string Senha { get; set; }

        [JsonProperty("Base")]
        public string Base { get; set; }

        public string GetStringDeConexao()
        {
            return $@"Data Source={Servidor};User ID={Usuario};Password={Senha};Initial Catalog={Base};";
           
        }

    }

    public class Root
    {
        [JsonProperty("conexoes")]
        public List<Conexao> Conexoes { get; set; }
    }
}

   
