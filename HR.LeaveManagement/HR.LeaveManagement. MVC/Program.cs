using HR.LeaveManagement._MVC.Contracts;
using HR.LeaveManagement._MVC.Services;
using HR.LeaveManagement._MVC.Services.Base;
using HR.LeaveManagement.MVC.Services.Base;
using System.Reflection;
namespace HR.LeaveManagement._MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpClient <HR.LeaveManagement._MVC.Services.Base.IClient, HR.LeaveManagement._MVC.Services.Base.Client > (cl=>
            cl.BaseAddress = new Uri("https://localhost:44354"));

            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddScoped<ILeaveTypeService, LeaveTypeService>();
            builder.Services.AddScoped<ILeaveAllocationService, LeaveAllocationService>();
            builder.Services.AddScoped<ILeaveRequestService, LeaveRequestService>();

            builder.Services.AddSingleton<ILocalStorageService, LocalStorageService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
