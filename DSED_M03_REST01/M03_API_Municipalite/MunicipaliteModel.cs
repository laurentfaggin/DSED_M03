using srvm;

namespace apim
{
    public class MunicipaliteModel
    {
        public int MunicipaliteId { get; set; }
        public string NomMunicipalite { get; set; }
        public string AdresseCourriel { get; set; }
        public string AdtresseWeb { get; set; }
        public DateTime? dateProchaineElection { get; set; }
        public bool actif { get; set; }

        public MunicipaliteModel() { }

        public MunicipaliteModel(srvm.Municipalite p_municipalite)
        {

        }
    }
}