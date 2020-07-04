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
    public class IndexModel : PageModel
    {
        private readonly PMK_IntCoE_Services.Data.DevDBData.AuditContext _context;

        public IndexModel(PMK_IntCoE_Services.Data.DevDBData.AuditContext context)
        {
            _context = context;
        }

        public IList<ESB_AUDIT_LOGGER> ESB_AUDIT_LOGGER { get;set; }

        public async Task OnGetAsync()
        {
            ESB_AUDIT_LOGGER = await _context.ESB_AUDIT_LOGGER.ToListAsync();
        }
    }
}
