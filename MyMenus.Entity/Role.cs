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
        public int ParentId { get; set; }

        /// <summary>
        ///     The role parent.
        /// </summary>
        [ForeignKey(nameof(ParentId))]
        public Role Parent { get; set; }

        /// <summary>
        ///     The role associated permissions.
        /// </summary>
        public ICollection<Permission> Permissions { get; set; }
    }
}
