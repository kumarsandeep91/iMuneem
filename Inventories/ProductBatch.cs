using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Inventories
{
    public class ProductBatch : DomainObject
    {
        public Guid ProductID { get; set; }

        public string Name { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductBatch>();
            }
        }

        #region navigation properties
        public virtual Product Product { get; set; }
        public virtual IList<ProductVersion> ProductVersions { get; set; }
        #endregion
    }
}
