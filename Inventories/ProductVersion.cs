using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Inventories
{
    public class ProductVersion : DomainObject
    {
        public Guid ProductID { get; set; }
        public Guid BatchID { get; set; }
        public Guid? ManufacturerID { get; set; }
        public Guid UoMID { get; set; }

        public int Version { get; set; }
        public DateTime? MfDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public double UnitCost { get; set; }
        public double MRP { get; set; }
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductVersion>();
            }
        }

        #region navigation properties
        public virtual Product Product { get; set; }
        public virtual ProductBatch ProductBatch { get; set; }
        public virtual ProductManufacturer ProductManufacturer { get; set; }
        public virtual ProductUoM ProductUoM { get; set; }
        #endregion
    }
}
