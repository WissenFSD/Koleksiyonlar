// İlk tanışma

// HashTable koleksiyonu key ve value taşıyabilen bir koleksiyon çeşididir.
using System.Collections;
using System.Reflection.PortableExecutable;


// Boyut vermeyebiliriniz

Hashtable hashTable = new Hashtable();


// İSterseniz veredebilirsiniz
//Hashtable keyTable = new Hashtable(10);


hashTable.Add(1, "Ayşe");
hashTable.Add(2, "Ali");
hashTable.Add(3, "Elif");
hashTable.Add(4, "6");



Hashtable guidHashTable = new Hashtable();


// Guid oluşturma yaparak koleksiyonumuzun içerisine guid ile doldurduk
// Guid yazılım dünyasında sıkça kullanılan birbirini tekrar etmeyen  ve etmeyecek olan bir takım rakam ve harflerden  oluşan uzun bir katardır.
guidHashTable.Add(Guid.NewGuid(), "Ali");
guidHashTable.Add(Guid.NewGuid(), "Nadir");
guidHashTable.Add(Guid.NewGuid(), "Aykut");
guidHashTable.Add(Guid.NewGuid(), "Mehmet");
guidHashTable.Add(Guid.NewGuid(), "Ahmet");



// key ve value tutan koleksiyonların içerisine dönerken her zaman key ve value 'u alabilen bir tip ile dönmekte fayda olacaktır.
// Foreach döngüsü bir önceki örnekte olduğu gibi tek bir tip yerine key ve value alan DictionaryEntity ile döndük
foreach (DictionaryEntry item in guidHashTable)
{
    Console.WriteLine("Key : {0} Value : {1}",item.Key,item.Value);
}

// For ile dönmek ? Ödev inceleme 
//for (int i = 0; i < guidHashTable.Keys.Count; i++)
//{
//    Console.WriteLine(guidHashTable.);
//}




ICollection keys = guidHashTable.Keys;

foreach (Guid item in keys)
{
    Console.WriteLine("Key : {0}",item);


    // key'i biliyorsak value ? bilebilir miyiz ?

    // koleksiyonun içerisine [] ifadesinin içerisine key değerini verdiğimizde koleksiyon bize value değerini verecektir.
    Console.WriteLine("Value : {0}", guidHashTable[item]);

}



// Remove etmek (Key'i verilen satırın silinmesi)
hashTable.Remove(1);


Hashtable newCollection = new Hashtable();
newCollection.Add("1", "İStanbul");
newCollection.Add("2", "Ankara");



// CopyTo
DictionaryEntry[] mydizi = new DictionaryEntry[guidHashTable.Count];

// Copyto fonksiyonu bir koleksiyonu başka bir koleksiyona taşımak için kullanılır.
// copy fonksiyonu iki parametreden oluşur. 1. parametre hangi koleksiyona kopyalanacağı bilgisi
// 2. parametre ise hangi index'den itibaren koplayanacağı bilgisidir.
guidHashTable.CopyTo(mydizi, 0);




// Key değeri guid olan bir koleksiyon



//hashTable.Add(4, "Hatice"); // key yerine verilen değerler kesinlike benzersiz olmalı



