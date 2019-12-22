namespace EFCodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.ObjectModel;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstExistingDatabase.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirstExistingDatabase.PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Authors.AddOrUpdate(a => a.Name,
                new Author // Object initializer
                {
                    Name = "Author 1",
                    Courses = new Collection<Course>() // Collection initializer
                    {
                        new Course() { Name = "Course by Author 1", Description = "Description 1" }
                    }
                });
        }
    }
}
