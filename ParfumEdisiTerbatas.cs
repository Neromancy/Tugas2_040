// ParfumEdisiTerbatas.cs
namespace ProyekParfum
{
    // INHERITANCE
    // Kelas 'ParfumEdisiTerbatas' mewarisi sifat dari kelas 'Parfum'.
    public class ParfumEdisiTerbatas : Parfum
    {
        // Properti tambahan
        public int TahunRilis { get; set; }

        // CONSTRUCTOR
        // Constructor kelas turunan yang memanggil constructor kelas dasar ('base').
        public ParfumEdisiTerbatas(string nama, string merk, int tahunRilis) : base(nama, merk)
        {
            this.TahunRilis = tahunRilis;
        }

        // POLYMORPHISM - OVERRIDING
        public override void Deskripsi()
        {
            // Memanggil method Deskripsi dari base class, lalu menambahkan informasi baru.
            Console.WriteLine($"Edisi Terbatas: {Nama} oleh {Merk} - Rilisan Tahun {TahunRilis}");
        }
    }
}