using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace Lab5.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя доктора не установлено")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана специальность")]
        public string Speciality { get; set; }
    }
}
