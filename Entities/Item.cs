namespace Catalog.Entities{

    public record Item{

        public Guid Id {get; init;}
        public string? Name { get; init;} // or you can do it like public string Name { get; init;} = string.Empty;
        public decimal Price {get; init;}
        public DateTimeOffset CreatedDate {get; init;}
    } 


}