# 🎮 PlayZone — Gaming Center Management System

![Platform](https://img.shields.io/badge/platform-Windows%20Forms-blue)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4)
![ORM](https://img.shields.io/badge/EF%20Core-Database%20First-purple)
![Database](https://img.shields.io/badge/database-SQL%20Server-red)
![Architecture](https://img.shields.io/badge/architecture-3--Tier-informational)
![License](https://img.shields.io/badge/license-MIT-green)

**PlayZone** is a Windows Forms desktop application for managing a gaming center with **15 stations** (PlayStation 4, PlayStation 5, Billiards, and more). It handles timed sessions, cafeteria orders, inventory, cashier shifts, and reports.

Its main design feature is **shift handover**: when a cashier closes a shift while sessions are still running, those sessions continue under the next cashier without being interrupted.

---

## 🎯 What This Project Demonstrates

- A 3-tier Windows Forms design on **.NET 8**
- **Entity Framework Core, Database First**: the model is scaffolded from an existing SQL Server database
- Configuration through `appsettings.json`
- Handling live sessions across shift closures and cashier handovers
- Combining a fixed product catalog (with stock tracking) and ad-hoc custom items in one order
- Separating admin configuration from daily cashier work, with role-based access

---

## ✨ Features

### Authentication and roles
- Login screen with two roles: `Admin` and `Cashier`
- Administrative and inventory screens are restricted to `Admin`

### Sessions
- Dashboard with 15 spots (`Spot 01` to `Spot 15`), each showing a live `Available` or `Active` state
- Start a session on any available spot
- **Details** dialog for active spots: start time, current play cost, ordered items, running total
- Checkout dialog that finalizes play time and cafeteria charges

### Cafeteria and inventory
- Fixed **Products** catalog managed by the admin (name, sale price, stock quantity)
- Stock is deducted automatically when a catalog product is added to a session
- **Custom Product** option for items that are not in the catalog

### Shifts and reports
- Open a shift with an opening cash amount
- Close a shift normally when no spot is active
- Close a shift with active spots: the sessions move to the new shift once the incoming cashier logs in and enters the cash
- Shift history, reservations archive, and sales/income reports

### Administration
- Spot types with hourly rates (for example PS4, PS5, Billiards)
- Spot assignment: map each of the 15 spots to a spot type, and change it later (for example from PlayStation to Billiards)
- Users, products, and general settings management

---

## 🔄 How It Works

```text
[Login] ──► [Open Shift (Opening Cash)] ──► [Main Dashboard: 15 Spots]
                                                  │
              ┌───────────────────────────────────┼─────────────────────────────┐
              │ Available spot                    │ Active spot                 │ Menu
              ▼                                   ▼                             ▼
       [Start Session]                    [Details Dialog]              [Admin / Shift / Reports]
                                          • Catalog product             • Spot Types & Spots
                                            (deducts stock)             • Products & Inventory
                                          • Custom product              • Users & Settings
                                            (ad-hoc item)               • Close Shift & Handover
                                                  │
                                                  ▼
                                          [End Session / Checkout]
```

### Shift handover

When a cashier closes a shift while spots are still `Active`:

1. The active sessions are **not** ended.
2. The incoming cashier logs in and enters their opening cash.
3. The `ShiftID` of the active sessions is updated to the new shift.
4. The full session total is recorded under the shift in which the session ends.

---

## 🧱 Architecture

```
┌──────────────────────────────┐
│  Presentation Layer          │  WinForms screens and the spot UserControl
├──────────────────────────────┤
│  Business Logic Layer        │  Session pricing, shift rules, stock deduction, role checks
├──────────────────────────────┤
│  Data Access Layer           │  EF Core (scaffolded DbContext and entities)
└──────────────┬───────────────┘
               ▼
        SQL Server (PlayZone)
```

Each layer talks only to the one below it, so the UI never touches the database directly.

---

## 🔐 Roles and Permissions

| Action | Cashier | Admin |
|--------|:------:|:-----:|
| Start, view, add orders to, and end sessions | ✅ | ✅ |
| Open and close shifts (including handover) | ✅ | ✅ |
| Manage spot types, hourly rates, and spot assignment | ❌ | ✅ |
| Manage products, prices, and stock | ❌ | ✅ |
| Manage users, view archives and reports, edit settings | ❌ | ✅ |

---

## 🗄️ Database Design

The database is named **PlayZone**.

| Table | Purpose |
|-------|---------|
| `SpotTypes` | Type ID, type name (PS4, PS5, Billiards...), hourly rate |
| `Spots` | Spot ID (1 to 15), name, foreign key to `SpotTypes` |
| `Products` | Fixed cafeteria items: name, sale price, stock quantity |
| `Reservations` | Sessions (active and past), linked to a spot and a `ShiftID` |
| `ReservationProducts` | Order lines: catalog products or custom items linked to a reservation |
| `Shifts` | Shift owner, opening cash, open/close times |
| `Users` | Login credentials and role (`Admin` / `Cashier`) |

---

## 🚀 Getting Started

### Requirements
- Windows
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (17.8 or newer) with the **.NET desktop development** workload
- SQL Server (Express is enough) and SQL Server Management Studio (SSMS)

### Setup

1. **Clone**
   ```bash
   git clone https://github.com/<your-username>/<your-repo>.git
   cd <your-repo>
   ```

2. **Create the database**
   Open SSMS and run the SQL script in the `Database` folder. It creates the **PlayZone** database, tables, constraints, and seed data.

3. **Set the connection string**
   Edit `appsettings.json` in the WinForms project:
   ```json
   {
     "ConnectionStrings": {
       "PlayZone": "Server=.;Database=PlayZone;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```
   Replace `Server=.` with your SQL Server instance name if needed.

4. **Run**
   Open the `.sln` file, set the WinForms project as the startup project, and press **F5**.

> Make sure `appsettings.json` has **Copy to Output Directory** set to *Copy if newer*, otherwise the app will not find the connection string at runtime.

### Re-scaffolding the model (Database First)

If you change the database schema, regenerate the entities and context:

```bash
dotnet ef dbcontext scaffold "Server=.;Database=PlayZone;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context PlayZoneContext --force
```

If `dotnet ef` is not found, install it once with `dotnet tool install --global dotnet-ef`.

### Default login

```
Username: <your-admin-username>
Password: <your-admin-password>
```
> Change these credentials after the first login.

---

## 🧪 Quick Test

1. Log in as `Admin`. Make sure `PS4` and `Billiards` exist as spot types, assign `Spot 01` to `PS4`, and add a product with stock `10`.
2. Open a shift with an opening cash value.
3. Start a session on `Spot 01`. In `Details`, add `1` catalog product and one custom product, then end the session.
4. **Expected result:**
   - `Spot 01` returns to `Available`
   - The product stock drops from `10` to `9`
   - The session total (play time + catalog item + custom item) appears in the active shift's records

To test the handover: start a session, close the shift, log in as a second cashier, and confirm the session is still `Active` under the new shift.

---

## ⚠️ Design Notes and Limitations

- A session that crosses a shift boundary is recorded fully under the shift in which it ends. Revenue is not split across shifts.
- Custom products are not tied to a catalog row, so they have no stock tracking.
- The connection string is stored in plain text in `appsettings.json`.
- The user interface is currently in English only.

---

## 🗺️ Roadmap

- [ ] Receipt printing
- [ ] Time-based alerts for long sessions
- [ ] Export reports to PDF and Excel
- [ ] Password hashing for stored credentials
- [ ] Arabic localization
- [ ] Unit tests for the business layer

---

## 🤝 Contributing

1. Fork the repository
2. Create a branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Add your feature"`
4. Push the branch and open a Pull Request

---

## 📄 License

Released under the [MIT License](LICENSE).

## 👤 Author

**Muhammad Sadaka**

- GitHub: [@Muhammad-sadaka](https://github.com/Muhammad-sadaka)