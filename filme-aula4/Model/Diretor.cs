using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace filme.Entity
{
    public class Diretor
    {
        [Key] //identifica a PK da tabela gerada a partir do filme
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage = "Titulo é obrigatório")]
        public string Nome {get; set;}
        
        public int FilmeId{get; set;}
        [JsonIgnore]
        public virtual Filme Filme {get; set;}
        
    }
}