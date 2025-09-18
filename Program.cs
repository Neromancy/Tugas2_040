using System;

namespace ProyekParfum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Demonstrasi Konsep OOP pada Tema Parfum =====");
            Console.WriteLine();

            // 1. CLASS & OBJECT
            Console.WriteLine("--- 1. Membuat Object dari Class ---");
            Parfum parfumReguler = new Parfum("Sauvage", "Dior");
            ParfumEdisiTerbatas parfumLangka = new ParfumEdisiTerbatas("Aventus Absolu", "Creed", 2023);
            Aroma aromaSauvage = new Aroma("Bergamot", "Sichuan Pepper", "Ambroxan");
            Console.WriteLine("Object parfumReguler, parfumLangka, dan aromaSauvage berhasil dibuat.");
            Console.WriteLine();

            // 2. INHERITANCE & POLYMORPHISM (OVERRIDING)
            Console.WriteLine("--- 2. Demonstrasi Inheritance & Polymorphism (Overriding) ---");
            // Kedua objek memanggil method 'Deskripsi()', tetapi outputnya berbeda
            // sesuai dengan implementasi di masing-masing kelas.
            parfumReguler.Deskripsi();
            parfumLangka.Deskripsi();
            Console.WriteLine();

            // 3. COMPOSITION
            // Membuat objek 'KoleksiParfum' yang tersusun dari objek 'Parfum' dan 'Aroma'.
            Console.WriteLine("--- 3. Demonstrasi Composition ---");
            KoleksiParfum koleksiSaya = new KoleksiParfum(parfumReguler, aromaSauvage, 100);
            koleksiSaya.TampilkanDetailKoleksi();
            Console.WriteLine();

            // 4. POLYMORPHISM (OVERLOADING)
            Console.WriteLine("--- 4. Demonstrasi Polymorphism (Overloading) ---");
            // Memanggil dua versi method 'Semprot' dengan nama yang sama.
            koleksiSaya.Semprot();       // Memanggil versi tanpa parameter
            koleksiSaya.Semprot(3);      // Memanggil versi dengan parameter int
            Console.WriteLine();

            // 5. ENCAPSULATION & DATA HIDING
            // Kita tidak bisa langsung mengakses field 'merk' dari kelas Parfum karena bersifat 'private'.
            Console.WriteLine("--- 5. Demonstrasi Encapsulation & Data Hiding ---");
            Console.WriteLine($"Nama Awal: {parfumReguler.Nama}");
            parfumReguler.Nama = "Sauvage Elixir"; 
            Console.WriteLine($"Nama Baru: {parfumReguler.Nama}"); 
            Console.WriteLine($"Merk: {parfumReguler.Merk}");
            Console.WriteLine();

            Console.WriteLine("Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        } 
    }
}