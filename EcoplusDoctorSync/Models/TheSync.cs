using System;
using System.Reflection;
using System.Security.Principal;

namespace EcoplusDoctorSync.Models
{
    public static class TheSync
    {
        public static Usuario UsuarioLogado { get; set; }
        public static string Estacao { get; set; }
        public static string Versao { get; set;}
        public static string UsuarioWindows { get; set;}

        public static void ObterNomeDaMaquina()
        {
            Estacao = System.Environment.MachineName;
        }

        public static void ObterNomeDoUsuarioWin()
        {
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
            
            UsuarioWindows = windowsIdentity != null ? windowsIdentity.Name : "Usuário Desconhecido";
        }

        public static void ObterVersaoDoSistema()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyFileVersionAttribute attribute = assembly.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)[0] as AssemblyFileVersionAttribute;
            
            Versao =  attribute.Version;
        }
    }
}
