using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMenus.Entity
{
    /// <summary>
    ///     A role entity.
    /// </summary>
    public class Role : Entity
    {
        /// <summary>
        ///     The role label.
        /// </summary>
        [Required]
        public string Label { get; set; }

        /// <summary>
        ///     The role parent identifier.
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        ///     The role parent.
        /// </summary>
        [ForeignKey(nameof(ParentId))]
        public Role Parent { get; set; }

        public virtual ICollection<Role> Children { get; set; }

        /// <summary>
        ///     The role associated permissions.
        /// </summary>
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
