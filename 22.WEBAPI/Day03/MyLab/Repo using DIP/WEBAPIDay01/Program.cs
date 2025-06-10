
using Microsoft.EntityFrameworkCore;
using WEBAPIDay01.IRepositories;
using WEBAPIDay01.MapperConfig;
using WEBAPIDay01.Models;
using WEBAPIDay01.Repository;


namespace WEBAPIDay01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt="";
            var builder = WebApplication.CreateBuilder(args);

            // Student List and DB.
            builder.Services.AddScoped<IStudentRepository, StudentList>();
            //builder.Services.AddScoped<IStudentRepository, StudentDb>();


            //builder.Services.AddScoped<IDepartmentRepository, DepartmentList>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentDb>();
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(txt,
                builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            builder.Services.AddAutoMapper(typeof(MapConfig));
            builder.Services.AddDbContext<ITIDbContext>(
     options => options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("ITICon")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(op=>op.SwaggerEndpoint("/openapi/v1.json","v1"));
            }


            app.UseHttpsRedirection();


            app.UseAuthorization();

            app.UseCors(txt);
            app.MapControllers();

            app.Run();
        }
    }
}
