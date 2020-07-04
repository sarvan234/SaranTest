using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PMK_IntCoE_Services.Pages.Manage
{
    public class ListRolesModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<ListRolesModel> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IEnumerable<IdentityRole> RoleList { get; private set; }

        public ListRolesModel(
                        UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<ListRolesModel> logger,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
        }

        public void OnGet()
        {
            RoleList = _roleManager.Roles;
        }
    }
}