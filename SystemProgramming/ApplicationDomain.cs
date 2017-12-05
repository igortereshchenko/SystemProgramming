using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming
{
    class ApplicationDomain
    {
        public static void DomainInfo()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine("Name: {0}", domain.FriendlyName);
            Console.WriteLine("Base Directory: {0}", domain.BaseDirectory);
            Console.WriteLine();

            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
                Console.WriteLine(asm.GetName().Name);

            Console.ReadLine();
        }


        public static void WorkWithDomain()
        {
            AppDomain secondaryDomain = AppDomain.CreateDomain("Secondary domain");
            
            secondaryDomain.AssemblyLoad += Domain_AssemblyLoad;
            
            secondaryDomain.DomainUnload += SecondaryDomain_DomainUnload;


            Console.WriteLine("Domain: {0}", secondaryDomain.FriendlyName);
            secondaryDomain.Load(new AssemblyName("System.Data"));

            Assembly[] assemblies = secondaryDomain.GetAssemblies();
            foreach (Assembly asm in assemblies)
                Console.WriteLine(asm.GetName().Name);
            
            AppDomain.Unload(secondaryDomain);
            Console.ReadLine();
        }


        private static void Domain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine("Domain_AssemblyLoad");
        }  
        
        private static void SecondaryDomain_DomainUnload(object sender, EventArgs e)
        {
            Console.WriteLine("SecondaryDomain_DomainUnload");
        }

        
    }
}
