﻿using Sp2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VOM_HIVE.API.DTO.Campaign.Vinculo;
using Microsoft.EntityFrameworkCore;

namespace VOM_HIVE.API.DTO.Campaign
{
    public class CampaignEditDto
    {
        [Required]
        [Key]
        public int id_campaign { get; set; }
        [Required]
        [Column("nm_campaing")]
        public string? nm_campaign { get; set; }

        [Required(ErrorMessage = "O nome da campanha é obrigatório.")]
        [Column("target")]
        public string? target { get; set; }

        [Required]
        [Column("dt_register")]
        public DateTime dt_register { get; set; }

        //CLOB
        [Required]
        [Column("details")]
        public string? details { get; set; }

        [Required]
        [Column("status")]
        public string? status { get; set; }

        [ForeignKey("Product")]
        [Column("id_product")]
        public int id_product { get; set; }

        [ForeignKey("Company")]
        [Column("id_company")]
        public int id_company { get; set; }
    }
}