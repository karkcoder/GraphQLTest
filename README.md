#Create database
1. Install EntityFramework tool  (Install-Package Microsoft.EntityFrameworkCore.Tools)
2. Add-Migration Initial
3. Update-Database

#Example of GraphQL
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