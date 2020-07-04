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
    public class ViewExceptionModel : PageModel
    {
        private readonly AuditContext _context;
        public AuditExceptionService AuditExceptionService;

        public ViewExceptionModel(AuditContext context, AuditExceptionService auditExceptionService)
        {
            _context = context;
            AuditExceptionService = auditExceptionService;
        }

        public IList<ESB_EXCEPTION_LOGGER> ExcepDataList { get;set; }

        /*public async Task OnGetAsync()
        {
            ESB_EXCEPTION_LOGGER = await _context.ESB_EXCEPTION_LOGGER.ToListAsync();
        }
        */

        public async Task<IActionResult> OnGetAsync(string IName)
        {
            if (IName == null)
            {
                /*return NotFound();
                }
                if (IName == "All")
                {*/
                ExcepDataList = await _context.ESB_EXCEPTION_LOGGER.Take(20).ToListAsync();
            }
            else { ExcepDataList = await AuditExceptionService.GetExcepDataAsync(IName); }

            if (ExcepDataList == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
