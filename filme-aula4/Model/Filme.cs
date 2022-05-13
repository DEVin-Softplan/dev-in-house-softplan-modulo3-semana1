using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace filme.Entity
{
    public class Filme
    {
        [Key] //identifica a PK da tabela gerada a partir do filme
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage = "Titulo é obrigatório")]
        public string Titulo {get; set;}
        [Required(ErrorMessage = "Diretor é obrigatório")]

        public int DiretorId {get; set;}

        [JsonIgnore]
        public virtual Diretor Diretor {get; set;}

        public string Genero {get; set;}

        [Range(1,600,ErrorMessage = "A duração de um filme de ve ser entre 1 e 600 minutos")]
        public int Duracao {get; set;}
        // public DateTime DataLancamento{get; set;}        
    }
}