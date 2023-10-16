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
        public async static Task<Boolean> Add(Alumno a)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7087/api/alumno", a);
            return response.IsSuccessStatusCode;
        }
    }
}
