using System.Collections.Generic;

namespace UserManagmentWithIdentity.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
