using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvc.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int idProduct { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo valor {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha o campo valor")]
        public decimal value { get; set; }

        [DisplayName("Disponível")]
        public bool avaliable { get; set; }
        public int idClient { get; set; }
        
        public virtual ClientViewModel client { get; set; }
    }
}