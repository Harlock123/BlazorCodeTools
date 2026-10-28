# AGENTS.md

Notes for anyone, human or AI agent, changing this code. `README.md` explains why the tool exists; this file covers
how the code is put together and what to watch when changing it.

## What this is

A Windows Forms code generator, in C# for .NET Framework 4.0. You give it a SQL Server connection string and a
`SELECT`; it reads the result's columns and generates three pieces of code for a Blazor CRUD screen: a shared
data class with validation attributes, an ASP.NET Core API controller, and a Radzen grid for the page. It builds
and runs on Windows only.

## Commands

Open `BlazorCodeTools.sln` in Visual Studio and build, or from a Developer Command Prompt:

```bat
nuget restore BlazorCodeTools.sln
msbuild BlazorCodeTools.sln /p:Configuration=Release
```

There are no tests yet.

## Layout

- `BlazorCodeTools/BlazorCodeTools.csproj`: old-style project, `WinExe`, .NET Framework 4.0.
- `BlazorCodeTools/frmMain.cs`: the main form and all the generators.
  - `btnFetch_Click` runs the query into a grid and runs `sp_describe_first_result_set` on it to get each
    column's SQL type, length, precision, nullability and identity flag.
  - `ParseIntoTheFieldsList` turns that schema into `Field` objects; `ParseIntoTheFieldsGrid` lists the grid's
    column types, and double-clicking a type cycles it
    (String, Date, WholeNumber, FloatingPointNumber) for the grid generator.
  - `btnGeneralDataObject_Click` writes the shared class (`{Project}.Shared`), mapping SQL types to C# types and
    adding `[Required]` and `[StringLength]` annotations.
  - `btnGenerateController_Click` writes the controller (`[Route("api/[controller]")]`, get, post, put, delete),
    optionally a full file and optionally with SQL data access.
  - `HandleGenerateUIClick` writes the `<RadzenGrid>` markup.
- `BlazorCodeTools/Field.cs`: one column's name, SQL type, sizes, flags and crosswalk settings.
- `BlazorCodeTools/frmPresetDBs.cs`: picks a saved connection string from `BlazorCodeTools.ini`.
- `BlazorCodeTools/frmTablesViews.cs`: lists the database's tables and views from `INFORMATION_SCHEMA.TABLES`.
- `BlazorCodeTools/BlazorCodeTools.ini`: preset connections, one `DBASE=<connection string>` per line, copied
  next to the executable on build.
- `BlazorCodeTools/SupportDLLs/`: committed binaries the project references by `HintPath`: the author's
  `TAIGridControl2` grid, and ClosedXML with its dependencies.
- `BlazorCodeTools/UserManual.odt`: the user manual.

## Rules that keep it working

- **SQL Server only.** Column discovery depends on `sp_describe_first_result_set` (SQL Server 2012 or later) and
  `System.Data.SqlClient`, which the generated controller also uses.
- **Generated code embeds the connection string.** The controller generator writes `txtConnectionString.Text`
  into the output as a literal; anything you type there ends up in generated source.
- **Keep secrets out of the `.ini`.** It is committed and copied to the build output. Use placeholders such as
  `{UserHere}` and `{PasswordHere}`, as the existing entries do.
- **Libraries.** FastColoredTextBox comes from NuGet (`packages.config`, restored into `..\packages`); the other
  libraries are the committed DLLs in `SupportDLLs/`. Do not replace them with NuGet packages without checking
  they still target .NET Framework 4.0.
- **Designer files.** Controls live in the `*.Designer.cs` files; change them through the Visual Studio designer
  where you can.

## Making a change

- Generate code from a real query after any change to a generator, and compile the output in a Blazor project.
- When you add a SQL type, map it in `btnGeneralDataObject_Click`; the grid generator works from the four grid
  types instead.
