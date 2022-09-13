using System;
using System.Linq;
using System.Collections.Generic;

public class listMobil
{
	public int IDRegistrasi { get; set; }
	public string Tipe { get; set; }
	public string Merk { get; set; }
	public string Varian { get; set; }
}
public class Program
{
	public static void Main(string[] args)
	{
		IEnumerable<listMobil> ListMobil = new listMobil[] {
			 new listMobil {
				 IDRegistrasi = 0001, Tipe = "Sedan", Merk = "Toyota", Varian = "FT86"
			 },
			 new listMobil {
				 IDRegistrasi = 0002, Tipe = "SUV", Merk = "Toyota", Varian = "RAV4"
			 },
			 new listMobil {
				 IDRegistrasi = 0003, Tipe = "Sedan", Merk = "Honda", Varian = "Accord"
			 },
			 new listMobil {
				 IDRegistrasi = 0004, Tipe = "SUV", Merk = "Honda", Varian = "CRV"
			 },
			 new listMobil {
				 IDRegistrasi = 0005, Tipe = "Sedan", Merk = "Honda", Varian = "City"
			 },
		 };
		// Isi code dibawah
		//Pertanyaan:
		//1.Tampilkan data pertama yang memiliki merk "Honda"
		//2.Tampilkan data terakhir yang memiliki merk "Honda" dan bertipe "Sedan"
		//3.Tampilkan data pertama yang memiliki merk "Honda" dan punya varian "City"
		//4.Tampilkan data default yang memiliki merk "Toyota"
		//5.Tampilkan 3 data apa saja
		//Format tampilan : IDRegistrasi, Merk, Varian

		var q1 = ListMobil.Where(x => x.Merk == "Honda").FirstOrDefault();
		var q2 = ListMobil.Where(x => x.Merk == "Honda" && x.Tipe == "Sedan").LastOrDefault();
		var q3 = ListMobil.Where(x => x.Merk == "Honda" && x.Varian == "City").FirstOrDefault();
		var q4 = ListMobil.Where(x => x.Merk == "Toyota").ToList();
		var q5 = ListMobil.Take(3).ToList();

		Console.WriteLine("Soal 1 :");
		Console.WriteLine($"IDRegistrasi : {q1.IDRegistrasi}, Merk : {q1.Merk}, Varian : {q1.Varian}");
		Console.WriteLine("\r\nSoal 2 :");
		Console.WriteLine($"IDRegistrasi : {q2.IDRegistrasi}, Merk : {q2.Merk}, Varian : {q2.Varian}");
		Console.WriteLine("\r\nSoal 3 :");
		Console.WriteLine($"IDRegistrasi : {q3.IDRegistrasi}, Merk : {q3.Merk}, Varian : {q3.Varian}");
		Console.WriteLine("\r\nSoal 4 :");
		foreach (var car in q4) { Console.WriteLine($"IDRegistrasi : {car.IDRegistrasi}, Merk : {car.Merk}, Varian : {car.Varian}"); }
		Console.WriteLine("\r\nSoal 5 :");
		foreach (var car in q5) { Console.WriteLine($"IDRegistrasi : {car.IDRegistrasi}, Merk : {car.Merk}, Varian : {car.Varian}"); }
	}
}