using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Globalization;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        //Título e diretor são obrigatórios e devem ter um comprimento entre 5 e 40
        // caracteres

        [Required]
        [StringLength(400, ErrorMessage = "{0} número de caracteres de ver entre {2} e {1}.", MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [StringLength(400, ErrorMessage = "{0} número de caracteres de ver entre {2} e {1}.", MinimumLength = 5)]

        public string Director { get; set; }

        //Data de lançamento deve ser no formato brasileiro (dia/mês/ano) e usado,
        //também, para entrada/atualização de dados

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Display(Name = "Release Date")]

        public DateTime ReleaseDate { get; set; }

        //Apresentar faturamento (Goss) em formato monetário, com separador de milhar.
   //     [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public float Gross { get; set; }


        [DisplayFormat(DataFormatString = "{0:F}", ApplyFormatInEditMode = true)]

        [Range(typeof(double), "0.0", "10.0")]

        public double Rating { get; set; }
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }

}