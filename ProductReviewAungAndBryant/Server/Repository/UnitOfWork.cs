using CarRentalManagement.Server.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductReviewAungAndBryant.Server.Data;
using ProductReviewAungAndBryant.Server.IRepository;
using ProductReviewAungAndBryant.Server.Models;
using ProductReviewAungAndBryant.Shared.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewAungAndBryant.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Reviewer> Reviewers => new GenericRepository<Reviewer>(_context);
        public IGenericRepository<Review> Reviews => new GenericRepository<Review>(_context);
        public IGenericRepository<PcPart> PcParts => new GenericRepository<PcPart>(_context);
        public IGenericRepository<Category> Categorys => new GenericRepository<Category>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            // To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified || q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                if (entry.Entity is BaseDomainModel baseEntity)
                {
                    baseEntity.DateUpdated = DateTime.Now;
                    baseEntity.UpdatedBy = user;

                    if (entry.State == EntityState.Added)
                    {
                        baseEntity.DateCreated = DateTime.Now;
                        baseEntity.CreatedBy = user;
                    }
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
