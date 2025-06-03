
using espacio.Tarea;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Tarea> tareasPendientes = new List<Tarea>();
        List<Tarea> tareasRealizada = new List<Tarea>();

        Random random = new Random();
        int numeroAleatorio = random.Next(1,9);
        for (int i = 0; i < numeroAleatorio; i++)
        {
            tareasPendientes.Add(new Tarea(i,"tarea "+i,34));
            Console.WriteLine(tareasPendientes[i].Descripcion);
        }

        Console.WriteLine("1-Agregar una tarea \n 2-Borrar tarea \n 3-Mostrar tareas pendientes \n 4-Mostrar tareas Realizadas \n Ponga su Respuesta:");

/*          do
        {
            
            numeroAleatorio--;
        } while (numeroAleatorio != 0); */
    }  
}