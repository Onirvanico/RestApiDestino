using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpRest.Models
{
    [Table("destino")]
    public class Destino
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "É preciso informar uma descrição para o produto")]
        [StringLength(70)]
        public string Local { get; set; }
        [Required(ErrorMessage = "Informe a quantidade")]
        public string Descricao { get; set; }
    }
}
