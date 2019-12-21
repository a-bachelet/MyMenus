using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMenus.Entity
{
    /// <summary>
    ///     A generic entity.
    /// </summary>
    public class Entity
    {
        /// <summary>
        ///     The entity identifier.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        ///     Constructor.
        /// </summary>
        protected Entity() { }
    }
}
