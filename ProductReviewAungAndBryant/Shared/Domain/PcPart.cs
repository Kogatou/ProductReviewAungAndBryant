using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewAungAndBryant.Shared.Domain
{
    public class PcPart : BaseDomainModel
    {       
        public string PcPartName { get; set; }  

        public float PcPartPrice { get; set; }

        public virtual List<CategoryPcPart>? CategoryPcParts { get; set; }

        public virtual List<Review>? Reviews { get; set; }
    }
}
