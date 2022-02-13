# Kodluyoruz C# Project 2
## Todo Application

#### Yeni bir console uygulaması açarak bir 3 kolondan oluşan bir TODO uygulaması yazınız. Uygulamada olması gereken özellikler aşağıdaki gibidir.
- Kart Ekle
- Kart Güncelle
- Kart Sil
- Kart Taşı
- Board Listeleme

#### Kart İçeriği:
- Baslık
- Icerik
- Atanan Kisi (Takım üyelerişnden biri olmalı)
- Büyüklük (XS, S, M, L, XL)

#### Açıklama:
- Board TODO - IN PROGRESS - DONE kolonlarından oluşmalı.
- Varsayılan olarak bir board tanımlı olmalı ve 3 tane de kart barındırmalı.(Kartlar herhangi bir line'da yani kolonda olabilir.)
- Kartlar ancak takımdan birine atanabilir. Takımdaki kişiler ise varsayılan olarak tanımlanmalı. Takım üyeleri Dictionary kullanılarak key-value pair şeklinde yada bir sınıf aracılığıyla tutulabilir. Kartlara atama yapılırken takım üyeleri ID leri ile atanacak. Yani kullanılacak ypının mutlaka bir ID içermesi gerekir.
- Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.

### (1) Board Listelemek
![List](https://user-images.githubusercontent.com/80003871/153777034-35d50308-fdef-4f8d-ae70-943f29dcac3f.png)

### (2) Board'a Kart Eklemek
![Add](https://user-images.githubusercontent.com/80003871/153777071-dec73ea4-078a-488e-ae93-2d738ee752d9.png)
- Büyüklükler Enum olarak saklanmalı. Kart üzerinde gösterilirken XS olarak gösterilmeli. Giriş yapılırken kullanıcıdan 1 alınmalıdır.
- Takım üyeleri mevcut bir listede daha tanımlanmış olamlıdır.(Program içerisinde dinamik tanımlanmasına gerek yok.) Kart tanımlarken takım üyesinin ID'si istenmeli. Tanımlı bir ID değilse "Hatalı girişler yaptınız!" uyarısı ile işlem iptal edilebilir.

### (3) Board'a Kart Silmek
![](https://github.com/emreissvr/TodoApp_CSharp/blob/main/Images/Delete.png)

### (4) Kart Taşımak
![](https://github.com/emreissvr/TodoApp_CSharp/blob/main/Images/Move.png)
#### Part 2 
![](https://github.com/emreissvr/TodoApp_CSharp/blob/main/Images/Move2.png)
### (5) Çıkış
![](https://github.com/emreissvr/TodoApp_CSharp/blob/main/Images/Quit.png)
