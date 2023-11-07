using srvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalm
{
    public class MunicipaliteDTO
    {
        [Key]
        [Column("id")]
        public int CodeGeographique { get; set; }
        [Column("nom")]
        public string NomMunicipalite { get; set; }
        [Column("courriel")]
        public string? AdresseCourriel { get; set; }
        [Column("web")]
        public string? AdresseWeb { get; set; }
        [Column("prochainesElections")]
        public DateTime? DateProchaineElection { get; set; }
        

        public MunicipaliteDTO()
        {
            ;
        }

        public MunicipaliteDTO(Municipalite p_municipalite)
        {
            this.CodeGeographique = p_municipalite.CodeGeographique;
            this.NomMunicipalite = p_municipalite.NomMunicipalite;
            this.AdresseCourriel = p_municipalite.AdresseCourriel;
            this.AdresseWeb = p_municipalite.AdresseWeb;
            this.DateProchaineElection = p_municipalite.DateProchaineElection;
        }

        public Municipalite VersEntite()
        {
            return new Municipalite(CodeGeographique, NomMunicipalite, AdresseCourriel, AdresseWeb, DateProchaineElection);
        }

    }
}
