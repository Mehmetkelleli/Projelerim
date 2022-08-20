using nesneodev.Data.Concrete;
using nesneodev.Model;
using System;

namespace nesneodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var data = new TaskRepository();
                Console.WriteLine("Veritabanı Yönetim Programı");
                Console.WriteLine("***************************");
                Console.WriteLine(
                    "1 => Ekle\n" +
                    "2 => Listele\n" +
                    "3 => Getir\n" +
                    "4 => Sil\n" +
                    "5 => Güncelle"
                    );
                Console.WriteLine("***************************\n");
                Console.Write("Seçim : ");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 1)
                {

                    var a = new Task();
                    Console.Write("Adını Gir : ");
                    string Name = (Console.ReadLine());
                    a.Name = Name;
                    Console.Write("Durumunu Gir : ");
                    int Durum = int.Parse(Console.ReadLine());
                    if (Durum == 1)
                    {
                        a.Active = true;
                    }
                    else
                    {
                        a.Active = false;
                    }
                    data.Create(a);
                    Console.WriteLine("Veri Eklendi");

                }
                else if (secim == 2)
                {
                    foreach (var item in data.GetAll())
                    {
                        Console.WriteLine($"Id = {item.Id} Görev Adı = {item.Name} Durum = {item.Active}");
                    }
                }
                else if (secim == 3)
                {
                    Console.Write("Getirilecek İş Id'sini Giriniz :");
                    int id = int.Parse(Console.ReadLine());
                    var item = data.GetById(id);
                    Console.WriteLine($"Id = {item.Id} Görev Adı = {item.Name} Durum = {item.Active}");
                }
                else if (secim == 4)
                {
                    Console.Write("Silinecek İş Id'sini Giriniz :");
                    int id = int.Parse(Console.ReadLine());
                    data.Delete(id);
                    Console.WriteLine("Silme işlemi Tamamlandı");
                }
                else if (secim == 5)
                {
                    Console.WriteLine("Veritabanı Güncelle");
                    Console.WriteLine("***************************");
                    Console.Write("Id Seç : ");
                    int Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("***************************");
                    Console.WriteLine(
                        "1 => Adı Güncelle\n" +
                        "2 => Durum Güncelle\n"
                        );
                    Console.WriteLine("***************************\n");
                    Console.Write("Seçim : ");
                    int sec = int.Parse(Console.ReadLine());
                    switch (sec)
                    {
                        case 1:
                            var a = data.GetById(Id);
                            Console.Write("Adını Gir : ");
                            string Name = (Console.ReadLine());
                            a.Name = Name;
                            data.Update(a);
                            break;
                        case 2:
                            var b = data.GetById(Id);
                            Console.Write("Adını Gir : ");
                            int Active1 = int.Parse(Console.ReadLine());
                            if (Active1 == 1)
                            {
                                b.Active = true;
                            }
                            else
                            {
                                b.Active = false;
                            }
                            data.Update(b);
                            break;
                        default:
                            Console.WriteLine("Hatalı Giriş");
                            break;
                    }

                }
            }

        }
    }
}
