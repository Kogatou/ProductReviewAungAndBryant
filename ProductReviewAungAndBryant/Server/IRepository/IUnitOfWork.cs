using ProductReviewAungAndBryant.Shared.Domain;
using Microsoft.AspNetCore.Http;
using ProductReviewAungAndBryant.Server.IRepository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Reviewer> Reviewers { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<PcPart> PcParts { get; }
        IGenericRepository<Category> Categories { get; }
       
    }
}