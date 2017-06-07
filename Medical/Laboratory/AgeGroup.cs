using Russet.iMuneem.Base;
using Russet.iMuneem.General.People;
using System;

namespace Russet.iMuneem.Medical.Laboratory
{
    public class AgeGroup : DomainObject
    {
        public Guid GenderID { get; set; }

        // gets the name in the format of lowerbound to upperbound. eg 10 to 15
        public string Name
        {
            get
            {
                return String.Format("{0} {1} {2}", LowerBound, "to", UpperBound);
            }
        }
        public string LowerBound { get; set; }
        public string UpperBound { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<AgeGroup>();
            }
        }

        #region navigation
        public virtual TestRange TestRange { get; set; }
        public virtual Gender Gender { get; set; }
        #endregion
    }
}
