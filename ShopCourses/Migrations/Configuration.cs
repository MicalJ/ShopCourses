namespace ShopCourses.Migrations
{
    using ShopCourses.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ShopCourses.DAL.CourseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ShopCourses.DAL.CourseContext";
        }

        protected override void Seed(ShopCourses.DAL.CourseContext context)
        {
            CourseInitializer.SeedCoursesData(context);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
