using Russet.iMuneem.General.People;
using Russet.iMuneem.Medical.Laboratory;
using Russet.iMuneem.Medical.Patients;
using System.Collections.Generic;
using System.Linq;

namespace Russet.iMuneem.Medical.Doctors
{
    public class Doctor : Person
    {
        public string Department { get; set; }
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Doctor>();
            }
        }

        ///<summary>
        /// Adds the fees.
        /// </summary>
        /// <param name="contact">The fees.</param>
        public void AddFees(DoctorFees fees)
        {
            if (DoctorFeesList == null)
            {
                DoctorFeesList = new List<DoctorFees>();
            }

            // If the fees is not already in the list
            if (!DoctorFeesList.Any(x => x.PrimaryKey == fees.PrimaryKey))
            {
                DoctorFeesList.Add(fees);
                fees.Doctor = this;
            }
        }

        #region navigation
        public virtual IList<PatientReport> PatientReports { get; set; }
        public virtual IList<DoctorFees> DoctorFeesList { get; set; }
        public virtual IList<PatientCharge> PatientCharges { get; set; }
        #endregion
    }
}
