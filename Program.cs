using System.Text.Json;

namespace Valyuta_TG
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            const string link = ("6332306275:AAGI4-wfyfvaP-ldH-YWFDzSIbG1KpgZ_Ew");

            System_valyuta system_Valyuta = new System_valyuta(link);
            await system_Valyuta.BotHandle();

            try
            {
                await system_Valyuta.BotHandle();

            }
            catch (Exception ex)
            {
                throw new Exception("Xatoku!");
            }
        }
    }
}