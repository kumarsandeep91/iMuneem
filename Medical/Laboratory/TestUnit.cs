using Russet.iMuneem.Base;
using System;

namespace Russet.iMuneem.Medical.Laboratory
{
    public class TestUnit : DomainObject
    {
        public Guid TestID { get; set; }

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
                return Validate<TestUnit>();
            }
        }

        #region navigation
        public virtual Test Test { get; set; }
        #endregion
    }
}
