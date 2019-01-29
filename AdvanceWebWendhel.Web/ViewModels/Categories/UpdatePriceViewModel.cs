using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebWendhel.Web.ViewModels.Categories
{
    public class UpdatePriceViewModel
    {
        public Guid? CategoryId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        
    }
}
