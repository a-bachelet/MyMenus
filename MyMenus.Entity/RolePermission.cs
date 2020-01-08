using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMenus.Entity
{
    /// <summary>
    ///     An entity associating a role and a permission.
    /// </summary>
    public class RolePermission
    {
        /// <summary>
        ///     The association role identifier.
        /// </summary>
        [Required]
        public Guid RoleId { get; set; }

        /// <summary>
        ///     The association role.
        /// </summary>
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }

        /// <summary>
        ///     The association permission identifier.
        /// </summary>
        [Required]
        public Guid PermissionId { get; set; }

        /// <summary>
        ///     The association permission.
        /// </summary>
        [ForeignKey(nameof(PermissionId))]
        public Permission Permission { get; set; }
    }
}
