Bu projede Design Patterns konusu ele alınmış ve en çok kullanıldığı değerlendirilen 6 pattern örneği uygulaması yapılmıştır.
Aşağıda özet olarak Design Pattern'lara değinilmiştir. Standart olarak kabul edilmiş 23 disayn patternların ayrıntıları için GitBook sayfamı ziyaret edebilirisiniz. [GitBook/RıdvanORUN](https://ridvanorun.gitbook.io/desing-patterns/)

# DESING PATTERNS
Design patterns; bir yazılım projesinden sıklıkla karşılaştığımız benzer sorunlar üzerinden yola çıkarak Code Optimization'ı en iyi şekilde yapabilmemizi sağlayan yapılardır. Bir design pattern, doğrudan koda dönüştürülebilen bitmiş bir tasarım değildir.
![Foto1](https://gblobscdn.gitbook.com/assets%2F-MPTaJDw4ydhbhVvAsOm%2F-MPTaM0_Y1UdPD2LkwOB%2F-MPTcD0S4db3dErXE82I%2FDesingPatterns.png?alt=media&token=54161a63-d5fc-4a93-a53b-291a773abf67)

Desing Patterns 3 ana başlık altında incelenir;

## 1. Creational (Oluşturucu) tasarım desenleri
Nesnelerin nasıl yaratılacağı hakkında öneriler sunar. 5 temel uygulama biçimi vardır.3 örnek uygulama yapılmıştır.
   
   1.1.[**Singleton Pattern**](https://github.com/RidvanOrun/DesignPatternsSolution/tree/master/SingletonPattern) Uygulamanın yaşam süresince bir nesnenin bir kez oluşturulmasını sağlar. Nesnenin sadece bir defa oluşturulmasını öngören bir mekanizma kurulmak istenildiğinde etkin bir biçimde kullanılabilen bir tasarım desenidir.
  
   1.2.[**Builder Pattern**](https://github.com/RidvanOrun/DesignPatternsSolution/tree/master/BuilderPattern) Birden fazla parçadan oluşan nesnelerin üretilmesinden sorumludur. Tek ara yüz kullanarak karmaşık bir nesne grubundan gerektiğince parça yaratılmasını sağlar.
   
   1.3.[**Factory Pattern**](https://github.com/RidvanOrun/DesignPatternsSolution/tree/master/FactoryMethod)  Aynı arayüzü kullanan nesnelerin üretiminden sorumludur. Nesnenin nasıl yaratılacağını kalıtım yoluyla alt sınıflara bırakıp nesne yaratımı için tek ara yüz kullanarak, ara yüzle nesne yaratım işlevlerini temelde birbirinden ayırmaya yarayan yaratımsal tasarım kalıbıdır.
   
## 2. Structural  (Yapısal) tasarım desenleri. 7 temel uygulama biçimi vardır. 1 örnek uygulaması yapılmıştır.
Sınıflar arasındaki ilişkileri belirleme önerileri sunar, Nasıl türetilmeli, hangi nesneleri içermeli, sınıflar birbirlerini nasıl bağlı olmalı gibi soruların cevaplarını yanıtlar.

   2.1.[**Decorator Pattern**](https://github.com/RidvanOrun/DesignPatternsSolution/tree/master/DecoratorPattern) Bir yapıya dinamik olarak yeni metotlar eklenmesini düzenler. Dekoratör kalıp uygulamada runtime esnasında bir sınıfın işlevlenebilirliğinin genişletilmesini veya başka bir deyişle yeniden dekore edilebilmesini mümkün kılar. Bunu yaparken dekoratör kalıpları orjinal sınıfları kapsayan yeni dekorator sınıfları üreterek yaparlar.
   
## 3. Behavioral (Davranışsal) tasarım desenleri
Soruna göre nesneler arası ortak haberleşmeyi en iyi şekilde kurmamıza öneriler sunar. 11 temel uygulama biçimi vardır. 2 örnek açıklaması yapılmıştır.

   3.1.[**Chain Of REsponsibility Pattern**](https://github.com/RidvanOrun/DesignPatternsSolution/tree/master/TheChainOfResponsibityPattern) Sorumluluk zinciri kalıbı sisteme gönderilen bir isteğin (komut) hangi nesne tarafından cevaplanması gerektiğini bilmediğimiz durumlarda ya da isteği yapan nesne ve servis sağlayan nesne arasında sıkı bir bağ oluşmasını engellememiz gerektiğinde kullanılmaktadır.
   
   3.2.[**Oberver Pattern**](https://github.com/RidvanOrun/DesignPatternsSolution/tree/master/ObserverPattern) Uygulama içerisinde bir nesnede meydana gelen değişikliklerden haberdar olup üzerinde belli metotları çalıştırıp değişlikler yapmak isteyen diğer nesneler bulunabilmektedir. 
   
   
