using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosASP_NET_CORE_MVC.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório.")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "Digite um nome com no mínimo 5 ou no máximo 80 caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Descição obrigatória.")]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Digite uma Descrição com no mínimo 10 caracteres")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Local obrigatório.")]
        [StringLength (100, MinimumLength = 3, ErrorMessage = "Digite um Local com no mínimo 3 ou no máximo 100 caracteres.")]
        public string? Local { get; set; }

        [Required(ErrorMessage = "Data obrigatório.")]
        [DataType(DataType.Date, ErrorMessage = "Digite formato de data correto")]
        public DateTime? DataEvento { get; set; }

        [Range(1, 1000, ErrorMessage = "Limite de quantidade de vagas entre 1 e 1000")]
        public int? QuantidadeVagas { get; set; }

        [Required(ErrorMessage = "Valor obrigatório.")]
        [Range(0, double.MaxValue,ErrorMessage = "Digite o valor de ingresso que seja no mínimo ou maior do que zero.")]
        public decimal? ValorIngresso { get; set; }
    }
}