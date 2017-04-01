using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Medical.Laboratory
{
    public class Test : DomainObject
    {
        public string Code { get; set; }
        public string Name { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Test>();
            }
        }

        #region navigation
        public virtual IList<TestRange> Ranges { get; set; }
        public virtual IList<TestUnit> Units { get; set; }
        #endregion
    }
}
