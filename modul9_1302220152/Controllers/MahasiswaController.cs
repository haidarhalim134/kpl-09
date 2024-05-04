using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302220152.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Haidar", "1302220152", new List<string>{"kpl", "pbo"}, 2022),
            new Mahasiswa("Kyntar", "130222----", new List<string>{"kpl", "pbo"}, 2022),
            new Mahasiswa("Yoga", "130222----", new List<string>{"kpl", "pbo"}, 2022),
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            //return JsonSerializer.Serialize(ListMahasiswa);
            return ListMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            //return JsonSerializer.Serialize(ListMahasiswa[id]);
            return ListMahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
           // Console.WriteLine(value);
           // var options = new JsonSerializerOptions
            //{
            //    IncludeFields = true,
//};
            //var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(value, options);
            ListMahasiswa.Add(value);
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMahasiswa.RemoveAt(id);
        }
    }
}
