using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Medical.Laboratory
{
    public class TestResult : DomainObject
    {
        public Guid ReportResultID { get; set; }
        public string Result { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<TestResult>();
            }
        }

        #region navigation
        public virtual Test Test { get; set; }
        public virtual ReportResult ReportResult { get; set; }
        #endregion
    }
}
