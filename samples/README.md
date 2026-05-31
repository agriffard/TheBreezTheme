# Samples

## TheBreezTheme.Web

A minimal [Orchard Core](https://orchardcore.net/) **2.2.1** website that boots a fully
provisioned site on first run using the
[AutoSetup](https://docs.orchardcore.net/en/latest/reference/modules/AutoSetup/) module and
applies **TheBreezTheme**.

### What it does

On the first request, AutoSetup creates the **Default** tenant from the configuration in
[`appsettings.json`](TheBreezTheme.Web/appsettings.json) (`OrchardCore:OrchardCore_AutoSetup`),
running the `TheBreezTheme` setup recipe shipped inside the theme. No manual setup screen.

| Setting | Value |
|---|---|
| Site name | TheBreez Sample |
| Recipe | `TheBreezTheme` (sets site theme + seeds demo content) |
| Database | SQLite (file-based, under `App_Data`) |
| Admin user | `admin` |
| Admin password | `TheBreez1!` |

> The admin credentials are sample defaults. Change them before any non-local use.

### Run

```bash
cd samples/TheBreezTheme.Web
dotnet run
```

Then open the printed URL (e.g. `https://localhost:5001`). The admin dashboard is at `/Admin`.

### Reset

Delete the generated `App_Data` folder to wipe the site and re-run AutoSetup from scratch:

```bash
rm -rf samples/TheBreezTheme.Web/App_Data
```
