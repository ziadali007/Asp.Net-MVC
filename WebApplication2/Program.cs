namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/login", () => "u r signed in!");
            //app.MapGet("/login", SignIn);
            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id=12}"
            );


            app.Run();
        }

        public static string SignIn()
        {
            return "u r signed in!";
        }
    }
}
