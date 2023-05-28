using student_api.Operations;
using student_api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISchoolOperation, MbaStudentOperation>();
builder.Services.AddScoped<ISchoolOperation, BtechStudentOperation>();
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

