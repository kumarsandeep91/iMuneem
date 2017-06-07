using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Medical.Laboratory
{
    public class Report : DomainObject
    {
        public string Name { get; set; }

        public string Cost { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Report>();
            }
        }

        #region navigation
        public virtual IList<Test> Tests { get; set; }
        public virtual IList<PatientReport> PatientReports { get; set; }
        #endregion
    }
}
