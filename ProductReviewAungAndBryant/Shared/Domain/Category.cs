using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewAungAndBryant.Shared.Domain
{
    public class Category : BaseDomainModel
    {

        public string? CategoryName { get; set; }

        public string? CategoryBrandName { get; set; }

    }
}