using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewAungAndBryant.Shared.Domain
{
    public class Reviewer :BaseDomainModel
    {
       
        public string? ReviewerName { get; set; }
        
        public ReviewerRank Rank { get; set; }
    }

    public enum ReviewerRank
    {
        Silver,
        Gold,
        Platinum,
        Diamond,
    }
}
