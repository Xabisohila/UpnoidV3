using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpnoidV3.Models;

namespace UpnoidV3.ViewModels
{
    public class UserManagementAddRoleViewModel
    {
        public string UserId { get; set; }
        public string NewRole { get; set; }
        public SelectList Roles { get; set; }
        public string Email { get; set; }
    }
}
