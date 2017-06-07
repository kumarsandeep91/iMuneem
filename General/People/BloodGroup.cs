using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.General.People
{
    public class BloodGroup : DomainObject
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
                return Validate<BloodGroup>();
            }
        }

        #region navigation
        public virtual IList<Person> Persons { get; set; } 
        #endregion
    }
}
