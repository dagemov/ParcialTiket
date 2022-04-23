namespace Tiket.Data.Entities
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;

        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntranceAsync();
           // await CheckTicketAsync();
            //await _context.SaveChangesAsync();
        }

       

        private async Task CheckEntranceAsync()
        {
            if (!_context.Entrances.Any())
            {
                _context.Entrances.Add(new Entrance
                {

                    Description = "Norte",
                    Ticket = new List<Ticket>() { 
                        new Ticket() { 
                            name="null"
                    
                    } }
                    

                }) ;
                _context.Entrances.Add(new Entrance
                {
                    Description = "Sur",
                    Ticket = new List<Ticket>() {
                        new Ticket() {
                             name="null"

                    } }

                });
                _context.Entrances.Add(new Entrance
                {
                    
                    Description = "Oriente",
                    Ticket = new List<Ticket>() {
                        new Ticket() {
                             name="null"

                    } }

                });
                _context.Entrances.Add(new Entrance
                {
                    
                    Description = "Occidente",
                    Ticket = new List<Ticket>() {
                        new Ticket() {
                             name="null"

                    } }

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
        private async Task CheckTicketAsync()
        {
            int n = 0;
            while (n<5000) {
                new Ticket()
                {
                    Id = n,
                    //Entrances
                };
            }
            await _context.SaveChangesAsync();
        }
    }
}
