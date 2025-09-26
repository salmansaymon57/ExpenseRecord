# ExpenseRecord

A simple **ASP.NET Core 8 MVC** web application for keeping track of personal expenses.  
Live demo: [http://expensestracker.runasp.net/](http://expensestracker.runasp.net/)

---

## 🚀 Features
- **Overview Page** – View all recorded expenses at a glance.  
- **Create / Edit / Delete** – Add new expense records, update existing ones, or remove them.  
- **Clean UI** – Simple Bootstrap-based design for easy navigation.  
- **ASP.NET Core MVC** – Built with the latest .NET 8 MVC framework.  
- **SQL Database** – Stores expense records securely.  

---

## 🛠️ Tech Stack
- **Backend:** ASP.NET Core 8 MVC  
- **Frontend:** Razor Views + Bootstrap  
- **Database:** SQL Server (MonsterASP hosting)  
- **Hosting:** [MonsterASP](https://www.monsterasp.net/) free plan  

---


---


## ⚙️ Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)  
- SQL Server (LocalDB or remote)  
- Visual Studio 2022 / Rider / VS Code  

### Clone & Run
```
# clone repo
git clone https://github.com/salmansaymon57/ExpenseRecord.git
cd ExpenseRecord
```

# run migrations (if using EF Core)
dotnet ef database update

# run the app
dotnet run

---


---

## 🚀 Deployment

This app is deployed on **MonsterASP Free Hosting**.  

### Steps to Deploy
1. **Download Publish Profile**  
   - Log in to your MonsterASP control panel.  
   - Download the **Publish Profile (.PublishSettings)** file for your site.  

2. **Import Publish Profile in Visual Studio**  
   - In Visual Studio, right-click the project → **Publish**  
   - Select **Import Profile** and choose the downloaded `.PublishSettings` file.  

3. **Publish to MonsterASP**  
   - Click **Publish** and Visual Studio will deploy the project directly to MonsterASP using the imported settings.  

4. **Configure Database**  
   - In the MonsterASP control panel, create and configure your SQL Database.  
   - Update the connection string in `appsettings.Development.json` with your database credentials.  

Once published, your application will be live on MonsterASP.

