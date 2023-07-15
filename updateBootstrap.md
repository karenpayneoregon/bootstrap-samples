# How to update Bootstrap in a new project

When a new ASP.NET Core project or Razor Pages project is created with Microsoft Visual Studio 2022 we get Bootstrap v5.1.0 and want a newer version.

## Options

### From Visual Studio

Right clicking in solution explorer in the project, select **Add**, **Client-Side library** then type **bootstrap** and you get bootstrap@5.3.0 (or if there is a newer version than it will show). Next click **Install**.


### From CLI

- In solution explorer, right click on wwwroot/lib/bootstrap
- Delete the folder

- Install [Libman CLI](https://learn.microsoft.com/en-us/aspnet/core/client-side/libman/libman-cli?view=aspnetcore-7.0#installation)

- Open a command window to the root of the project and enter

    - libman init --default-provider cdnjs
    - libman install bootstrap@5.3.0 --destination  wwwroot/lib/bootstrap/dist

In the root of the project libman.json is generated from the first command.

The second command installed version 5.3.0 of bootstrap.

```json
{
  "version": "1.0",
  "defaultProvider": "cdnjs",
  "libraries": [
    {
      "library": "bootstrap@5.3.0",
      "destination": "wwwroot/lib/bootstrap/dist"
    }
  ]
}
```

# Caveat

When installing from Visual Studio the libman interface allows selective installation of files while the CLI does not.

# Resources

- [Use LibMan with ASP.NET Core in Visual Studio](https://learn.microsoft.com/en-us/aspnet/core/client-side/libman/libman-vs?view=aspnetcore-7.0)
- [Use the LibMan CLI with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/client-side/libman/libman-cli?view=aspnetcore-7.0)
- cdnjs [Bootstrap](https://cdnjs.com/libraries/bootstrap)