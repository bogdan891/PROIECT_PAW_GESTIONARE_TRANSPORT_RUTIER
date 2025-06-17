#RO
# Aplicație Windows Forms – Gestionare Rețea de Transport

Această aplicație desktop a fost realizată în C# folosind Windows Forms și Visual Studio 2022 Community. Aplicația permite gestionarea unei rețele de transport, oferind funcționalități complete de tip **CRUD** (Create, Read, Update, Delete) pentru trei entități principale: **mașini**, **șoferi** și **rute**.

## 🔧 Funcționalități
- Interfață principală cu meniu MDI pentru acces rapid la toate modulele
- CRUD complet pentru:
  - Mașini (înmatriculare, marcă, capacitate etc.)
  - Șoferi (nume, permis, rută alocată etc.)
  - Rute (cod rută, stații, orar plecare/sosire etc.)
- DataGridView pentru afișarea datelor din fiecare tabel
- Conectare la o **bază de date SQL Server**
- Validări de date, mesaje de eroare și confirmare
- Arhitectură modulară cu forme dedicate fiecărei entități

## 🛠️ Tehnologii folosite
- C# .NET Framework
- Windows Forms
- Visual Studio Community 2022
- SQL Server / LocalDB
- ADO.NET pentru interacțiunea cu baza de date

## ▶️ Cum se rulează aplicația
1. Deschide fișierul `.sln` în Visual Studio
2. Configurează conexiunea la baza de date în fișierul de configurare (`App.config`)
3. Build & Run

## 👤 Autor
Georgescu Ionuț-Bogdan, 2025 – Aplicație realizată ca proiect educațional

---

#EN

# Transport Network Manager – Windows Forms Application

This desktop app was developed in C# using Windows Forms and Visual Studio 2022 Community. 
It manages a transport network with full **CRUD** (Create, Read, Update, Delete) operations for **vehicles**, **drivers**, and **routes**, connected to a **SQL Server** database.

## 🔧 Features
- MDI main interface for fast module access
- Full CRUD support for:
  - Vehicles (registration, brand, capacity, etc.)
  - Drivers (name, license, assigned route)
  - Routes (code, stops, departure/arrival times)
- DataGridView displays for each entity
- SQL Server database connection via ADO.NET
- Data validation, error handling, and confirmation messages
- Clean modular architecture

## 🛠️ Technologies used
- C# .NET Framework
- Windows Forms
- Visual Studio 2022 Community
- SQL Server / LocalDB
- ADO.NET

## ▶️ How to run
1. Open the `.sln` file in Visual Studio
2. Set the DB connection string in `App.config`
3. Build & Run

## 👤 Author
Georgescu Ionuț-Bogdan, 2025 – Educational project
