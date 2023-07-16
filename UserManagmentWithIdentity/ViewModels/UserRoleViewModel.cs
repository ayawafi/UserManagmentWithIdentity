using System.Collections.Generic;

namespace UserManagmentWithIdentity.ViewModels
{
    public class UserRoleViewModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string MyProperty { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
