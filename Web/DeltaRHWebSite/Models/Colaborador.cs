﻿using DeltaRHWebSite.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace DeltaRHWebSite.Models
{
    [Table("tbl_colaborador")]
    public class Colaborador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_colaborador {  get; private set; }
        public string? nome {  get; private set; }
        public DateTime? data_nascimento {  get; private set; }
        public string? cpf {  get; private set; }
        public decimal salario_bruto { get; private set; }
        public string? senha { get; private set; }
        public string? tipo_contrato {  get; private set; }
        public int carga_horaria {  get; private set; }
        public string? logradouro { get; private set; }
        public string? numero { get; private set; }
        public string? complemento { get; private set; }
        public string? bairro { get; private set; }
        public string? cep { get; private set; }
        public string? cidade { get; private set; }
        public string? uf { get; private set; }
        public string? telefone { get; private set; }
        public string? telefone2 { get; private set; }
        public string? email { get; private set; }
        public string? cargo { get; private set; }
        public decimal? horas_banco { get; private set; }
        public DateTime? data_admissao { get; private set; }

        //Associacoes
        public int id_setor { get; set; }
        [NotMapped]
        public virtual Setor? setor { get; set; }

        [NotMapped]
        public virtual ICollection<Holerite>? holerites { get; set; } 
    }
}
