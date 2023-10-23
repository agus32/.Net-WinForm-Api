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
        public async static Task<IEnumerable<Alumno>> GetByDesc(string desc)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7087/api/alumno/GetByDesc/" + desc);
            var data = JsonConvert.DeserializeObject<List<Alumno>>(response);
            return data;
        }
        public async static Task<Boolean> Add(Alumno a)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7087/api/alumno", a);
            return response.IsSuccessStatusCode;
        }
        public async static Task<Boolean> Delete(Alumno a)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7087/api/alumno/" + a.DNI);
            return response.IsSuccessStatusCode;
        }
        public async static Task<Boolean> Update(Alumno a)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7087/api/alumno/" + a.DNI, a);
            return response.IsSuccessStatusCode;
        }
    }
}
