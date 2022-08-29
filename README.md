# Required Nuget Packages
- HotChocolate.AspNetCore
- HotChocolate.Data.EntityFramework
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

# Create database
- Install EntityFramework tool  (Install-Package Microsoft.EntityFrameworkCore.Tools)
- Add-Migration Initial
- Update-Database

# Example of GraphQL Query
```
query{
  superheroes{
    name,
    description,
    height,
    movies {
      title,
      description
    },
    superpowers {
      superPower,
      description
    }
  }
}
```