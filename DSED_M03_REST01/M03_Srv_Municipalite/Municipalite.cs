namespace srvm
{
    public class Municipalite
    {
        public int CodeGeographique { get; set; }
        public string NomMunicipalite { get; set; }
        public string? AdresseCourriel { get; set; }
        public string? AdresseWeb { get; set; }
        public DateTime? DateProchaineElection { get; set; }
        public bool Actif { get; set; }

        public Municipalite(int p_codeGeographique, string p_nomMunicipalite, string? p_adresseCourriel, string? p_adresseWeb, DateTime? p_date)
        {
            this.CodeGeographique = p_codeGeographique;
            this.NomMunicipalite = p_nomMunicipalite;
            this.AdresseCourriel = p_adresseCourriel;
            this.AdresseWeb = p_adresseWeb;
            this.DateProchaineElection = p_date;
        }

        public Municipalite(Municipalite p_municipalite)
        {
            this.CodeGeographique = p_municipalite.CodeGeographique;
            this.NomMunicipalite = p_municipalite.NomMunicipalite;
            this.AdresseCourriel = p_municipalite.AdresseCourriel;
            this.AdresseWeb = p_municipalite.AdresseWeb;
            this.DateProchaineElection = p_municipalite.DateProchaineElection;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.CodeGeographique, this.NomMunicipalite, this.AdresseCourriel, this.AdresseWeb);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Municipalite))
            {
                return false;
            }
            else
            {
                Municipalite m = (Municipalite)obj;
                return (m.CodeGeographique == CodeGeographique && m.NomMunicipalite == NomMunicipalite && m.AdresseCourriel == AdresseCourriel && m.AdresseWeb == AdresseWeb);
            }
        }
    }
}