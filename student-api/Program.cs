using student_api.Operations;
using student_api.Services;
using student_api.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISchoolOperation, SqlMbaStudentOperation>();
builder.Services.AddScoped<ISchoolOperation, SqlBtechStudentOperation>();
builder.Services.AddDbContext<StudentdbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("StudentDetailsContext"))
    );
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseAuthorization();

app.MapControllers();

app.Run();

