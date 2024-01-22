using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReviewAungAndBryant.Shared.Domain;
using System;

namespace ProductReviewAungAndBryant.Server.Configurations.Entities
{
    public class ReviewerSeedConfiguration : IEntityTypeConfiguration<Reviewer>
    {
        public void Configure(EntityTypeBuilder<Reviewer> builder)
        {
            builder.HasData(
                new Reviewer
                {
                    Id = 1,
                    ReviewerName = "Koike12",
                    Rank = ReviewerRank.Silver,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Reviewer
                {
                    Id = 2, 
                    ReviewerName = "AnotherUser",
                    Rank = ReviewerRank.Gold, 
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

