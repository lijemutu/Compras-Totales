using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compras_Totales.Data
{
    public class MLSearch : ISearchVendors
    {
        public string vendorName { get ; set; }

        public MLSearch()
        {
            this.vendorName = "Mercado Libre";
        }

        
        public List<SearchResponse> SearchRequest(SearchModel searchName)
        {

            List<SearchResponse> searchViewResults = new();
            // Logic retrieve
            return searchViewResults;
        }

    }
}
