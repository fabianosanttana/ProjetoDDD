using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvc.MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int idClient { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage="Máximo valor {0} caracteres")]
        [MinLength(2, ErrorMessage="Mínimo {0} caracteres")]
        public string name { get; set; }

        [Required(ErrorMessage = "Preencha o campo sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo valor {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Preencha o campo email")]
        [MaxLength(100, ErrorMessage = "Máximo valor {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [EmailAddress(ErrorMessage= "Preencha com um email válido")]
        [DisplayName("E-mail")]
        public string email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime dateRecorder { get; set; }

        public bool active { get; set; }
        
        public virtual IEnumerable<ProductViewModel> Produtos { get; set; }
    }
}