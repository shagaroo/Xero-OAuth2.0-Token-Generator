using System;
using System.Windows.Forms;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace XeroSample.TokenGenerator
{
    // https://stackoverflow.com/questions/60033762/hosting-asp-net-core-api-in-a-windows-forms-application

    static class Program
    {
        public static MainForm XeroSampleMainForm { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().RunAsync();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XeroSampleMainForm = new MainForm();
            Application.Run(XeroSampleMainForm);
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
