// KoleksiParfum.cs
namespace ProyekParfum
{
    // CLASS & OBJECT
    public class KoleksiParfum
    {
        // COMPOSITION
        // Kelas 'KoleksiParfum' "memiliki" sebuah objek 'Parfum' dan 'Aroma'.
        public Parfum DetailParfum { get; private set; }
        public Aroma DetailAroma { get; private set; }
        public int VolumeMiliLiter { get; private set; }

        // CONSTRUCTOR
        public KoleksiParfum(Parfum parfum, Aroma aroma, int volume)
        {
            DetailParfum = parfum;
            DetailAroma = aroma;
            VolumeMiliLiter = volume;
        }

        public void TampilkanDetailKoleksi()
        {
            DetailParfum.Deskripsi(); 
            Console.WriteLine("Detail Aroma:");
            DetailAroma.TampilkanAroma();
            Console.WriteLine($"Volume: {VolumeMiliLiter} ml");
        }

        // POLYMORPHISM - OVERLOADING
        // Method 'Semprot' pertama tanpa parameter.
        public void Semprot()
        {
            Console.WriteLine("Anda menyemprotkan parfum sekali.");
        }

        // Method 'Semprot' kedua dengan parameter integer.
        // Nama method sama, tetapi daftar parameternya berbeda.
        public void Semprot(int jumlahSemprotan)
        {
            Console.WriteLine($"Anda menyemprotkan parfum sebanyak {jumlahSemprotan} kali.");
        }
    }
}