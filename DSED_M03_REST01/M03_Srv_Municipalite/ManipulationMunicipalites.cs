using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace srvm
{
    public class ManipulationMunicipalites
    {
        private IDepotMunicipalites m_depotMunicipalites;

        public ManipulationMunicipalites(IDepotMunicipalites p_depotMunicipalite) 
        {
            this.m_depotMunicipalites = p_depotMunicipalite;
        }

        public void AjouterMunicipalite(Municipalite municipalite)
        {
            m_depotMunicipalites.AjouterMunicipalite(municipalite);
        }

        public Municipalite ChercherMunicipaliteParCodeGeographique(int codeGeo)
        {
            return m_depotMunicipalites.ChercherMunicipaliteParCodeGeographique(codeGeo);
        }

        public void DesactiverMunicipalite(Municipalite p_municipalite)
        {
            m_depotMunicipalites.DesactiverMunicipalite(p_municipalite);
        }

        public IEnumerable<Municipalite> ListerMunicipalitesActives()
        {
            return m_depotMunicipalites.ListerMunicipalitesActives();
        }

        public void MAJMunicipalite(Municipalite municipalite)
        {
            Municipalite municipaliteAModifier = m_depotMunicipalites.ChercherMunicipaliteParCodeGeographique(municipalite.CodeGeographique);
            if (municipaliteAModifier is null)
            {
                AjouterMunicipalite(municipalite);
            }

            municipaliteAModifier.CodeGeographique = municipalite.CodeGeographique;
            municipaliteAModifier.NomMunicipalite = municipalite.NomMunicipalite;
            municipaliteAModifier.AdresseCourriel = municipalite.AdresseCourriel;
            municipaliteAModifier.AdresseWeb = municipalite.AdresseWeb;
            municipaliteAModifier.DateProchaineElection = municipalite.DateProchaineElection;

            m_depotMunicipalites.MAJMunicipalite(municipaliteAModifier);
        }

    }
}
