using ASP_013_api.Model;

var builder = WebApplication.CreateBuilder(args);

string connectionString = "Server=tcp:my-server93-2.database.windows.net,1433;Initial Catalog=asp_013;Persist Security Info=False;User ID=admin93;Password=PASSworld93;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>(provider => new CategoryRepository(connectionString));
builder.Services.AddTransient<IProductRepository, ProductRepository>(provider => new ProductRepository(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
