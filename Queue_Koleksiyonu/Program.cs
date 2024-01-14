
using System.Collections;

Queue qu = new Queue();

// FIFO ( İlk Giren İlk Çıkar) prensibini gerçekleştiren koleksiyondur.

qu.Enqueue("Halil");
qu.Enqueue("Aysel");
qu.Enqueue("Refik");
qu.Enqueue("Ahmet");


Console.WriteLine("Pide kuyruğu");
// ilk giren kim ? Halil
//foreach (string item in qu)
//{


//    Console.WriteLine("Her tuşa bastığında bir kişi kuyruktan çıkacak");
//    Console.ReadLine();

//    object kisi =qu.Dequeue();
//    Console.WriteLine("Çıkan kişi {0}", item);

//}

object kisi = qu.Dequeue();
Console.WriteLine("Çıkan kişi {0}", kisi);


object kisi1 = qu.Dequeue();
Console.WriteLine("Çıkan kişi {0}", kisi1);


object kisi2 = qu.Dequeue();
Console.WriteLine("Çıkan kişi {0}", kisi2);


//Dequeu metodu sırası geleni kuyruktan çıkartacaktır. 
//Dequeue metodu sırası geleni çıkartır ve çıkarttığı elemanı size döndürür
