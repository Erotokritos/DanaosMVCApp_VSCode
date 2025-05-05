# DanaosMVCApp

This is a simple ASP.NET Core MVC application that displays a list of students and their average grades, with an option to export the data to an `.xlsx` file. It was created to meet the requirements of the Danaos Projects Front-End/Back-End test.

---

## 📦 Dependencies

To build and run this project, install the following tools:

### 1. .NET SDK
- **.NET 7 SDK** (or higher, e.g., .NET 9)
- Download: [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

### 2. Visual Studio Code
- [https://code.visualstudio.com/](https://code.visualstudio.com/)

### 3. C# Extension for VS Code
- Install `C#` by Microsoft from the Extensions tab

### 4. (Optional) SQL Server
- SQL Server Express + SQL Server Management Studio (SSMS) — if you want to use real database data instead of hardcoded mock data

---

## ⚙️ Build & Run Instructions (VS Code)

### ✅ One-Time Setup
1. Clone or extract the project folder
2. Open the project folder in VS Code
3. Restore dependencies:
   ```bash
   dotnet restore
   ```

### 🛠 Build the Project
```bash
dotnet build DanaosMVCApp.csproj
```

### 🚀 Run the Project
```bash
dotnet run --project DanaosMVCApp.csproj
```

By default, it will be available at:
```
http://localhost:5000
```

If you see a `favicon.ico` warning or 404 in the terminal — you can ignore it.

### 🧪 Test the App
- Click **"Load Grades"** to fetch and view the student data.
- Click **"Export to XLSX"** to download the table as an Excel file.

---
