using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.General.People.Employees
{
    public class Role : DomainObject
    {
        ///<summary>
        /// Gets or sets the name of role.
        /// </summary>
        /// <value>The Name of role.</value>
        public string Name { get; set; }

        ///<summary>
        /// Gets or sets the description of role.
        /// </summary>
        /// <value>The Description of role.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Role>();
            }
        }

        public virtual IList<Employee> Employees { get; set; }
    }
}
