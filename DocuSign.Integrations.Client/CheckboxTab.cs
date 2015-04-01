using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocuSign.Integrations.Client
{
    public class CheckboxTab : Tab
    {
        /// <summary>
        /// This element specifies whether or not the checkbox is checked.
        /// </summary>
        public bool? selected { get; set; }
    }
}
