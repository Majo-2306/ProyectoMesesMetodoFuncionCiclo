namespace ProyectoMesesMetodoFuncionCiclo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Pon un número del 1 al 12");
                string[] mes = new string[12];

                Console.ForegroundColor = ConsoleColor.Green;
                mes[0] = "Enero";
                mes[1] = "Febrero";
                mes[2] = "Marzo";
                mes[3] = "Abril";              
                mes[4] = "Mayo";
                mes[5] = "Junio";
                mes[6] = "Julio";
                mes[7] = "Agosto";
                mes[8] = "Septiembre";
                mes[9] = "Octubre";
                mes[10] = "Noviembre";
                mes[11] = "Diciembre";

                string input = Console.ReadLine();
                int.TryParse(input, out int result);

                if (result > 0 && result <= 12)
                {
                    Console.WriteLine(mes[result - 1]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unicamente pon números del 1 al 12");
                }
                Console.WriteLine();


            } while (true);
        }
    }

}