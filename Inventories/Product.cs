using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Russet.iMuneem.Inventories
{
    public class Product : DomainObject
    {
        public Guid CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        ///<summary>
        /// Adds the batch.
        /// </summary>
        /// <param name="contact">The batch.</param>
        public void AddBatch(ProductBatch batch)
        {
            if (ProductBatches == null)
            {
                ProductBatches = new List<ProductBatch>();
            }

            // If the address is not already in the list
            if (!ProductBatches.Any(x => x.PrimaryKey == batch.PrimaryKey))
            {
                ProductBatches.Add(batch);
                batch.Product = this;
            }
        }

        ///<summary>
        /// Removes the batch.
        /// </summary>
        /// <param name="contact">The the batch.</param>
        public void RemoveBatch(ProductBatch batch)
        {
            if (ProductBatches == null)
            {
                return;
            }

            ProductBatches.Remove(batch);
        }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Product>();
            }
        }

        #region navigation properties
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual IList<ProductManufacturer> ProductManuFacturers { get; set; }
        public virtual IList<ProductUoM> ProductUoMs { get; set; }
        public virtual IList<ProductBatch> ProductBatches { get; set; }
        public virtual IList<ProductVersion> ProductVersions { get; set; }
        #endregion
    }
}
