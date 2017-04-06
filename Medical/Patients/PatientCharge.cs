using Russet.iMuneem.Base;
using System;

namespace Russet.iMuneem.Medical.Patients
{
    public class PatientCharge : DomainObject
    {
        public Guid RegistrationID { get; set; }
        public string ChargeName { get; set; }
        public double Cost { get; set; }
        public string Status { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<PatientCharge>();
            }
        }

        #region navigation
        public virtual PatientRegistration PatientRegistration { get; set; }
        #endregion
    }
}
