var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Service Scope Demo
//builder.Services.AddTransient<ServiceScopeDemo.IServiceScope, ServiceScopeDemo.ServiceScope>();
//builder.Services.AddScoped<ServiceScopeDemo.IServiceScope, ServiceScopeDemo.ServiceScope>();
builder.Services.AddSingleton<ServiceScopeDemo.IServiceScope, ServiceScopeDemo.ServiceScope>();
#endregion


builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
