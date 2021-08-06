# Blazor-EfCore-SqliteTemplate
EF Core example using Cars.


EntityClasses
  For each entity, create a public class that will be used for a DbSet.

ApplicationDbContext
  Initialize EntityFramework
  Add at least one DbSet property to the class (Think of these as a table, add one for each entity if you wish.)

EntityRepository
  DependencyInjection - Inject ApplicationDbContext into the constructor of the repository. Queries against DbSet(s) are
    automatically onverted to SQL for the user.
    for the user.
  Create, Read, Update, Delete methods for the entity.
IEntityRepository
  Interface is injected throughout the application. 


Register service with services.AddTransient<Repository, IRepository>();
  After the service is registered you are able to inject the repository into a Razor Component.
  This allows access to the methods defined in the entity's repository class.
