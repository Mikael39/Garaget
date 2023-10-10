using Garaget.UI;
using Garaget.Vehicles;

namespace Garaget
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  IGarage garage = new Garage<IVehicle>();
            IUI ui = new ConsoleUI();

            Main main = new Main(ui);

            

            try
            {
                main.Run();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                main.Run();
            }

        }
    }
}