namespace simpleApi.data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            { 
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                if (!context.books.Any()) 
                {
                    context.books.AddRange(
                        new Book
                        {
                            Title = "1 book",
                            Desctiption = "1 book Deskctioption",
                            IsRead = true,
                            ReadDate = DateTime.Now.AddDays(-10)
                        },
                        new Book {
                            Title = "2 book",
                            Desctiption = "2 book Deskctioption",
                            IsRead = false,                           
                        }
                        ) ;

                    context.SaveChanges();
                 
                }
            }
        }
    }
}
