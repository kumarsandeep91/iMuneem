using Russet.iMuneem.Base;
using System;

namespace Russet.iMuneem.Communications
{
    public class Address : DomainObject
    {
        public Guid? CountryID { get; set; }
        public Guid? StateID { get; set; }
        public Guid? CityID { get; set; }
        public Guid? ZipCodeID { get; set; }

        public Guid? AddressTypeID { get; set; }

        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line2.
        /// </summary>
        /// <value>The address line2.</value>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Address>();
            }
        }

        #region navigation
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual City City { get; set; }
        public virtual ZipCode ZipCode { get; set; }

        public virtual AddressType Type { get; set; }
        #endregion
    }
}
