﻿using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Inventories
{
    public class ProductCategory : DomainObject
    {
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
                return Validate<ProductCategory>();
            }
        }

        #region navigation
        public virtual IList<Product> Products { get; set; }
        #endregion
    }
}
