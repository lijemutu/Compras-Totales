namespace Compras_Totales.Data
{
    public class SearchResponse
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Vendor { get; set; }
        public string ThumbnailPath { get; set; }
        public string Url { get; set; }
    }
}
