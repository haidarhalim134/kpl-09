namespace modul9_1302220152
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string NIM { get; set; }

        public List<string> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(string nama, string nim, List<string> course, int year) 
        {
            Name = nama;
            NIM = nim;
            Course = course;
            Year = year;
        }
    }
}
