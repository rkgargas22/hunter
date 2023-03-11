using FluentValidation;
using Tmf.Logs;
using Tmf.Hunter.Api.Middleware;
using Tmf.Hunter.Api.Validations;
using Tmf.Hunter.Core.Options;
using Tmf.Hunter.Core.RequestModels;
using Tmf.Hunter.Infrastructure.HttpServices;
using Tmf.Hunter.Infrastructure.Interfaces;
using Tmf.Hunter.Infrastructure.Services;
using Tmf.Hunter.Manager.Interfaces;
using Tmf.Hunter.Manager.Services;
//namespace Tmf.Hunter.Api
//{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddHttpClient();

            builder.Services.Configure<HunterOptions>(builder.Configuration.GetSection(HunterOptions.Hunter));
            builder.Services.Configure<ConnectionStringsOptions>(builder.Configuration.GetSection(ConnectionStringsOptions.ConnectionStrings));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IHttpServices, HttpServices>();

            builder.Services.AddScoped<IHunterRepository, HunterRepository>();

            builder.Services.AddScoped<IHunterManager, HunterManager>();
            builder.Services.AddScoped<IValidator<ValidateCustomerRequest>, ValidationCustomerValidator>();
            builder.Services.AddScoped<IValidator<contacts>, ContactsValidator>();
            builder.Services.AddScoped<IValidator<identityDocuments>, IdentityDocumentsValidator>();

            builder.Services.AddScoped<IValidator<TaskDetailRequest>, TaskDetailValidator>();

            builder.Services.AddSingleton<ILog, Log>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseMiddleware<GlobalErrorHandlingMiddleware>();
            app.UseMiddleware<AuthMiddleware>();
            app.UseMiddleware<RequestResponseLoggingMiddleware>();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
    //    }
    //}
//}