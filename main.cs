for(int i = 0; i < 60;)
{
b:;
    if (i == 60)
    {
        goto a;
        //dakika 60'a ulaşınca a konumuna gider
    }
    else
    {
        for(int j = 0; j <= 60;) 
        { 
        if (j == 60)
            {
                i++;
                j = 0;
                goto b;
                //i(dakika) sayısını arttırıp j(saniye) sayısını sıfırlar ve b konumuna gider
            }
        else
          {
                System.Threading.Thread.Sleep(1000);
                j++;
                Console.Clear();
                Console.WriteLine(i + ":" + j);
                //j(saniye) sayısını arttırdıktan sonra konsolu temizler ve ekrana dakika : saniye şeklinde yazar

          }

        }
    }


}
a:;
Console.Clear();
//konsolu temizler
Console.WriteLine("0:0");
//ekrana 0:0 yazdırır 
Console.WriteLine("kodumuz bu kadardı");
//ekrana kodumuz bu kadardı yazdırır
Console.ReadKey();
//klavyeden tuş girilmesini bekler
