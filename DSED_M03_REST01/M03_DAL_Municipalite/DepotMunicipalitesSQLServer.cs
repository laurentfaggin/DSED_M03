using srvm;


namespace dalm
{
    public class DepotMunicipalitesSQLServer: IDepotMunicipalites
    {
        private readonly ApplicationDbContext m_dbCcontext;

        public DepotMunicipalitesSQLServer(ApplicationDbContext dbCcontext)
        {
            m_dbCcontext = dbCcontext;
        }

        public void AjouterMunicipalite(Municipalite municipalite)
        {
            m_dbCcontext.Add(new MunicipaliteDTO(municipalite));
            m_dbCcontext.SaveChanges();
        }

        public Municipalite ChercherMunicipaliteParCodeGeographique(int codeGeo)
        {
            return m_dbCcontext.MUNICIPALITES.Where(m => m.CodeGeographique == codeGeo).FirstOrDefault().VersEntite();
        }

        public void DesactiverMunicipalite(Municipalite p_municipalite)
        {
            m_dbCcontext.MUNICIPALITES.Where(m => m.CodeGeographique == p_municipalite.CodeGeographique)
                                      .SingleOrDefault()
                                      .VersEntite()
                                      .Actif = false;
                                      
        }

        public IEnumerable<Municipalite> ListerMunicipalitesActives()
        
        {
            return m_dbCcontext.MUNICIPALITES.Select(m => m.VersEntite()).ToList();
        }

        public void MAJMunicipalite(Municipalite municipalite)
        {
            MunicipaliteDTO municipaliteAModifier = m_dbCcontext.MUNICIPALITES.Where(m => m.CodeGeographique == municipalite.CodeGeographique).SingleOrDefault();
            if (municipaliteAModifier is null)
            {
                AjouterMunicipalite(municipalite);
            }

            municipaliteAModifier.CodeGeographique = municipalite.CodeGeographique;
            municipaliteAModifier.NomMunicipalite = municipalite.NomMunicipalite;
            municipaliteAModifier.AdresseCourriel = municipalite.AdresseCourriel;
            municipaliteAModifier.AdresseWeb = municipalite.AdresseWeb;
            municipaliteAModifier.DateProchaineElection = municipalite.DateProchaineElection;

            m_dbCcontext.Update(municipaliteAModifier);
            m_dbCcontext.SaveChanges();
        }
    }
}