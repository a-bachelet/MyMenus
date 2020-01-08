using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMenus.Entity
{
    /// <summary>
    ///     An address entity.
    /// </summary>
    public class Address : Entity
    {
        /// <summary>
        ///     The adresse street number.
        /// </summary>
        public int StreetNumber { get; set; }

        /// <summary>
        ///     The address street letter.
        /// </summary>
        public string StreetLetter { get; set; }

        /// <summary>
        ///     The address street first line.
        /// </summary>
        [Required]
        public string StreetFirstLine { get; set; }

        /// <summary>
        ///     The address street second line.
        /// </summary>
        [Required]
        public string StreetSecondLine { get; set; }

        /// <summary>
        ///     The address zip code.
        /// </summary>
        [Required]
        public int ZipCode { get; set; }

        /// <summary>
        ///     The adress city.
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        ///     The address country.
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        ///     The address user identifier.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        ///     The address user.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
