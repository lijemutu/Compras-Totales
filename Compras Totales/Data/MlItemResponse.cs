// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Paging
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("primary_results")]
    public int PrimaryResults { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }
}

public class Excluded
{
    [JsonPropertyName("real_value")]
    public int RealValue { get; set; }

    [JsonPropertyName("real_rate")]
    public float RealRate { get; set; }
}

public class Cancellations
{
    [JsonPropertyName("period")]
    public string Period { get; set; }

    [JsonPropertyName("rate")]
    public float Rate { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("excluded")]
    public Excluded Excluded { get; set; }
}

public class Claims
{
    [JsonPropertyName("period")]
    public string Period { get; set; }

    [JsonPropertyName("rate")]
    public float Rate { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("excluded")]
    public Excluded Excluded { get; set; }
}

public class DelayedHandlingTime
{
    [JsonPropertyName("period")]
    public string Period { get; set; }

    [JsonPropertyName("rate")]
    public double Rate { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("excluded")]
    public Excluded Excluded { get; set; }
}

public class Sales
{
    [JsonPropertyName("period")]
    public string Period { get; set; }

    [JsonPropertyName("completed")]
    public int Completed { get; set; }
}

public class Metrics
{
    [JsonPropertyName("cancellations")]
    public Cancellations Cancellations { get; set; }

    [JsonPropertyName("claims")]
    public Claims Claims { get; set; }

    [JsonPropertyName("delayed_handling_time")]
    public DelayedHandlingTime DelayedHandlingTime { get; set; }

    [JsonPropertyName("sales")]
    public Sales Sales { get; set; }
}

public class Ratings
{
    [JsonPropertyName("negative")]
    public double Negative { get; set; }

    [JsonPropertyName("neutral")]
    public double Neutral { get; set; }

    [JsonPropertyName("positive")]
    public double Positive { get; set; }
}

public class Transactions
{
    [JsonPropertyName("canceled")]
    public int Canceled { get; set; }

    [JsonPropertyName("period")]
    public string Period { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("ratings")]
    public Ratings Ratings { get; set; }

    [JsonPropertyName("completed")]
    public int Completed { get; set; }
}

public class SellerReputation
{
    [JsonPropertyName("power_seller_status")]
    public string PowerSellerStatus { get; set; }

    [JsonPropertyName("level_id")]
    public string LevelId { get; set; }

    [JsonPropertyName("metrics")]
    public Metrics Metrics { get; set; }

    [JsonPropertyName("transactions")]
    public Transactions Transactions { get; set; }

    [JsonPropertyName("real_level")]
    public string RealLevel { get; set; }

    [JsonPropertyName("protection_end_date")]
    public DateTime? ProtectionEndDate { get; set; }
}

public class Seller
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("permalink")]
    public string Permalink { get; set; }

    [JsonPropertyName("registration_date")]
    public DateTime RegistrationDate { get; set; }

    [JsonPropertyName("car_dealer")]
    public bool CarDealer { get; set; }

    [JsonPropertyName("real_estate_agency")]
    public bool RealEstateAgency { get; set; }

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    [JsonPropertyName("seller_reputation")]
    public SellerReputation SellerReputation { get; set; }
}

public class Conditions
{
    [JsonPropertyName("context_restrictions")]
    public List<object> ContextRestrictions { get; set; }

    [JsonPropertyName("start_time")]
    public object StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public object EndTime { get; set; }

    [JsonPropertyName("eligible")]
    public bool Eligible { get; set; }
}

public class Metadata
{
}

public class Price
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("regular_amount")]
    public object RegularAmount { get; set; }

    [JsonPropertyName("currency_id")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime LastUpdated { get; set; }

    [JsonPropertyName("conditions")]
    public Conditions Conditions { get; set; }

    [JsonPropertyName("exchange_rate_context")]
    public string ExchangeRateContext { get; set; }

    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; set; }

    [JsonPropertyName("prices")]
    public List<Price> Prices { get; set; }

    [JsonPropertyName("presentation")]
    public Presentation Presentation { get; set; }

    [JsonPropertyName("payment_method_prices")]
    public List<object> PaymentMethodPrices { get; set; }

    [JsonPropertyName("reference_prices")]
    public List<ReferencePrice> ReferencePrices { get; set; }

    [JsonPropertyName("purchase_discounts")]
    public List<object> PurchaseDiscounts { get; set; }
}

public class Presentation
{
    [JsonPropertyName("display_currency")]
    public string DisplayCurrency { get; set; }
}

public class ReferencePrice
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("conditions")]
    public Conditions Conditions { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("currency_id")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("exchange_rate_context")]
    public string ExchangeRateContext { get; set; }

    [JsonPropertyName("tags")]
    public List<object> Tags { get; set; }

    [JsonPropertyName("last_updated")]
    public DateTime LastUpdated { get; set; }
}

public class Installments
{
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("rate")]
    public double Rate { get; set; }

    [JsonPropertyName("currency_id")]
    public string CurrencyId { get; set; }
}

public class Address
{
    [JsonPropertyName("state_id")]
    public string StateId { get; set; }

    [JsonPropertyName("state_name")]
    public string StateName { get; set; }

    [JsonPropertyName("city_id")]
    public string CityId { get; set; }

    [JsonPropertyName("city_name")]
    public string CityName { get; set; }
}

public class Shipping
{
    [JsonPropertyName("free_shipping")]
    public bool FreeShipping { get; set; }

    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    [JsonPropertyName("logistic_type")]
    public string LogisticType { get; set; }

