using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    // virtual isteğe bağlı, istersen ezebilirsin ama abstact ezmek zorundasın. Mesela her doc farklı şekilde açılıyor bu nedenle open abstract!!!!
    public abstract class Document
    {
        //abstract yapılarda mümkün olduğu kadar birbiriyle benzeşmeyenler kullanılır.

        /*dokümanı açacak ama hepsi aynı şekilde açılmaz.bu nedenle virtual koyduk.
         virtual ile ezmesine izin verdik ama dokümanı miras alana göre de açılmasının nasıl olacağını söyleyebiliri.
        bunu da başına 'abstract yazarak sağlarız ki pdf kendi karar versin nasıl açacağına.
        abstract bir metot ancak abstract bir class ın üysei olabilir. bu nedenle 
        "public abstract class Document" yazdık ama ya abstract ya virtual olur bu nedenle virtual'ı kaldırdık*/

        public abstract void Open(); //herkes nasıl açılacağına kendi karar verir.
        public void Copy(string from, string to) //Bu method polymorfik değil
        {
            Console.WriteLine("dosya kopyalandı"); //abstract metot değil, çünkü tüm dosyalar aynı şekilde kopyalanır.
        }

        public void Move (string from, string To) //taşıma işlemi de değişmediği için normal method olarak yazdık. Bu method polymorfik değil
        {
            Console.WriteLine("dosya taşındı...");
                }

        /*polymorfizim : atadan gelen özelliğin değişmesi durumu. örneğin ilk canlılar trake solunumu yaparken 
    şimdi yaptığımız solunum akciğer solunumu. Solunum değişmedi ama araçları yıllar içerisinde değişti.
    Eğer ben bir methodun polymorfik olmasına karar veriyor isem virtual imzalıyorum.*/

        public string Title { get; set; }
        
        public virtual void  Delete(string path) /*her dosya aynı şekilde siliniyor. Ama gelecekte ya başka bir şekilde silinme olduğunda 
            bunda değişiklik yapılabilsin isteniyorsa virtual eklenmeli, örneğin word dokümanı farklı şekilde silinsik 
            istersek bunu virtual syaesinde ezebiliriz.*/
        {
            Console.WriteLine("Doküman silindi..");
        }
        

        public abstract void Save();


        /*bazı dokümanların çıktısı alınabiliyor bazılarınınki ise alınamıyor.
         bazı insanlar resim yapıyor ama diğerleri yapamıyorum.Demekki resim yapmak bir yetenek
        Böyle durumlarda interface kullanıyoruz.*/

        //public abstract void Print();
        /*her doc önceden çıktı alınabiliyordu ama analiz değişti ve her doc çıktı alınmaısn dediler.
        yani 70 doc tan 60 ı çıktı alınabiliyorsa bu bir yetenek hakine geldi. Bu da --> interface.
        birden fazla interface olabilir mesela bağlama çalıyorum, code yazıyorum, yemek yapıyorum gibi..
            */
                
    }

    public interface IPrintable  //yetenek, her dokümanda printleme yeteneği yok
    {
        void Print();
    }




    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı.");
        }


        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi.");
        }
    }


    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı.");
        }

        public void Print()
        {
            Console.WriteLine($"{this.GetType().Name} çıktısı alındı.");
        }

        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi.");
        }
    }


    public class WordDocument : Document, IPrintable //bir class istediği kadar interface i implement edebilir, birinin bir sürü yeteneği olabiir.
    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı.");
        }

        public void Print()
        {
            Console.WriteLine($"{this.GetType().Name} çıktısı alındı.");
        }

        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi.");
        }

        public override void Delete(string path)  //polimorfik bir yapıyı virtual ile yaptık,bu sayede gelecekte wordün silme şekli değişir ise burda ezebileceğiz.
        {
            base.Delete(path);
        }
    }


    public class PowerPointDocument : Document    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı.");
        }

        
        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi.");
        }
    }


    public class PrintComponent //program.cs'de kullanabilmek için bu class'ı oluşturduk.
    {
        public void PrintDocument(IPrintable printableDocument)
        {
            printableDocument.Print();
        }
    }

    



}
