// Program.cs
using System;
using System.Collections.Generic; // Diperlukan untuk menggunakan List

namespace ProyekParfum
{
    class Program
    {

        // Dideklarasikan sebagai 'static' agar bisa diakses di seluruh metode dalam kelas Program.
        static List<KoleksiParfum> daftarKoleksi = new List<KoleksiParfum>();

        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("  Selamat Datang di Aplikasi Koleksi Parfum");
            Console.WriteLine("======================================");
            Console.WriteLine();


            while (true)
            {
                TampilkanMenu();
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        TambahParfumBaru();
                        break;
                    case "2":
                        TampilkanSemuaKoleksi();
                        break;
                    case "3":
                        Console.WriteLine("Terima kasih telah menggunakan aplikasi. Sampai jumpa!");
                        return; // Keluar dari aplikasi
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        TekanUntukLanjut();
                        break;
                }
            }
        }

        static void TampilkanMenu()
        {
            Console.Clear(); 
            Console.WriteLine("--- MENU UTAMA ---");
            Console.WriteLine("1. Tambah Parfum Baru ke Koleksi");
            Console.WriteLine("2. Tampilkan Semua Koleksi Parfum");
            Console.WriteLine("3. Keluar");
            Console.Write("Masukkan pilihan Anda (1-3): ");
        }

        static void TambahParfumBaru()
        {
            Console.Clear();
            Console.WriteLine("--- TAMBAH PARFUM BARU ---");

            Parfum parfumBase; 

            Console.Write("Apakah ini edisi terbatas? (y/n): ");
            string jenis = Console.ReadLine().ToLower();

            Console.Write("Masukkan Nama Parfum: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan Merk Parfum: ");
            string merk = Console.ReadLine();

            if (jenis == "y")
            {
                Console.Write("Masukkan Tahun Rilis: ");
                // Validasi input agar hanya angka yang diterima
                if (int.TryParse(Console.ReadLine(), out int tahun))
                {
                    // Membuat objek dari kelas turunan (Inheritance)
                    parfumBase = new ParfumEdisiTerbatas(nama, merk, tahun);
                }
                else
                {
                    Console.WriteLine("Input tahun tidak valid. Kembali ke menu utama.");
                    TekanUntukLanjut();
                    return;
                }
            }
            else
            {
                // Membuat objek dari kelas dasar
                parfumBase = new Parfum(nama, merk);
            }

            Console.WriteLine("\n--- Masukkan Detail Aroma ---");
            Console.Write("Top Note: ");
            string topNote = Console.ReadLine();
            Console.Write("Middle Note: ");
            string middleNote = Console.ReadLine();
            Console.Write("Base Note: ");
            string baseNote = Console.ReadLine();

            // Membuat objek Aroma (untuk Composition)
            Aroma aroma = new Aroma(topNote, middleNote, baseNote);

            Console.Write("\nMasukkan Volume (ml): ");
            if (int.TryParse(Console.ReadLine(), out int volume))
            {
                // Membuat objek KoleksiParfum yang "menggabungkan" objek Parfum dan Aroma
                KoleksiParfum koleksiBaru = new KoleksiParfum(parfumBase, aroma, volume);
                daftarKoleksi.Add(koleksiBaru);

                Console.WriteLine("\nParfum baru berhasil ditambahkan ke koleksi!");
            }
            else
            {
                Console.WriteLine("Input volume tidak valid. Kembali ke menu utama.");
            }

            TekanUntukLanjut();
        }

        static void TampilkanSemuaKoleksi()
        {
            Console.Clear();
            Console.WriteLine("--- SEMUA KOLEKSI PARFUM ANDA ---");

            if (daftarKoleksi.Count == 0)
            {
                Console.WriteLine("Koleksi Anda masih kosong.");
            }
            else
            {
                int nomor = 1;
                foreach (var koleksi in daftarKoleksi)
                {
                    Console.WriteLine($"\n--- Parfum #{nomor} ---");
                    // Jika objeknya adalah ParfumEdisiTerbatas, method Deskripsi() yang di-override yang akan terpanggil.
                    koleksi.TampilkanDetailKoleksi();
                    nomor++;
                }
            }
            TekanUntukLanjut();
        }

        // Metode bantuan untuk menjeda layar
        static void TekanUntukLanjut()
        {
            Console.WriteLine("\nTekan tombol apa saja untuk melanjutkan...");
            Console.ReadKey();
        }
    }
}