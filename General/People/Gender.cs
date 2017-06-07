using Russet.iMuneem.Base;
using Russet.iMuneem.Medical.Laboratory;
using System.Collections.Generic;

namespace Russet.iMuneem.General.People
{
    public class Gender : DomainObject
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
                return Validate<Gender>();
            }
        }

        #region navigation
        public virtual IList<AgeGroup> AgeGroups { get; set; }
        public virtual IList<Person> Persons { get; set; }
        #endregion
    }
}
