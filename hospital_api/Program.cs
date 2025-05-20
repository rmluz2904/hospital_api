using hospital_api.DB;
using hospital_api.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

    //using (var scope = app.Services.CreateScope())
    //{
    //    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //// Verifica se já existem especialidades na DB
    //if (!dbContext.Especialidades.Any())
    //    {
    //        // Se não houver, adiciona a lista de especialidades
    //        var especialidades = new List<Especialidade>
    //        {
    //            new Especialidade { Nome = "Anatomia Patológica" },
    //            new Especialidade { Nome = "Anestesiologia" },
    //            new Especialidade { Nome = "Angiologia e Cirurgia Vascular" },
    //            new Especialidade { Nome = "Cardiologia" },
    //            new Especialidade { Nome = "Cardiologia Pediátrica" },
    //            new Especialidade { Nome = "Cirurgia Cardio-Torácica" },
    //            new Especialidade { Nome = "Cirurgia Geral" },
    //            new Especialidade { Nome = "Cirurgia Maxilo-facial" },
    //            new Especialidade { Nome = "Cirurgia Pediátrica" },
    //            new Especialidade { Nome = "Cirurgia Plástica e Reconstrutiva e Estética" },
    //            new Especialidade { Nome = "Dermato-venereologia" },
    //            new Especialidade { Nome = "Doenças Infecciosas" },
    //            new Especialidade { Nome = "Endocrinologia-Nutrição" },
    //            new Especialidade { Nome = "Estomatologia" },
    //            new Especialidade { Nome = "Farmacologia Clínica" },
    //            new Especialidade { Nome = "Gastrenterologia" },
    //            new Especialidade { Nome = "Genética Médica" },
    //            new Especialidade { Nome = "Ginecologia-Obstetrícia" },
    //            new Especialidade { Nome = "Hematologia Clínica" },
    //            new Especialidade { Nome = "Imuno-alergologia" },
    //            new Especialidade { Nome = "Imuno-hemoterapia" },
    //            new Especialidade { Nome = "Medicina Desportiva" },
    //            new Especialidade { Nome = "Medicina do trabalho" },
    //            new Especialidade { Nome = "Medicina Física e de Reabilitação" },
    //            new Especialidade { Nome = "Medicina Geral e Familiar" },
    //            new Especialidade { Nome = "Medicina Interna" },
    //            new Especialidade { Nome = "Medicina Legal" },
    //            new Especialidade { Nome = "Medicina Nuclear" },
    //            new Especialidade { Nome = "Medicina Tropical" },
    //            new Especialidade { Nome = "Nefrologia" },
    //            new Especialidade { Nome = "Neuro-Cirurgia" },
    //            new Especialidade { Nome = "Neurologia" },
    //            new Especialidade { Nome = "Neuro-Radiologia" },
    //            new Especialidade { Nome = "Oftalmologia" },
    //            new Especialidade { Nome = "Oncologia Médica" },
    //            new Especialidade { Nome = "Ortopedia" },
    //            new Especialidade { Nome = "Otorrinolaringologia" },
    //            new Especialidade { Nome = "Patologia Clínica" },
    //            new Especialidade { Nome = "Pediatria" },
    //            new Especialidade { Nome = "Pneumologia" },
    //            new Especialidade { Nome = "Psiquiatria" },
    //            new Especialidade { Nome = "Psiquiatria da Infância e da Adolescência" },
    //            new Especialidade { Nome = "Radiodiagnóstico" },
    //            new Especialidade { Nome = "Radioterapia" },
    //            new Especialidade { Nome = "Reumatologia" },
    //            new Especialidade { Nome = "Saúde Pública" },
    //            new Especialidade { Nome = "Urologia" }
    //        };

    //        dbContext.Especialidades.AddRange(especialidades);
    //        dbContext.SaveChanges();
    //    }        
    //}
app.MapControllers();
app.Run();
