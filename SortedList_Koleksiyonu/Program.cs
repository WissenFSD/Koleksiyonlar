// See https://aka.ms/new-console-template for more information

using System.Collections;


SortedList sorted =new SortedList();
sorted.Add("06", "Ankara");
sorted.Add("34", "İstanbul");
sorted.Add("02", "Adıyamaman");
sorted.Add("01", "Adana");


// yeni eleman ekleme(Key alanı benzersiz olmalıdır.)
//sorted.Add("01", "Adanaa");


// int olarak giriyoruz(Veri bütünlüğünü korumamız gerekmektedir.)
//sorted.Add(1, "Elma");


// Değer güncelleme yapılabilir.
sorted["01"] = "Bursa";


// SortedList sıralı liste koleksiyonudur. İçerisine eklenen elemanları sıraya göre dizer. En küçük eleman her zaman koleksiyonun en üst sırasında yer almakdadır
// Ekrana yazdırma
foreach (DictionaryEntry item in sorted)
{
    Console.WriteLine("{0}- {1}",item.Key,item.Value);
}


