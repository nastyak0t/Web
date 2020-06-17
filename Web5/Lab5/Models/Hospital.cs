﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Hospital
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название госпиталя не установлено")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Адрес не указан")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Телефон не указан")]
        public string Phones { get; set; }
    }
}
