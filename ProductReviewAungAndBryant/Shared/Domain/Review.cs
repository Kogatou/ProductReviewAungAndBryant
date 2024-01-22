using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewAungAndBryant.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public int ReviewID { get; set; }
        public string? Name { get; set; }
        public string? ReviewText {  get; set; }

        public int PcPartId{ get; set; }

        public DateTime ReviewDate { get; set; }

        public int UserId{ get; set; }
    }
}
