using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PMK_IntCoE_Services.Data.DevDBData;
using PMK_IntCoE_Services.Models.DevDBModels;

namespace PMK_IntCoE_Services.Pages.CodeRef
{
    public class DeleteModel : PageModel
    {
        private readonly PMK_IntCoE_Services.Data.DevDBData.AuditContext _context;

        public DeleteModel(PMK_IntCoE_Services.Data.DevDBData.AuditContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ESB_AUDIT_LOGGER ESB_AUDIT_LOGGER { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ESB_AUDIT_LOGGER = await _context.ESB_AUDIT_LOGGER.FirstOrDefaultAsync(m => m.ROWID == id);

            if (ESB_AUDIT_LOGGER == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ESB_AUDIT_LOGGER = await _context.ESB_AUDIT_LOGGER.FindAsync(id);

            if (ESB_AUDIT_LOGGER != null)
            {
                _context.ESB_AUDIT_LOGGER.Remove(ESB_AUDIT_LOGGER);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
