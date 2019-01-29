using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebWendhel.Web.ViewModels.Products
{
    public class UpdateDescriptionViewModel
    {
        public Guid? ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
