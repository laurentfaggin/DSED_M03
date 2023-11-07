//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Storage;
//using srvm;
//using static DSED_M03_REST01.Data.MunicipaliteContextSqlServer;

//namespace DSED_M03_REST01.Data
//{
//    public class ApplicationDbContext : IdentityDbContext
//    {
//        private IDbContextTransaction? m_transaction;
//        public DbSet<Municipalite>? MUNICIPALITES => Set<Municipalite>();
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {

//        }

//        public void Commit()
//        {
//            if (this.m_transaction is null)
//            {
//                throw new InvalidOperationException("Une transaction doit etre debutee");
//            }
//            m_transaction.Commit();
//            m_transaction?.Dispose();
//            m_transaction = null;
//        }

//        public void Rollback()
//        {
//            if (this.m_transaction is null)
//            {
//                throw new InvalidOperationException("Une transaction doit être débutée");
//            }
//            m_transaction?.Rollback();
//            m_transaction?.Dispose();
//            m_transaction = null;
//        }

//        public void BeginTransaction()
//        {
//            if (this.m_transaction is null)
//            {
//                throw new InvalidOperationException("Une transaction est deja debutee");
//            }
//            m_transaction = Database.BeginTransaction();
//        }

//        public override void Dispose()
//        {
//            m_transaction?.Dispose();
//            m_transaction = null;
//            base.Dispose();
//        }
//    }
//}
