using Russet.iMuneem.Base;
using Russet.iMuneem.General.People;
using Russet.iMuneem.Medical.Laboratory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Medical.Doctors
{
    public class Doctor : DomainObject
    {
        public string Name { get; set; }
        public string Gender { get; set; }
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

        #region navigation
        public virtual IList<PatientReport> PatientReports { get; set; }
        #endregion
    }
}
