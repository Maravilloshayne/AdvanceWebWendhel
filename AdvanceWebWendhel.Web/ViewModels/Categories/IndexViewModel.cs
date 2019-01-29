using AdvanceWebWendhel.Web.Infrastructures.Data.Helpers;
using AdvanceWebWendhel.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebWendhel.Web.ViewModels.Categories
{
    public class IndexViewModel
    {
        public Page<Category> Categories { get; set; }
    }
}

