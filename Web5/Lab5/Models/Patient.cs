using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя пациента не установлено")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Диагноз не указан")]
        public string Diagnosis { get; set; }
    }
}
