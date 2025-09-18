// Parfum.cs
namespace ProyekParfum
{
    // CLASS & OBJECT
    public class Parfum
    {
        // ENCAPSULATION & DATA HIDING
        private string merk;
        public string Nama { get; set; }
        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        // CONSTRUCTOR
        public Parfum(string nama, string merk)
        {
            this.Nama = nama;
            this.merk = merk;
        }

        // POLYMORPHISM - OVERRIDING
        public virtual void Deskripsi()
        {
            Console.WriteLine($"Parfum Regular: {Nama} oleh {Merk}");
        }
    }
}
