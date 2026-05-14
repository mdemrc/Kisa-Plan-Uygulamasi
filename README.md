# YKS Short Planner (`Kisa-Plan-Uygulamasi`)

[![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework-9333EA)](https://learn.microsoft.com/ef/)
[![SQL Server](https://img.shields.io/badge/SQL-SQL%20Server-CC2927?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)

## English

### Overview

During intensive **Higher Education Exams (YKS)** preparation, granular plans outperform vague intentions. This WinForms desktop app stores **subject titles** paired with **short plan descriptions** rows and surfaces them in a **DataGridView** backed by a **SQL Server** database named **`KisaPlan`**. Multiple Entity Framework connection string entries (`KisaPlanEntities`, numbered variants) may appear over time as assignments evolve — use the branch that matches your generated `.edmx` / designer files.

### What you practise

Database-first or model-first workflows, typed datasets compared to LINQ-to-Entities, basic validation so empty subjects do not silently commit, manual refresh timers if you bolt on countdown widgets.

### Configuration

Integrated Security pointing at **`(local)\SQLEXPRESS`** with catalog **`KisaPlan`** is the coursework default — adjust `App.config`, `SqlConnection` usages, or designer-generated files if your institute provisions another host.

---

## Türkçe

### Genel bakış

**Kısa plan uygulaması**, sınav sürecinde **konu başlığı** ve **plan detayı** satırlarını veritabanında saklayıp **DataGridView** üzerinde yönetmek için yazılmıştır. Varsayılan hedef MSSQL **`KisaPlan`** veritabanı ve **`(local)\SQLEXPRESS`** örneği; `App.config` içinde birden fazla `KisaPlanEntities*` tanımı varsa derste hangi bağlamın aktif olduğunu doğrulayın.

### Ne öğretir?

Temel EF / ADO bağlama döngüsü ve veri girişinde tutarlılık.

### Çalıştırma özeti

1. SQL örneğinde veritabanını oluşturun.  
2. Bağlantı dizesindeki **`Data Source`** değerini kendi makinenize yazın.
