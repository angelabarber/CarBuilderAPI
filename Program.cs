using CarBuilderAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

List<PaintColor> paintColors = new List<PaintColor>()
{
    new PaintColor()
    {
        Id = 1,
        Price = 500.00M,
        Color = "Silver"
    },
    new PaintColor()
    {
        Id = 2,
        Price = 600.00M,
        Color = "Midnight Blue"
    },
    new PaintColor()
    {
        Id = 3,
        Price = 800.00M,
        Color = "Firebrick Red"
    },
    new PaintColor()
    {
        Id = 4,
        Price = 700.00M,
        Color = "Spring Green"
    }
};

List<Interior> interiors = new List<Interior>()
{
    new Interior()
    {
        Id = 1,
        Price = 300.00M,
        Material = "Beige Fabric"
    },
    new Interior()
    {
        Id = 2,
        Price = 450.00M,
        Material = "Charcoal Fabric"
    },
    new Interior()
    {
        Id = 3,
        Price = 400.00M,
        Material = "White Leather"
    },
    new Interior()
    {
        Id = 4,
        Price = 500.00M,
        Material = "Black Leather"
    }
};

List<Technology> technologies = new List<Technology>()
{
    new Technology()
    {
        Id = 1,
        Price = 1000.00M,
        Package = "Basic Package",
    },
    new Technology()
    {
        Id = 2,
        Price = 1500.00M,
        Package = "Navigation Package",
    },
    new Technology()
    {
        Id = 3,
        Price = 2000.00M,
        Package = "Visibility Package",
    },
    new Technology()
    {
        Id = 4,
        Price = 2500.00M,
        Package = "Ultra Package",
    }
};

List<Wheel> wheels = new List<Wheel>()
{
    new Wheel()
    {
        Id = 1,
        Price = 400.00M,
        Style = "17-inch Pair Radial"
    },
    new Wheel()
    {
        Id = 2,
        Price = 550.00M,
        Style = "17-inch Pair Radial Black"
    },
    new Wheel()
    {
        Id = 3,
        Price = 650.00M,
        Style = "18-inch Pair Spoke Silver"
    },
    new Wheel()
    {
        Id = 4,
        Price = 750.00M,
        Style = "18-inch Pair Spoke Black"
    }
};

app.Run();

