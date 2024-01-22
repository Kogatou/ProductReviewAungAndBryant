using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReviewAungAndBryant.Shared.Domain;
using System;

namespace ProductReviewAungAndBryant.Server.Configurations.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1, // Assuming the Review entity has an Id property
                    ReviewID = 1,
                    Name = "Review1",
                    ReviewText = "This is the first review.",
                    PcPartId = 1,
                    ReviewDate = DateTime.Now,
                    UserId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Review
                {
                    Id = 2, // Assuming the Review entity has an Id property
                    ReviewID = 2,
                    Name = "Review2",
                    ReviewText = "This is the second review.",
                    PcPartId = 2,
                    ReviewDate = DateTime.Now,
                    UserId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
