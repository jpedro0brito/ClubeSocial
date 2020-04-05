﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSocial.Models.ViewModels
{
    public class CandidatoViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string Senha { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confimar Senha", Prompt = "*******")]
        [Compare("Senha", ErrorMessage = "Senha nao esta igual")]
        public string ConfimarSenha { get; set; }
        public Candidato Candidato { get; set; }
    }
}
