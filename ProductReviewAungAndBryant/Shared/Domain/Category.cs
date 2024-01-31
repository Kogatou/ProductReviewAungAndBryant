using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewAungAndBryant.Shared.Domain
{
    public class Category : BaseDomainModel
    {
        [Required(ErrorMessage="Required")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CategoryBrandName { get; set; }

        public virtual List<CategoryPcPart>? CategoryPcParts { get; set; }
    }
}