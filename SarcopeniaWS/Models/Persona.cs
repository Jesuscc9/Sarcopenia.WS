using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarcopeniaWS.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public bool Diabetes { get; set; }
        public string ActividadFisica { get; set; }
        public string Dieta { get; set; }
        public string Lesiones { get; set; }
        public bool CaidasUltimosSeisMeses { get; set; }
        public string Debilidad { get; set; }
        public bool MasDeDosMedicamentos { get; set; }
        public string ConsumoDeBebidasRegulares { get; set; }
        public string Depresion { get; set; }
        public bool ViveSola { get; set; }
        public int Hijos { get; set; }
        public int Nietos { get; set; }
        public string GrupoSocial { get; set; }
        public bool Viaja { get; set; }
        public float ApoyoPsicologico { get; set; }
        public float ValaoracionCognoscitiva { get; set; }
        public string CircunferenciaPantorilla { get; set; }
        public float CircunferenciaMediaDelBrazo { get; set; }
        public float PliegueCutaneoTriciptal { get; set; }
        public float VelocidadMarcha { get; set; }
        public float FuerzaPrensilMano { get; set; }
        public float FatigaMusuclar { get; set; }


    }
}
