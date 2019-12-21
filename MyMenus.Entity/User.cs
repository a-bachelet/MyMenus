using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMenus.Entity
{
    /// <summary>
    ///     A user entity.
    /// </summary>
    public class User : Entity
    {
        #region Security

        /// <summary>
        ///     The user email address.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        ///     The user plain password.
        /// </summary>
        [NotMapped]
        public string PlainPassword { get; set; }

        /// <summary>
        ///     The user hashed password.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        ///     The user roles.
        /// </summary>
        public ICollection<Role> Roles { get; set; }

        #endregion

        #region Personal

        /// <summary>
        ///     The user lastname.
        /// </summary>
        [Required]
        public string Lastname { get; set; }
        
        /// <summary>
        ///     The user firstname.
        /// </summary>
        [Required]
        public string Firstname { get; set; }

        /// <summary>
        ///     The user birth date.
        /// </summary>
        [Required]
        public DateTime BirthDate { get; set; }

        /// <summary>
        ///     The user address identifier.
        /// </summary>
        [Required]
        public int AddressId { get; set; }

        /// <summary>
        ///     The user address.
        /// </summary>
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }

        #endregion Personal
    }
}
