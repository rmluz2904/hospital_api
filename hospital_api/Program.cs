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
    //// Verifica se j� existem especialidades na DB
    //if (!dbContext.Especialidades.Any())
    //    {
    //        // Se n�o houver, adiciona a lista de especialidades
    //        var especialidades = new List<Especialidade>
    //        {
    //            new Especialidade { Nome = "Anatomia Patol�gica" },
    //            new Especialidade { Nome = "Anestesiologia" },
    //            new Especialidade { Nome = "Angiologia e Cirurgia Vascular" },
    //            new Especialidade { Nome = "Cardiologia" },
    //            new Especialidade { Nome = "Cardiologia Pedi�trica" },
    //            new Especialidade { Nome = "Cirurgia Cardio-Tor�cica" },
    //            new Especialidade { Nome = "Cirurgia Geral" },
    //            new Especialidade { Nome = "Cirurgia Maxilo-facial" },
    //            new Especialidade { Nome = "Cirurgia Pedi�trica" },
    //            new Especialidade { Nome = "Cirurgia Pl�stica e Reconstrutiva e Est�tica" },
    //            new Especialidade { Nome = "Dermato-venereologia" },
    //            new Especialidade { Nome = "Doen�as Infecciosas" },
    //            new Especialidade { Nome = "Endocrinologia-Nutri��o" },
    //            new Especialidade { Nome = "Estomatologia" },
    //            new Especialidade { Nome = "Farmacologia Cl�nica" },
    //            new Especialidade { Nome = "Gastrenterologia" },
    //            new Especialidade { Nome = "Gen�tica M�dica" },
    //            new Especialidade { Nome = "Ginecologia-Obstetr�cia" },
    //            new Especialidade { Nome = "Hematologia Cl�nica" },
    //            new Especialidade { Nome = "Imuno-alergologia" },
    //            new Especialidade { Nome = "Imuno-hemoterapia" },
    //            new Especialidade { Nome = "Medicina Desportiva" },
    //            new Especialidade { Nome = "Medicina do trabalho" },
    //            new Especialidade { Nome = "Medicina F�sica e de Reabilita��o" },
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
    //            new Especialidade { Nome = "Oncologia M�dica" },
    //            new Especialidade { Nome = "Ortopedia" },
    //            new Especialidade { Nome = "Otorrinolaringologia" },
    //            new Especialidade { Nome = "Patologia Cl�nica" },
    //            new Especialidade { Nome = "Pediatria" },
    //            new Especialidade { Nome = "Pneumologia" },
    //            new Especialidade { Nome = "Psiquiatria" },
    //            new Especialidade { Nome = "Psiquiatria da Inf�ncia e da Adolesc�ncia" },
    //            new Especialidade { Nome = "Radiodiagn�stico" },
    //            new Especialidade { Nome = "Radioterapia" },
    //            new Especialidade { Nome = "Reumatologia" },
    //            new Especialidade { Nome = "Sa�de P�blica" },
    //            new Especialidade { Nome = "Urologia" }
    //        };

    //        dbContext.Especialidades.AddRange(especialidades);
    //        dbContext.SaveChanges();
    //    }        
    //}
app.MapControllers();
app.Run();
