namespace Tiket.Data.Entities
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly Ticket ticket;

        public SeedDb(DataContext context, Ticket ticket)
        {
            _context = context;
            this.ticket = ticket;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntranceAsync();          
            //await _context.SaveChangesAsync();
        }

       

        private async Task CheckEntranceAsync()
        {
            if (!_context.Entrances.Any())
            {
                _context.Entrances.Add(new Entrance
                { 
                    Id=1,
                    Description = "Norte",

                }) ;
                _context.Entrances.Add(new Entrance
                {
                  Id=2,
                    Description = "Sur"

                });
                _context.Entrances.Add(new Entrance
                {
                   Id=3,
                    Description = "Oriente"

                });
                _context.Entrances.Add(new Entrance
                {
                   Id=4,
                    Description = "Occidente"

                });
            }

            await _context.SaveChangesAsync();
        }
        //
        /* while (n < 1250)
                        {
                            new Ticket()
                            {
                                Id = n++,
                            };
                        }
         * 
         * */
        private async Task CheckTicketAsync(/*int id*/)
        {

            //Entrance entrance = await _context.Entrances.FindAsync(id);
            Console.WriteLine("llegue hasta aca");
            int n = 0;
            while (n<5000) {
                if (ticket.Id==n)
                {
                    n = 5000;
                }
                _context.Tickets.Add(new Ticket
                {

                    Id = n,
                    name = "null",
                    Entrances = new List<Entrance>()
                    {
                        
                        new Entrance()
                        {
                            Description="Norte"
                        },
                        new Entrance()
                        {
                            Description="Sur"
                        },
                        new Entrance()
                        {
                            Description="Oriente"
                        },
                        new Entrance()
                        {
                            Description="Occidente"
                        },

                    }
                });  
                n++;
            }
            await _context.SaveChangesAsync();
        }
    }
}
