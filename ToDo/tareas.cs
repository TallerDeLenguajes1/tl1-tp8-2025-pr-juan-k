using System.Reflection.Metadata.Ecma335;

namespace espacio.Tarea
{
    public class Tarea
    {
        private int tareaId;
        private string? descripcion;
        private int duracion;

        public Tarea()
        {
            this.tareaId = TareaId;
            this.descripcion = Descripcion;
            this.duracion = Duracion;
        }

        public int TareaId { get => tareaId; set => tareaId = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion 
        { 
            get => duracion; 
            set
            {
                if (duracion >=  10 && duracion <= 100)
                {
                    duracion = value;
                }
            } 
         } // Validar que esté entre 10 y 100
        
    }
    
        // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario

    }
