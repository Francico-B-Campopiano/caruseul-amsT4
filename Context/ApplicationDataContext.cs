using Microsoft.EntityFrameworkCore;

namespace AmsT4_Carousel.Context
{

        public class ApplicationDataContext : DbContext
        {   
                    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
                    {

                    }
                    



        }


}

