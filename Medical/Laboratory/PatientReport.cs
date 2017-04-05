using Russet.iMuneem.Base;
using Russet.iMuneem.Medical.Doctors;
using Russet.iMuneem.Medical.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Medical.Laboratory
{
    public class PatientReport : DomainObject
    {
        public Guid ReportID { get; set; }
        public Guid PatientID { get; set; }
        public Guid DoctorID { get; set; }

        public DateTime Date { get; set; }
        public string Discount { get; set; }
        public string Cost { get; set; }
        public string DoctorInsentive { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<PatientReport>();
            }
        }

        #region navigation
        public virtual Patient Patient { get; set; }
        public virtual Report Report { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ReportResult ReportResult { get; set; }
        #endregion
    }
}
