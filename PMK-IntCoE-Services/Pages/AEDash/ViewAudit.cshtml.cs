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
using PMK_IntCoE_Services.Services;

namespace PMK_IntCoE_Services.Pages.AEDash
{
    [Authorize]
    public class ViewAuditModel : PageModel
    {
        private readonly AuditContext _context;
        public AuditExceptionService AuditExceptionService;

        public ViewAuditModel(AuditContext context, AuditExceptionService auditExceptionService)
        {
            _context = context;
            AuditExceptionService = auditExceptionService;
        }

        public IList<ESB_AUDIT_LOGGER> AuditDataList { get; private set; }

        public async Task<IActionResult> OnGetAsync(string IName, DateTime StrTime, DateTime Endtime)
        {
               AuditDataList = await AuditExceptionService.GetAuditDataAsync(IName, StrTime, Endtime); 
            if (AuditDataList == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
