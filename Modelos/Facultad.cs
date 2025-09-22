using System;

namespace Variables.Modelos
{
    public class Facultad
    {
        public string Nombre;
        public String Codigo;
        public String MostrarDatos()
        {
            return "Facultad " + Nombre + ", Código: " + Codigo;
        }
    }
}
