using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Inventories
{
    public class ProductManufacturer : DomainObject
    {
        public Guid ProductID { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductManufacturer>();
            }
        }

        #region navigation
        public virtual Product Product { get; set; }
        public virtual IList<ProductVersion> ProductVersions { get; set; }
        #endregion
    }
}
