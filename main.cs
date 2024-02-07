for(int dakika = 0; dakika < 60;)
{
b:;
    if (dakika == 60)
    {
        goto a;
        //dakika 60'a ulaşınca a konumuna gider
    }
    else
    {
        for(int saniye = 0; saniye <= 60;) 
        { 
        if (saniye == 60)
            {
                dakika++;
                saniye = 0;
                goto b;
                //dakika sayısını arttırıp saniye sayısını sıfırlar ve b konumuna gider
            }
        else
          {
                System.Threading.Thread.Sleep(1000);
                saniye++;
                Console.Clear();
                Console.WriteLine(dakika + ":" + saniye);
                //saniye sayısını arttırdıktan sonra konsolu temizler ve ekrana dakika : saniye şeklinde yazar

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
