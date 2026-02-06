# Inventory Management & POS System (.NET 8 WinForms)

A desktop-based **Inventory Management and POS System** built using **.NET 8.0 Windows Forms**.  
This application is designed to manage products, customers, billing, and invoice generation.

---

## Features

- User management
- Customer management
- Product and stock quantity management
- POS billing system
- Manual bill creation with cashier name and customer name
- Automatic total bill calculation
- Invoice generation and printing as Microsoft Word (.docx)
- Persistent invoice numbering
- Desktop installer support

---

## Technology Stack

- .NET 8.0 (Windows Forms)
- MySQL Database
- OpenXML SDK
- Visual Studio Installer Project
- GitHub Actions (CI Workflow)

---

## Project Structure

```
InventoryManagementSystem/
├── InventoryManagementSystem/
│   ├── Forms/
│   ├── Data/
│   ├── Repository/
│   ├── Templates/
│   │   └── Market_Inventory_Template.docx
│   ├── appsettings.json
│   └── Program.cs
│
├── InventoryManagementSystem.sln
└── README.md
```

---

## Configuration

### Database Connection

After cloning the repository, update the database connection string in `appsettings.json`.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;Database=InventoryManagementSystem;User=root;Password=YOUR_PASSWORD;"
  }
}
```

Replace `YOUR_PASSWORD` with your MySQL credentials.

---

### Application Configuration File (Required)

The application **requires** the `appsettings.json` file to be present **next to the executable** in order to read the database connection string.

If running from **Visual Studio**, ensure the file exists in:

- `bin/Debug/net8.0-windows/appsettings.json`
- `bin/Release/net8.0-windows/appsettings.json`

If the `appsettings.json` file is missing, the application will **fail to start or connect to the database**.

---

### Invoice Template

The application uses a **Word document template** for invoice generation.

Ensure the following folder exists **next to the application executable**:

```
Templates/
└── Market_Inventory_Template.docx
```

If running from **Visual Studio**, ensure the folder exists in:

- `bin/Debug/net8.0-windows/Templates/`
- `bin/Release/net8.0-windows/Templates/`

Invoice generation will fail if the template file is missing.

---

## Billing Workflow

1. Store users, customers, and product quantities
2. Select products and quantities in the POS section
3. Enter cashier name and customer name manually
4. System calculates the total bill
5. Click **Print Bill**
6. Invoice is generated as a Word (.docx) file
7. Invoice opens automatically in Microsoft Word

---

## Installation

1. Clone the repository
2. Build the project or create the installer (`.msi` / `Setup.exe`)
3. Install the application
4. Ensure `appsettings.json` exists in the installation directory
5. Ensure the `Templates` folder exists with the Word template
6. Update the database connection string if required
7. Launch the application

---

## GitHub Actions

This project uses **GitHub Actions** to automate the build process.

- Builds the application on every push
- Generates release artifacts
- Ensures consistent builds
- Supports versioning (v1.00, v1.01, etc.)

---

## Notes

- Database credentials are stored locally in `appsettings.json`
- Microsoft Word must be installed to open generated invoices
- Intended for educational and internal use

---

## License

This project is provided for **educational purposes only**.
