using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eShopSolution.ViewModels.Common
{
    public class PagingRequestBase
    {
        [FromQuery(Name = nameof(PageIndex))]
        public int PageIndex { get; set; }
        [FromQuery(Name = nameof(PageSize))]
        public int PageSize { get; set; }

    }
}
