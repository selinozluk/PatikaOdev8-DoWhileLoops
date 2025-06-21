// WHILE DÖNGÜSÜ

int counter = 0; // sayaç değişkeni

Console.Write("Bir limit giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

// sayaç girilen limitten küçük ya da eşitse döngüye girer
while (counter <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    counter++;
}

/*
0'dan başlayacağı için girilen değerin 1 fazlası kadar, yazılan cümleyi çıktı verecek

girilen değer 0'dan küçük ise döngü hiç çalışmaz çünkü başlangıç değeri 0,
limit ise daha küçük olursa koşul en başta sağlanmadığı için döngüye hiç girilmez

while döngüsünde koşul döngünün başında kontrol edilir bu yüzden döngü bazı durumlarda hiç çalışmayabilir
*/


// DO WHILE DÖNGÜSÜ

int counter2 = 0; // yine sayaç 0'dan başlar

// kullanıcıdan limit değeri alınır ve limit değişkenine atanır
Console.Write("Bir limit giriniz: ");
int limit2 = Convert.ToInt32(Console.ReadLine());


do
{
    // ilk seferde şart kontrol edilmeden girilen cümleyi çıkartır ve sayaç ile değer arttırılır
    Console.WriteLine("Ben bir Patika'lıyım");
    counter++;
} while (counter <= limit); // burada şart kontrol edilir, koşul sağlanıyorsa döngü devam eder, devam etmiyorsa döngü biter

/*
while döngüsündeki gibi 0'dan başlayacağı için girilen değerin 1 fazlası kadar, yazılan cümleyi çıktı verecek

0'dan küçük bir değer girilse bile "Ben bir Patika'lıyım" 1 kez yazdırılır çünkü
do-while döngüsü koşulu en sonda kontrol eder (do-while döngüsü her zaman en az bir kez çalışır)

*/



