using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentManagementSystem.Context;
using StudentManagementSystem.Contracts;
using StudentManagementSystem.Repository;
using System;

namespace StudentManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddControllers();
            services.AddScoped<IStudentRepository, StudentService>();
            services.AddScoped<ITeacherRepository, TeacherService>();
            services.AddScoped<ICourseRepository, CourseService>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddMvc(options =>
            {
                options.SuppressAsyncSuffixInActionNames = false;
            }).AddSessionStateTempDataProvider();
            services.AddMvcCore();
            services.AddAuthentication();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".TestApp.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(30);
                options.Cookie.IsEssential = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();            
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });

        
           
        }
    }
}
