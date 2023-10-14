using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApi.Models;
using Newtonsoft.Json;



namespace Negocio
{
    public class AlumnoNegocio
    {
        public async static Task<IEnumerable<Alumno>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7087/api/alumno");
            var data = JsonConvert.DeserializeObject<List<Alumno>>(response);
            return data;
        }

    }
}
// hecho hasta diap 7 https://drive.google.com/file/d/1rUydoORVQA6VMV3A-PvMd7sx1VvvXPzq/edit