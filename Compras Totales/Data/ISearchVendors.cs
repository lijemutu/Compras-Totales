using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compras_Totales.Data
{
    public interface ISearchVendors
    {
        string vendorName { get; set; }
        List<SearchResponse> SearchRequest(SearchModel searchName);
    }
}
