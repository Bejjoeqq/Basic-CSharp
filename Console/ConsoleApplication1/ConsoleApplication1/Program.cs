using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char lagi;
            int pilihan, saldo = 0;
            string jlhsaldo;
            string[] transaksi = new string[0];
            int[] nilai = new int[0];
            int[] sisa = new int[0];
            ConsoleKeyInfo keyinfo;
            do
            {
                Clear();
                WriteLine(new string(' ', (30 - "Bank Sejahtera".Length) / 2) + "Bank Sejahtera");
                WriteLine("Saldo and : "+saldo);
                WriteLine(new string('=', 30));
                WriteLine("S.Setor");
                WriteLine("T.Tarik");
                WriteLine("H.Histori");
                WriteLine(new string('=', 30));
                Write("Masukkan kode [S/T/H] : ");
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.S)
                {
                    Array.Resize(ref transaksi, transaksi.Length + 1);
                    Array.Resize(ref nilai, nilai.Length + 1);
                    Array.Resize(ref sisa, sisa.Length + 1);
                    transaksi[transaksi.GetUpperBound(0)] = "Setor";
                    Write("\nMasukkan nilai setor: ");
                    nilai[nilai.GetUpperBound(0)] = int.Parse(ReadLine());
                    saldo += nilai[nilai.GetUpperBound(0)];
                    sisa[sisa.GetUpperBound(0)] = saldo;
                }
                else if (keyinfo.Key == ConsoleKey.T)
                {
                    Array.Resize(ref transaksi, transaksi.Length + 1);
                    Array.Resize(ref nilai, nilai.Length + 1);
                    Array.Resize(ref sisa, sisa.Length + 1);
                    transaksi[transaksi.GetUpperBound(0)] = "Tarik";
                    Write("\nMasukkan nilai penarikan: ");
                    nilai[nilai.GetUpperBound(0)] = int.Parse(ReadLine());
                    saldo -= nilai[nilai.GetUpperBound(0)];
                    sisa[sisa.GetUpperBound(0)] = saldo;
                }
                else if (keyinfo.Key == ConsoleKey.H)
                {
                    WriteLine("\nTransaksi\tNilai\t\tSisa Saldo");
                    WriteLine(new string('=', 50));
                    for (int i = 0; i < transaksi.Length; i++)
                    {
                        WriteLine(transaksi[i] + "\t\t" + nilai[i].ToString("Rp#,##0.00") + "\t" + sisa[i].ToString("Rp#,##0.00"));
                    }
                    WriteLine(new string('=', 50));
                }
            } while (keyinfo.Key != ConsoleKey.Escape);
        }
    }
}
