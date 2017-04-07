using Russet.iMuneem.Base;
using Russet.iMuneem.General.People.Employees;
using System;
using System.Collections.Generic;
using System.Linq;

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

        ///<summary>
        /// Adds the fees.
        /// </summary>
        /// <param name="contact">The fees.</param>
        public void AddCharges(PatientCharge charges)
        {
            if (PatientCharges == null)
            {
                PatientCharges = new List<PatientCharge>();
            }

            // If the fees is not already in the list
            if (!PatientCharges.Any(x => x.PrimaryKey == charges.PrimaryKey))
            {
                PatientCharges.Add(charges);
                charges.PatientRegistration = this;
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
