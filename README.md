# ✅ TodoAPI

ASP.NET Core Web API ve Entity Framework Core ile geliştirilmiş bir **yapılacaklar listesi API'si**.

## 🚀 Özellikler
- Görev ekleme, listeleme, güncelleme ve silme (CRUD)
- Görevi tamamlandı olarak işaretleme
- Veriler SQL Server veritabanında kalıcı olarak saklanır
- Boş görev adı kontrolü (400 Bad Request)
- Swagger ile test arayüzü

## 🛠️ Kullanılan Teknolojiler
- C# / .NET 8
- ASP.NET Core Web API
- Entity Framework Core (Code First, Migrations)
- SQL Server (LocalDB)
- Swagger

## 📡 API Uç Noktaları

| Metot | Adres | Açıklama | Başarılı Cevap |
|---|---|---|---|
| GET | `/Todos` | Tüm görevleri listeler | 200 |
| GET | `/Todos/{id}` | Tek görevi getirir | 200 / 404 |
| POST | `/Todos` | Yeni görev ekler | 201 / 400 |
| PUT | `/Todos/{id}` | Görevi günceller | 204 / 404 |
| DELETE | `/Todos/{id}` | Görevi siler | 204 / 404 |

## 📦 Örnek İstek (POST)
```json
{ "title": "Ekmek al", "isDone": false }
