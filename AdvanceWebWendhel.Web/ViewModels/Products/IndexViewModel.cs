using AdvanceWebWendhel.Web.Infrastructures.Data.Helpers;
using AdvanceWebWendhel.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebWendhel.Web.ViewModels.Products
{
    public class IndexViewModel
    {
        public Page<Product> Products { get; set; }
    }
}
