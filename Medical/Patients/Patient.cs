using Russet.iMuneem.Base;
using Russet.iMuneem.General.People;
using Russet.iMuneem.Medical.Laboratory;
using System.Collections.Generic;

namespace Russet.iMuneem.Medical.Patients
{
    public class Patient : Person
    {
        // used as patient id for various purposes. its unique.
        public long PatientNumber { get; set; }
        public string FatherOrHusbandName { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Patient>();
            }
        }

        

        #region navigation
        public virtual IList<PatientReport> PatientReports { get; set; }
        public virtual IList<PatientRegistration> Registrations { get; set; }
        #endregion
    }
}
