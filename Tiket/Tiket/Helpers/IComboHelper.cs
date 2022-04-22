using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tiket.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntranceAsync();


        //Task<IEnumerable<SelectListItem>> GetComboTicketAsync(int entraceId);

    }
}
