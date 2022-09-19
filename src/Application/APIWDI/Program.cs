using DocumentNumber.Portugal.CitizenCard.Validator;
using DocumentNumber.Portugal.Niss.Validator;
using Portugal.Nif.Validator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Multiple Validator
builder.Services.AddScoped<ICitizenCardValidator, CitizenCardValidator>();
builder.Services.AddScoped<INifValidator, NifValidator>();
builder.Services.AddScoped<INissValidator, NissValidator>();
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
