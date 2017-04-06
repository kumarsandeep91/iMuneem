using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Medical.Doctors
{
    public class DoctorFees : DomainObject
    {
        public Guid DoctorID { get; set; }
        public double Fees { get; set; }
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
        public virtual Doctor Doctor { get; set; }
        #endregion
    }
}
