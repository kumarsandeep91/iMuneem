using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.General.People
{
    public abstract class Person : DomainObject
    {
        public Guid? GenderID { get; set; }
        public Guid? BloodGroupID { get; set; }
        public Guid? MaritalStatusID { get; set; }

        ///<summary>
        ///Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        ///<summary>
        ///Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        ///<summary>
        ///Gets or sets the middle name.
        /// </summary>
        /// <value>The middle name.</value>
        public string MiddleName { get; set; }

        ///<summary>
        ///Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        ///<summary>
        ///Gets or sets the age.
        /// </summary>
        /// <value>The age.</value>
        public int Age { get; set; }

        ///<summary>
        ///Gets the Date of Birth.
        /// </summary>
        /// <value>The Date of Birth.</value>
        public DateTime? DateOfBirth { get; set; }

        ///<summary>
        ///Gets the full name.
        /// </summary>
        /// <value>The full name.</value>
        public string FullName
        {
            get
            {
                return String.Format("{0} {1} {2}", Title, FirstName, LastName);
            }
        }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Person>();
            }
        }

        #region navigation
        public virtual Gender Gender { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        #endregion
    }
}
