# DatingApp
prop + Tab = public int Name { get; set;}

[API Terminal] => dotnet ef mmigrations add ClassName = Creates tables for the data base
  -> Data Folder
    -> DataContext.cs
      -> public DbSet<TableName> TableName { get; set; }
