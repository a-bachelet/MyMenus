using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMenus.Entity
{
    /// <summary>
    ///     A permission entity.
    /// </summary>
    public class Permission : Entity
    {
        /// <summary>
        ///     The permission label.
        /// </summary>
        [Required]
        public string Label { get; set; }

        /// <summary>
        ///     The permission associated roles.
        /// </summary>
        public ICollection<Role> Roles { get; set; }
    }
}
