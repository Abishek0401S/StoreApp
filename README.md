# 🛒 StoreApp - Blazor Hybrid Product Listing App

A simple **Blazor Hybrid (.NET MAUI)** application that displays a list of products fetched from a public API. This project demonstrates the integration of Blazor components with .NET MAUI for cross-platform UI development.

## 🔧 Technologies Used

- [.NET 9 Preview](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- **Blazor Hybrid** with **.NET MAUI**
- **C# 12**
- **HttpClient** for API communication
- **MVVM pattern** (lightweight)
- Minimal use of external packages for learning purposes

## 🧩 Features

- Product listing page that loads data from `https://fakestoreapi.com/products`
- Product detail page showing title, description, image, and category
- Responsive UI with native MAUI shell removed (manual navigation setup)
- Clean separation between UI, services, and models

## 🚀 How to Run

### 🖥 Prerequisites

- Visual Studio 2022 (Preview) with **.NET MAUI** workload installed
- .NET 9 SDK Preview version (`9.0.0-rc.*`)
- Windows 10+ (for Windows target) or macOS (for Mac Catalyst/iOS)

### 🛠 Setup

1. **Clone this repo**:
   ```bash
   git clone https://github.com/Abishek0401S/StoreApp.git
   cd StoreApp
