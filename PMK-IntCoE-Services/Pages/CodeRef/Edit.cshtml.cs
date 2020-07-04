using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PMK_IntCoE_Services.Data.DevDBData;
using PMK_IntCoE_Services.Models.DevDBModels;

namespace PMK_IntCoE_Services.Pages.CodeRef
{
    public class EditModel : PageModel
    {
        private readonly PMK_IntCoE_Services.Data.DevDBData.AuditContext _context;

        public EditModel(PMK_IntCoE_Services.Data.DevDBData.AuditContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ESB_AUDIT_LOGGER).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ESB_AUDIT_LOGGERExists(ESB_AUDIT_LOGGER.ROWID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ESB_AUDIT_LOGGERExists(string id)
        {
            return _context.ESB_AUDIT_LOGGER.Any(e => e.ROWID == id);
        }
    }
}
