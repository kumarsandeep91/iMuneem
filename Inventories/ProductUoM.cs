using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Inventories
{
    public class ProductUoM : DomainObject
    {
        public Guid ProductID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductUoM>();
            }
        }

        #region navigation
        public virtual Product Product { get; set; }
        public virtual IList<ProductVersion> ProductVersions { get; set; }
        #endregion
    }
}
