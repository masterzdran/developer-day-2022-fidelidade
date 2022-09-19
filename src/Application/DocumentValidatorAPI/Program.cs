using DocumentNumber.Portugal.CitizenCard.Validator;
using DocumentNumber.Portugal.Niss.Validator;
using DocumentNumber.ValidatorAbstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region IDocumentNumberValidator CC Validator
//builder.Services.AddScoped<IDocumentNumberValidator, CitizenCardValidator>();
#endregion
#region IDocumentNumberValidator NIF Validator
//builder.Services.AddScoped<IDocumentNumberValidator, NifValidator>();
#endregion
#region IDocumentNumberValidator NISS Validator
builder.Services.AddScoped<IDocumentNumberValidator, NissValidator>();
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
