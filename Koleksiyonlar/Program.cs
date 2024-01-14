


// Koleksiyon : Dizilerin gelişmişidir.

// Başlangıç değeri verilmez.
// Farklı işlere özelleşmiş koleksiyonlar vardır.


// Koleksion tanımı yapalım


// ArrayList


using System.Collections;
using System.Net;

// using System.Collection bir spacedir
// Namespaceler .nettteki sınıfların isimleri aynı olduğu durumda birbirine karışmaması için kullanılır
// aynı zamanda yazılan sınıfların bir konu ile ilişkili olması içinde kullanılır.


// object alan bir koleksiyon kullanıyorsak, her seferinde boxing ve unboxing yapmak durumunda kalabiliriz.







// object inceleme
int a = 10;

string c = "test";
object b = a;


object d = b;

// object .net dünyasının en tepesinde duran bir tiptir. Bu tip süper bir tiptir.

// içerisine istenilen tipi alabilir ve verebilir


Random rnd = new Random();

object random = rnd;


// Arraylist


// Array list en giriş seviyesi koleksiyondur. 
// İçerisine object tipinde değerler alır.
// ArayList dizilerden farklı olarak başlangıç değeri vermeyebiliriz.

// Başlangıç değeri vermez isek, default olarak kendisi başlangıç değeri atar. Bu deger 4'dür

// siz bu dört birimlik yeri kullandığınızda yani 5. elemanı eklediğinizde  boş alan iki katına çıkar. yani 8 olur
// siz 9. elemanı eklediğinizde  arraylist sizin için 16. elemana kadar boşluk oluşturur.



#region ArrayList tanışma
// Arraylist ile örnek veri girişi
//ArrayList list = new ArrayList();


//list.Add(1);
//list.Add(2);
//list.Add(3);
//list.Add(4);
//list.Add(5);


//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}


#endregion

//  Ekradan aldığımız sayınların toplamını alan bir örnek

//ArrayList list = new ArrayList();
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("{0}. değeri giriniz",i);

//    list.Add(Convert.ToInt32(Console.ReadLine()));


//    // Count : ArrayList içerisindeki eleman sayısını verir
//    Console.WriteLine("Count : {0}", list.Count);

//    // Capacity Arralist içeisinde veri girmek için açılmış olan boşluk sayısını verir
//    Console.WriteLine("Capasity : {0}", list.Capacity);

//}



//// ArrayList'în fonksiyonları nelerdir.

//// ToArray ile ArrayList'i object dizisine çevirebiliyoruz
//object[] pbjectDizi = list.ToArray();



//// Koleksiyonu sıralamak için kullanılır.
////list.Sort();



//// Arama yapmak için  değerin bulunduğu index numarasını size dönecektir.

//int indexNo = list.BinarySearch(9);


//// TrimToSize

////Capasity'i count'a eşitler
//list.TrimToSize();


//// Koleksiyonu ters çevirir
//list.Reverse();



//ArrayList yeniList = new ArrayList();
//yeniList.Add(100);
//yeniList.Add(105);


////AddRange bir koleksiyonun içerisine başka bir koleksiyonu eklemek için kullanılır.(Her zaman sona eklenir)

////list.AddRange(yeniList);


//// InsertRange
//// Koleksiyonun içerisine başka bir koleksiyonu belirli bir indexten sonraya yetleştirmesine izin verir.

//list.InsertRange(3, yeniList);






// ArrayList farklı oluşturma şekli

ArrayList testList = new ArrayList {

    1,5,9,3,6,4,8,6,4,8,1,2,3,8,


};

ArrayList insertedArrayList = new ArrayList() {

100,105,110
};

// Koleksiyon içerisinde arama
// LastIndexOf bir koleksiyonun içerisine aranan öğenin index numarasını verir, koleksiyon içierisine 2 adet aynı elemandan varsa, son elemanın index numarasını verir, aradığımız eleman yok ise bize -1 döner


// 7 elemanını aradık ve listede olmadığı için -1 verdi
//int indexNo = testList.LastIndexOf(7);



// 1 değerinin olduğu son index numarasını verecektir
//int indexNo = testList.LastIndexOf(1);





// SetRange

// Bu fonksiyon bir koleksiyonun içerisine başka bir koleksiyonu aktarırken koleksiyonın içeisindeki öğelerin silinip silinmesini umursamaz
//testList.SetRange(3, insertedArrayList);


//GetRange
// Koleksionun içerisinden istenilen indexden başlayıp istediğimiz adet elemanı array olarak getirek bir fonksiyondur
//ArrayList newList = testList.GetRange(2, 3);



// Contains

// Contains koleksiyon içerisinde arama yapmaktadır. Aradığımız değer koleksiyon içerinde var true yok ise false değer üreteccektir.
//bool isNotOk = testList.Contains(100);


//bool isOk = testList.Contains(6);

//Console.ReadLine();



// Foreach döngüsü 

// Sonu belli olmayan öğelerin içerisine dönebilmektedir. // For döngüsünden farklı budur


// for döngüsünde in ifadesi ile başlayan yere hangi koleksiyonun içerisinde döneceğimizi belirtiliriz
// koleksiyon içerisinde hangi tipten veri var ise int item yazılan yere o değer yazılmalıdır.
//foreach(int item in testList)
//{
//    Console.WriteLine(item);

//}
//Console.ReadLine();



// Ekrandan 10 adet string metin alın
// bu metinlerin bir arraylist koleksiyonunda tutun 
// elemanları aldıktan sonra son elemanları foreach ile ekrana yazdırın

//ArrayList stringArray = new ArrayList();
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("metin gir");
//    stringArray.Add(Console.ReadLine());

    
//}

// veri alma tamamlandı


// İçerisinde string olan bir koleksiyonun içerisinde foreach döngüsü ile dönme
//foreach (string item in stringArray)
//{
//    Console.WriteLine(item);
//}


int[] copied = new int[testList.Count];
testList.CopyTo(copied, 0);


Console.ReadLine();