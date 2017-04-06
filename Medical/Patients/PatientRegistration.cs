using Russet.iMuneem.Base;
using Russet.iMuneem.General.People.Employees;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Medical.Patients
{
    public class PatientRegistration : DomainObject
    {
        public Guid PatientID { get; set; }
        public Guid UserID { get; set; }
        public long RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Validity { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<PatientRegistration>();
            }
        }

        #region navigation
        public virtual Patient Patient { get; set; }
        // only registered user can register a patient.
        public virtual User RegisteredBy { get; set; }
        public virtual IList<PatientCharge> PatientCharges { get; set; }
        #endregion
    }
}
