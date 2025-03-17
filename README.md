# Console Application Algorithms

Bu depo, sıralama algoritmaları (Kabarcık Sıralaması, Eklemeli Sıralama), güç hesaplaması ve maksimum alt dizi algoritmaları (Kadane Algoritması, Böl ve Yönet) dahil olmak üzere çeşitli algoritmaları gösteren C# ile uygulanan basit bir konsol uygulamasını içerir.

## İçindekiler

1.  [Açıklama](#açıklama)
2.  [Kurulum](#kurulum)
3.  [Kullanım](#kullanım)
4.  [Bağımlılıklar](#bağımlılıklar)
5.  [Katkıda Bulunma](#katkıda-bulunma)
6.  [Lisans](#lisans)
7.  [package.json](#packagejson)
8.  [Config](#config)

## Açıklama

Bu C# konsol uygulaması, farklı algoritmaların uygulanmasını ve kullanımını göstermektedir. Uygulanan algoritmalar şunlardır:

*   **Sıralama Algoritmaları:**
    *   Bubble Sort
    *   Insertion Sort
*   **Güç Hesaplama:**
    *   Iterative Power
*   **Maksimum Alt Dizi Algoritmaları:**
    *   Kadane's Algorithm
    *   Divide and Conquer

## Kurulum

1.  Bu depoyu yerel makinenize klonlayın:

    ```bash
    git clone https://github.com/muhammetalifidan/ConsoleApp.git
    ```

2.  Depo dizinine gidin:

    ```bash
    cd ConsoleApp
    ```

3.  .NET 9.0 SDK'sının kurulu olduğundan emin olun. Kurulu değilse, [official .NET website](https://dotnet.microsoft.com/en-us/download) adresinden indirebilirsiniz.

## Kullanım

Proje Visual Studio ile geliştirilmiştir.

1.  `ConsoleApp.sln` dosyasını Visual Studio'da açın.
2.  Projenizi oluşturun: Derlemek için Visual Studio'daki "Build" menüsüne gidin ve "Build Solution" seçeneğini seçin.

Proje bağımsız bir yürütülebilir dosya olarak çalıştırılabilir. Projeyi oluşturduktan sonra, yürütülebilir dosya proje dizininizdeki `bin\Debug` veya `bin\Release` dizininde bulunabilir.

Konsol uygulamasını çalıştırmak için bir komut istemi veya terminal açın, yürütülebilir dosyanın bulunduğu dizine gidin ve aşağıdaki komutu çalıştırın:

```bash
dotnet run
```

Bu komut uygulamayı çalıştıracak ve yapılandırılan her algoritma için sonuçları görüntüleyecektir.

## Bağımlılıklar

*   .NET 9.0 SDK

## Katkıda Bulunma

Katkılar memnuniyetle karşılanmaktadır! Bu projeye katkıda bulunmak için lütfen şu adımları izleyin:

1.  Depoyu çatallayın.
2.  Değişiklikleriniz için bir özellik dalı oluşturun: `git checkout -b feature/your-feature`
3.  Değişikliklerinizi işleyin: `git commit -m 'Add some feature'`
4.  Dalı uzak depoya itin: `git push origin feature/your-feature`
5.  Çatalınızdan orijinal depoya bir çekme isteği açın.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır - ayrıntılar için `LICENSE` dosyasına bakın.

## package.json

Bu projenin bir `package.json` dosyası yoktur, çünkü bu bir .NET konsol uygulamasıdır ve Node.js veya NPM paketlerini kullanmaz.

## Config

Bu projenin yapılandırma dosyası yoktur.
