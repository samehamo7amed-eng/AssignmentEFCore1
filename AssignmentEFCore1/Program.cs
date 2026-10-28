using AssignmentEFCore1.Context;

namespace AssignmentEFCore1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BookStoreDbContext context= new BookStoreDbContext();
            context.Database.EnsureCreated();
           




        }
    }
}
