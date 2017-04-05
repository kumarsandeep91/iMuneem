using Russet.iMuneem.Base;
using System;

namespace Russet.iMuneem.Medical.Services
{
    public class Service : DomainObject
    {
        public Guid CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Cost { get; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Service>();
            }
        }

        #region navigation
        public virtual ServiceCategory Category { get; set; }
        #endregion
    }
}
