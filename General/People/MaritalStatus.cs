using Russet.iMuneem.Base;
using System.Collections.Generic;

namespace Russet.iMuneem.General.People
{
    public class MaritalStatus : DomainObject
    {
        ///<summary>
        /// Gets or sets the name of Marital Status.
        /// </summary>
        /// <value>The Name of Marital Status.</value>
        public string Name { get; set; }

        ///<summary>
        /// Gets or sets the description of Marital Status.
        /// </summary>
        /// <value>The Description of Marital Status.</value>
        public string Description { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<MaritalStatus>();
            }
        }

        #region navigation
        public virtual IList<Person> Persons { get; set; }
        #endregion
    }
}
