using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PMK_IntCoE_Services.Data.DevDBData;
using PMK_IntCoE_Services.Models.DevDBModels;

namespace PMK_IntCoE_Services.Pages.AEDash
{
    [Authorize]
    public class ExcepDetailModel : PageModel
    {
        private readonly PMK_IntCoE_Services.Data.DevDBData.AuditContext _context;

        public ExcepDetailModel(PMK_IntCoE_Services.Data.DevDBData.AuditContext context)
        {
            _context = context;
        }

        public ESB_EXCEPTION_LOGGER ESB_EXCEPTION_LOGGER { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ESB_EXCEPTION_LOGGER = await _context.ESB_EXCEPTION_LOGGER.FirstOrDefaultAsync(m => m.ROWID == id);

            if (ESB_EXCEPTION_LOGGER == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
