
Action Results Action Parameters Convention-based Routing Attribute Routing Razor views
DB:
1.If you want to add new attributes to a model class.
Add aa attributes to bbmodel.cs, then PM add-migration addAaToBb, then PM update-database

2.Update new tables into DB
in IdentityModel public DbSet<Movie> Movies { get; set; }
add-migration InitialModel -force
