using System.Linq;
using System.Runtime.InteropServices;

namespace DSED_M03_REST01_Swagger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MunicipaliteModel> municipalites = ListeMunicipalites();

            MunicipaliteModel mun = municipalites.Where(m => m.NomMunicipalite == "Québec").FirstOrDefault();
            ModifierNomMunicipalite(mun.CodeGeographique, "Quebecq");
            municipalites.ForEach(m => Console.WriteLine(m.NomMunicipalite));
        }

        public static List<MunicipaliteModel> ListeMunicipalites()
        {
            MunicipaliteClient mun = new MunicipaliteClient();

            Task<ICollection<MunicipaliteModel>> getTask = mun.GetAllAsync();
            getTask.Wait();
            List<MunicipaliteModel> municipalites = getTask.Result.OrderBy(m=>m.NomMunicipalite).ToList();

            return municipalites;
        }

        private static MunicipaliteModel SelectionnerVilleParId(int id)
        {
            MunicipaliteClient mun = new MunicipaliteClient();
            List<MunicipaliteModel> municipalites = ListeMunicipalites();
            Task<MunicipaliteModel> getTask = mun.GetAsync(id);
            getTask.Wait();
            MunicipaliteModel m = getTask.Result;

            return m;
        }

        public static void ModifierNomMunicipalite(int id, string nom)
        { 
            MunicipaliteClient mun = new MunicipaliteClient();
            Task<MunicipaliteModel> getTask = mun.GetAsync(id);
            getTask.Wait();
            MunicipaliteModel m = getTask.Result;
            m.NomMunicipalite = nom;
            mun.PutAsync(id, m);           
        }   
    }
}