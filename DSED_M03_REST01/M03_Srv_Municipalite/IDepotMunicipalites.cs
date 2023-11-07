using srvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srvm
{
    public interface IDepotMunicipalites
    {
        Municipalite ChercherMunicipaliteParCodeGeographique(int codeGeo);
        IEnumerable<Municipalite> ListerMunicipalitesActives();
        void DesactiverMunicipalite(Municipalite municipalite);
        void AjouterMunicipalite(Municipalite municipalite);
        void MAJMunicipalite(Municipalite municipalite);
    }
}
