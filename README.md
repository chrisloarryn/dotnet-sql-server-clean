# dotnet-sql-server-clean


Recreate your initial migration:

```bash
dotnet ef migrations add InitialMigration
```
Apply the migration:

```bash
dotnet ef database update
```