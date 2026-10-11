# Multi-Transport Delivery Manager

A desktop application built with C# WinForms and MySQL for managing multi-transport logistics, cargo delivery orders, client databases, and financial transactions.

---

## 🛠 Tech Stack

* **Language:** C# (.NET)
* **UI Framework:** Windows Forms (WinForms)
* **Database:** MySQL (`MySql.Data`)
* **Architecture:** Modular data access layer (`DataAccess.cs`) separating SQL queries and business logic.

---

## Key Features

* **Client Management:** Full CRUD operations for clients with duplicate validation and hierarchical address binding (regions, cities, streets).
* **Order Processing:** Automated cost calculation based on cargo weight, distance, transport per-kilometer rates, and currency conversion.
* **Geographical Routing:** Distance calculation between delivery points using geographic coordinates (latitude and longitude).
* **Transport & Fleet:** Management of transport categories, sub-transports, and specific pricing rules.
* **Financials & Debt Tracking:** Payment logging per order, multi-currency support, and automated debtor calculation.

---

## Architecture Overview

* **`DataAccess.cs`** — Centralized database connection and static data managers (`DataClient`, `DataTransport`, `DataOrders`, `DataPayments`, `DataAddress`, `DataCurrency`) handling SQL interactions.
* **Forms Layer** — Event-driven WinForms user interfaces (`FormMain`, `FormClients`, `FormTransport`, `FormAddOrder`, etc.) managing UI rendering and user workflows.
