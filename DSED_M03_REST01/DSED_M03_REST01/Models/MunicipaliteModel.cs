using srvm;

namespace apim
{
    public class MunicipaliteModel
    {
        public int CodeGeographique { get; set; }
        public string NomMunicipalite { get; set; }
        public string AdresseCourriel { get; set; }
        public string AdresseWeb { get; set; }
        public DateTime? DateProchaineElection { get; set; }

        public MunicipaliteModel() { }

        public MunicipaliteModel(Municipalite p_municipalite)
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