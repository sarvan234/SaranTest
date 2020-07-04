using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using PMK_IntCoE_Services.Data.DevDBData;
using PMK_IntCoE_Services.Models.DevDBModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMK_IntCoE_Services.Services
{
    public class AuditExceptionService
    {
        private readonly AuditContext _context;

        public AuditExceptionService(IWebHostEnvironment webHostEnvironment, AuditContext context)
        {
            _context = context;
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IList<ESB_AUDIT_LOGGER>> GetAuditDataAsync(String IName, DateTime StrTime, DateTime EndTime)
        {
            var AuditEntries = from m in _context.ESB_AUDIT_LOGGER
                               select m;
            if (IName == null && (StrTime == null && EndTime == null))
            {
                AuditEntries.Take(20);
            }
            else if (StrTime == null && EndTime == null && !(IName==null))
            {
                AuditEntries = AuditEntries.Where(x => x.INTERFACENAME == IName);
                AuditEntries = AuditEntries.OrderBy(x => x.AUDIT_TIMESTAMP);
            }
            else if (EndTime == null || StrTime == null)
            {
                AuditEntries = AuditEntries.Where(x => x.AUDIT_TIMESTAMP < StrTime);
                AuditEntries = AuditEntries.OrderBy(x => x.AUDIT_TIMESTAMP);
            }
            else
            {
                AuditEntries = AuditEntries.Where(x => x.AUDIT_TIMESTAMP < StrTime);
                AuditEntries = AuditEntries.Where(x => x.AUDIT_TIMESTAMP < EndTime);
                AuditEntries = AuditEntries.OrderBy(x => x.AUDIT_TIMESTAMP);
            }

            IList<ESB_AUDIT_LOGGER> AuditDataList = await AuditEntries.ToListAsync();
            return AuditDataList;
        }

        public async Task<IList<ESB_EXCEPTION_LOGGER>> GetExcepDataAsync(String IName)
        {
            var ExcepEntries = from m in _context.ESB_EXCEPTION_LOGGER
                               select m;

            if (!string.IsNullOrEmpty(IName))
            {
                ExcepEntries = ExcepEntries.Where(x => x.INTERFACENAME == IName);
                ExcepEntries = ExcepEntries.OrderBy(x => x.EXCEPTION_TIMESTAMP);
            }

            IList<ESB_EXCEPTION_LOGGER> ExcepDataList = await ExcepEntries.Take(20).ToListAsync();
            return ExcepDataList;
        }

    }
}
