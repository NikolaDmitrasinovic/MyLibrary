using Basket;
using Catalog;
using Lending;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddLendingModule(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
