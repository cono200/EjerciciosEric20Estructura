using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEric20Estructura
{
    internal class EstructuraControl
    {
        public string DiaSemana(int dia)
        {
            string semana;

            switch (dia)
            {
                case 1:
                    dia = 1;
                    semana = "Domingo";
                    break;
                case 2:
                    dia=2;
                    semana = "Lunes";
                    break;
                    case 3:
                    dia = 4;
                    semana = "Martes";
                    break;
                    case 4:
                    dia = 5;
                    semana = "Miercoles";
                    break;
                    case 5:
                    dia = 6;
                    semana = "Jueves";
                    break;
                    case 6:
                    dia = 7;
                    semana = "Viernes";
                    break;
                    case 7:
                    dia = 8;
                    semana = "Sabado";
                    break;
                    default: semana = "No existe ese dia karnal, no inventes cosas";
                    break;
            }
            return semana;


        }



    }
}
