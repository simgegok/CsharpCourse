using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNotes
{
    public class Syntax

    {
        static void Main(string[] args) 
        {
            Console.WriteLine();
        
        }    
    
        /* 1.using System : Bu alanda belirtilen isimdeki sınıfların kullanılabileceği anlamına gelir.
         * 2.namespace : Kodu düzenlemek için kullanılır. Sınıflar ve diğer ad alanları için bir kapsayıcıdır.
         * * C# boşlukları yok sayar. Birden fazla boş satır kodun daha okunaklı olmasını sağlar.
         * 3.Süslü Parantezler {} : Kod bloğunun başlangıç ve sonunu belirtir.
         * 4.Class : Programa işlevsellik kazandıran veri ve yöntemler için bir kapsayıcıdır. SOLID'e göre düzen açısından bu durum
         gereklidir.
         * 5.Console.WriteLine() : Çıktı almak/ yazdırmak için kullanılan yöntemdir.
         * * Her C# ifadesi noktalı virgülle (;) biter.
         * * C# büyük/ küçük harfe duyarlıdır. 
         */ 

        /* SOLID Prensipleri;
         
         S - Tek Sorumluluk Prensibi(Single Responsibility Principle - SRP)
        *Her sınıfın ayrı sorumluluğu olmalıdır. Bu ilkeye uyum sağlamak daha temiz, düzenli ve esnek bir kod tabanı oluşturmayı
        amaçlar.
         
         O - Açık/ Kapalı Prensibi(Open/ Closed Principle - OCP)
        *Bu ilke, birimler arasındaki iletişimin mümkün olduğunca açık ve anlaşılır olması gerektiğini ifade eder.
        *Yani bir birim bir kez oluşturulduğunda bu birim değiştirilmemeli veya kırılmamalıdır.
        *Bu ilkenin amacı; kodun yeniden kullanılabilirliğini ve sürdürülebilirliğini artırmaktır.
        
         L - Liskov Yerine Geçme Prensibi(Liskov Substitution Principle - LSP)
        *Bir yazılımın alt sınıflarının, üst sınıflarının yerine kullanılabilmesi gerektiğini ifade eder.
        *Yani bir üst sınıfın nesnesinin alt sınıfın nesnesiyle değiştirildiğinde sistemde herhangi bir hata, tutarsızlık veya
        beklenmeyen davranış olmamalıdır.

         I - Arayüz Ayrımı Prensibi(Interface Segregation Principle - ISP)
        *Bir arayüzün mümkün olduğunca özelleştirilmiş ve bağımsız olması gerektiğini belirtir. Bu prensip, bir sınıfın ihtiyaç 
        duymadığı metotları uygulamaktan kaçınarak, sınıfların fazla bağımlı olmadığı ve gereksiz karmaşıklığı önlediği bir tasarımı
        teşvik eder.

         D - Bağımlılık Tersine Çevirme Prensibi(Dependency Inversion Principle - DIP)
        *Yüksek seviyeli modüllerin düşük seviyeli modüllere doğrudan bağımlı olmamasını, bağımlılıkların soyutlamalar üzerinden
        yapılmasını önerir.
        *Bu prensip,daha gevşek bir bağımlılık ilişkisi oluşturarak yazılımın esnekliğini ve genişletilebilirliğini artırır.
        */
       

        /* Comments (Açıklamalar)
         
        - Tek satırlık yorumlar iki eğik çizgiyle (//) yapılır.

        - Çok satırlı yorumlar ("/*") ile başlar ve yıldız slash ile biter. (Burada olduğu gibi.) */
        
    }
}
