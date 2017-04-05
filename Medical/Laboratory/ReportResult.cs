using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Medical.Laboratory
{
    public class ReportResult : DomainObject
    { 
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ReportResult>();
            }
        }

        public void AddTestResult(TestResult result)
        {
            if (Results == null)
            {
                Results = new List<TestResult>();
            }

            // If the address is not already in the list
            if (!Results.Any(x => x.PrimaryKey == result.PrimaryKey))
            {
                Results.Add(result);
                result.ReportResult = this;
            }
        }

        #region navigation
        public virtual IList<TestResult> Results { get; set; }
        public virtual PatientReport PatientReport { get; set; }
        #endregion
    }
}
