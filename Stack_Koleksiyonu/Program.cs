// See https://aka.ms/new-console-template for more information

using System.Collections;


// İlk Giren son çıkar koleksiyonu(FİLO)
Stack stack = new Stack();


// Push metodu koleksiyona ekleme yapacaktır.
stack.Push("Renault");
stack.Push("Audi");
stack.Push("BMW");

Console.WriteLine("Koleksiyonumun eleman değeri : {0}",stack.Count);


// Peek metodu bize bir sonraki silinecek olan değeri verir.Peek metodu koleksiyondan araba çıkartmaz. Sadece çıkacak olanı söyler.
// Listenin içi boşken peek çalıştırılırsa exception verir.
string cikacakAraba = stack.Peek().ToString();


// Pop listeden elemanı çıkartacaktır. 
string cikanAraba=stack.Pop().ToString();

Console.WriteLine(cikacakAraba);





