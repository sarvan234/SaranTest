using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PMK_IntCoE_Services.Pages.ManageUsers
{
    public class ListUsersModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<ListUsersModel> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IEnumerable<IdentityUser> UserList { get; private set; }

        public ListUsersModel(
                        UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<ListUsersModel> logger,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
        }
        public void OnGet()
        {
            UserList = _userManager.Users;
        }
    }
}