    [JsonPropertyName("store_pick_up")]
    public bool StorePickUp { get; set; }
}

public class Country
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class State
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class City
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class SellerAddress
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }

    [JsonPropertyName("address_line")]
    public string AddressLine { get; set; }

    [JsonPropertyName("zip_code")]
    public string ZipCode { get; set; }

    [JsonPropertyName("country")]
    public Country Country { get; set; }

    [JsonPropertyName("state")]
    public State State { get; set; }

    [JsonPropertyName("city")]
    public City City { get; set; }

    [JsonPropertyName("latitude")]
    public string Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string Longitude { get; set; }
}

public class Struct
{
    [JsonPropertyName("number")]
    public double Number { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }
}

public class Value
{
    [JsonPropertyName("source")]
    public object Source { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("struct")]
    public Struct Struct { get; set; }

    [JsonPropertyName("path_from_root")]
    public List<PathFromRoot> PathFromRoot { get; set; }

    [JsonPropertyName("results")]
    public int Results { get; set; }
}

public class ValueStruct
{
    [JsonPropertyName("number")]
    public double Number { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }
}

public class Attribute
{
    [JsonPropertyName("attribute_group_name")]
    public string AttributeGroupName { get; set; }

    [JsonPropertyName("value_id")]
    public string ValueId { get; set; }

    [JsonPropertyName("value_name")]
    public string ValueName { get; set; }

    [JsonPropertyName("values")]
    public List<Value> Values { get; set; }

    [JsonPropertyName("attribute_group_id")]
    public string AttributeGroupId { get; set; }

    [JsonPropertyName("source")]
    public object Source { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("value_struct")]
    public ValueStruct ValueStruct { get; set; }
}

public class DifferentialPricing
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class Result
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("site_id")]
    public string SiteId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("seller")]
    public Seller Seller { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("prices")]
    public Prices Prices { get; set; }

    [JsonPropertyName("sale_price")]
    public object SalePrice { get; set; }

    [JsonPropertyName("currency_id")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("available_quantity")]
    public int AvailableQuantity { get; set; }

    [JsonPropertyName("sold_quantity")]
    public int SoldQuantity { get; set; }

    [JsonPropertyName("buying_mode")]
    public string BuyingMode { get; set; }

    [JsonPropertyName("listing_type_id")]
    public string ListingTypeId { get; set; }

    [JsonPropertyName("stop_time")]
    public DateTime StopTime { get; set; }

    [JsonPropertyName("condition")]
    public string Condition { get; set; }

    [JsonPropertyName("permalink")]
    public string Permalink { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("thumbnail_id")]
    public string ThumbnailId { get; set; }

    [JsonPropertyName("accepts_mercadopago")]
    public bool AcceptsMercadopago { get; set; }

    [JsonPropertyName("installments")]
    public Installments Installments { get; set; }

    [JsonPropertyName("address")]
    public Address Address { get; set; }

    [JsonPropertyName("shipping")]
    public Shipping Shipping { get; set; }

    [JsonPropertyName("seller_address")]
    public SellerAddress SellerAddress { get; set; }

    [JsonPropertyName("attributes")]
    public List<Attribute> Attributes { get; set; }

    [JsonPropertyName("original_price")]
    public object OriginalPrice { get; set; }

    [JsonPropertyName("category_id")]
    public string CategoryId { get; set; }

    [JsonPropertyName("official_store_id")]
    public object OfficialStoreId { get; set; }

    [JsonPropertyName("domain_id")]
    public string DomainId { get; set; }

    [JsonPropertyName("catalog_product_id")]
    public string CatalogProductId { get; set; }

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    [JsonPropertyName("catalog_listing")]
    public bool CatalogListing { get; set; }

    [JsonPropertyName("use_thumbnail_id")]
    public bool UseThumbnailId { get; set; }

    [JsonPropertyName("offer_score")]
    public object OfferScore { get; set; }

    [JsonPropertyName("offer_share")]
    public object OfferShare { get; set; }

    [JsonPropertyName("match_score")]
    public object MatchScore { get; set; }

    [JsonPropertyName("winner_item_id")]
    public object WinnerItemId { get; set; }

    [JsonPropertyName("order_backend")]
    public int OrderBackend { get; set; }

    [JsonPropertyName("differential_pricing")]
    public DifferentialPricing DifferentialPricing { get; set; }
}

public class Sort
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class AvailableSort
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class PathFromRoot
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class Filter
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("values")]
    public List<Value> Values { get; set; }
}

public class AvailableFilter
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("values")]
    public List<Value> Values { get; set; }
}

public class Root
{
    [JsonPropertyName("site_id")]
    public string SiteId { get; set; }

    [JsonPropertyName("country_default_time_zone")]
    public string CountryDefaultTimeZone { get; set; }

    [JsonPropertyName("query")]
    public string Query { get; set; }

    [JsonPropertyName("paging")]
    public Paging Paging { get; set; }

    [JsonPropertyName("results")]
    public List<Result> Results { get; set; }

    [JsonPropertyName("sort")]
    public Sort Sort { get; set; }

    [JsonPropertyName("available_sorts")]
    public List<AvailableSort> AvailableSorts { get; set; }

    [JsonPropertyName("filters")]
    public List<Filter> Filters { get; set; }

    [JsonPropertyName("available_filters")]
    public List<AvailableFilter> AvailableFilters { get; set; }
}

