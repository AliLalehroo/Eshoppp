using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.Account
{
    public class RolePermission : BaseEntity
    {
        public long RoleId { get; set; }
        public long PermissionId { get; set; }

        public Role Role { get; set; }
        public Permission Permission { get; set; }
    }
}
