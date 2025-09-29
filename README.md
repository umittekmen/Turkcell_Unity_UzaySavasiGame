# 🚀 Turkcell Unity Uzay Savaşı Oyunu

Unity ile geliştirilmiş 2D uzay savaşı oyunu. Oyuncu bir uzay gemisini kontrol ederek asteroidleri yok etmeye çalışır.

## 🎮 Oyun Özellikleri

- **2D Uzay Savaşı**: Klasik asteroid oyunu tarzında
- **WASD Kontrolleri**: Uzay gemisini hareket ettirme
- **Space Tuşu**: Mermi atma
- **Dinamik Zorluk**: Her seviyede daha fazla asteroid
- **Puan Sistemi**: Farklı asteroid türleri için farklı puanlar
- **Patlama Efektleri**: Asteroid ve gemi patlamaları
- **Hareketli Arka Plan**: Uzay teması için kaydırılan arka plan

## 🎯 Oynanış

1. **Başlangıç**: "Oyna" butonuna tıklayarak oyunu başlatın
2. **Hareket**: WASD tuşları ile uzay geminizi kontrol edin
3. **Ateş**: Space tuşu ile asteroidlere mermi atın
4. **Hedef**: Tüm asteroidleri yok ederek puan toplayın
5. **Dikkat**: Asteroidlere çarpmaktan kaçının!

## 📁 Proje Yapısı

### Scripts Klasörü

- **`GemiKontrol.cs`**: Uzay gemisi hareket ve ateş kontrolü
- **`OyunKontrol.cs`**: Ana oyun mantığı ve asteroid üretimi
- **`Asteroid.cs`**: Asteroid davranışları ve çarpışma algılama
- **`Kursun.cs`**: Mermi hareketi ve yaşam süresi
- **`UIKontrol.cs`**: Kullanıcı arayüzü ve puan sistemi
- **`EkranHesaplayici.cs`**: Ekran sınırları hesaplama
- **`GeriSayim.cs`**: Mermi yaşam süresi için geri sayım
- **`ArkaPlan.cs`**: Hareketli arka plan efekti
- **`Tetikleyici.cs`**: Oyun başlangıç tetikleyicisi

## 🛠️ Teknik Detaylar

### Kullanılan Teknolojiler
- **Unity 2022.x** veya üzeri
- **C#** programlama dili
- **Unity Input System** (klavye kontrolleri için)
- **Unity Physics 2D** (çarpışma algılama)

### Önemli Özellikler
- **Ekran Sınırları**: `EkranHesaplayici` ile dinamik ekran boyutu hesaplama
- **Fizik Motoru**: 2D Rigidbody ile gerçekçi hareket
- **Prefab Sistemi**: Yeniden kullanılabilir oyun nesneleri
- **Tag Sistemi**: Çarpışma algılama için Unity tag'leri
- **Singleton Pattern**: Oyun kontrolü için merkezi yönetim

## 🎨 Oyun Mekanikleri

### Puan Sistemi
- **Asteroid 1**: 5 puan
- **Asteroid 2**: 10 puan  
- **Asteroid 3**: 15 puan

### Zorluk Sistemi
- Her seviyede asteroid sayısı artar
- Zorluk çarpanı: 5x
- Dinamik asteroid üretimi

### Kontroller
- **W**: Yukarı hareket
- **A**: Sola hareket
- **S**: Aşağı hareket
- **D**: Sağa hareket
- **Space**: Mermi atma

## 🎮 Oyun Ekranları

- **Ana Menü**: Oyun başlığı ve oyna butonu
- **Oyun Ekranı**: Uzay gemisi, asteroidler ve puan
- **Oyun Sonu**: Final puanı ve tekrar oyna seçeneği

## 🔧 Geliştirici Notları

Bu proje Unity öğrenme amaçlı geliştirilmiştir ve aşağıdaki Unity konseptlerini içerir:
- MonoBehaviour lifecycle
- Input System
- Physics 2D
- Prefab instantiation
- UI Management
- Collision detection
- Coroutines ve timing

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

---

