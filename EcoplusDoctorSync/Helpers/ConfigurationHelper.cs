using EcoplusDoctorSync.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoplusDoctorSync.Helpers
{
    public static class ConfigurationHelper
    {
        static readonly string m_sCfgFilePath = (Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\EcoPlusDoctorSync.json");

        public static Root ReadValue()

        {

            Root root = new Root();

            if (File.Exists(m_sCfgFilePath))
            {
                try
                {
                    string json = File.ReadAllText(m_sCfgFilePath);

                    root = JsonConvert.DeserializeObject<Root>(json);


                }
                catch (Exception ex)
                {
                    //                
                }
            }
            return root;

        }


        public static void WriteJsonFile(Root root)
        {

            try
            {
                string json = JsonConvert.SerializeObject(root, Formatting.Indented);

                // Verificar se o arquivo já existe e, se sim, sobrescrevê-lo
                if (File.Exists(m_sCfgFilePath))
                {
                    File.WriteAllText(m_sCfgFilePath, json);
                    //      Console.WriteLine("Arquivo JSON sobrescrito com sucesso!");
                }
                else
                {
                    File.WriteAllText(m_sCfgFilePath, json);
                    //      Console.WriteLine("Arquivo JSON criado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                //               Console.WriteLine($"Ocorreu um erro ao salvar o arquivo JSON: {ex.Message}");
            }




            //            try
            //            {
            //                string json = JsonConvert.SerializeObject(root, Formatting.Indented);
            //                File.WriteAllText(m_sCfgFilePath, json);
            ////                Console.WriteLine("Arquivo JSON salvo com sucesso!");
            //            }
            //            catch (Exception ex)
            //            {
            // //               Console.WriteLine($"Ocorreu um erro ao salvar o arquivo JSON: {ex.Message}");
            //            }
        }
    }
}
