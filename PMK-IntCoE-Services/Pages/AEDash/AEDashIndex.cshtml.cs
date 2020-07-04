using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PMK_IntCoE_Services.Data.DevDBData;

namespace PMK_IntCoE_Services.Pages.AEDash
{
    [Authorize]
    public class AEDashIndexModel : PageModel
    {
        private readonly AuditContext _context;
        //public AuditExceptionService AuditExceptionService;

        public AEDashIndexModel(AuditContext context) //, AuditExceptionService auditExceptionService)
        {
            _context = context;
            //AuditExceptionService = auditExceptionService;
        }

        //public IList<ESB_AUDIT_LOGGER> AuditDataList { get; private set; }
        public SelectList SelectIName { get; set; }
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Interface Name")]
            public string IName { get; set; }

            [Required]
            [DataType(DataType.DateTime)]
            [Display(Name = "Start Date")]
            public DateTime StrTime { get; set; }

            [Required]
            [DataType(DataType.DateTime)]
            [Display(Name = "End Date")]
            public DateTime EndTime { get; set; }

        }

        public async Task OnGetAsync()
        {
            IQueryable<string> INameQuery = from m in _context.ESB_AUDIT_LOGGER
                                            select m.INTERFACENAME;

            /*var AuditEntries = from m in _context.ESB_AUDIT_LOGGER
                               select m;

            if (!string.IsNullOrEmpty(IName))
            {
                AuditEntries = AuditEntries.Where(x => x.INTERFACENAME == IName);
                AuditEntries = AuditEntries.OrderBy(x => x.AUDIT_TIMESTAMP);
            }
            
            AuditDataList = await AuditEntries.Take(20).ToListAsync();*/
            SelectIName = new SelectList(await INameQuery.Distinct().ToListAsync());
            //            AuditDataList = await AuditExceptionService.GetAuditDataAsync(IName);

            //AuditDataList = await _context.ESB_AUDIT_LOGGER.ToListAsync();
        }

        public IActionResult OnPost(string Audit, string Excep)
        {
            if (Audit != null)
            {
                if (!(Input.IName == null || Input.EndTime == null || Input.StrTime == null))
                {
                    return RedirectToPage("/AEDash/ViewAudit", new
                    {
                        IName = Input.IName,
                        StrTime = Input.StrTime,
                        EndTime = Input.EndTime
                    });
                }
            }
            else
            {
                if (!(Input.IName == null || Input.EndTime == null || Input.StrTime == null))
                {
                    return RedirectToPage("/AEDash/ViewException", new
                    {
                        IName = Input.IName,
                        StrTime = Input.StrTime,
                        EndTime = Input.EndTime
                    });
                }
            }
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}