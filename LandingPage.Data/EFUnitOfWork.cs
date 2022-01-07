using LandingPage.Data.Entities;
using LandingPage.Infrastructure.Interfaces;

namespace LandingPage.Data
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly LandingPageContext _context;

        public EFUnitOfWork(LandingPageContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}