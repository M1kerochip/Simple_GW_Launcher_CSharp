using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_GW
{
    /// <summary>
    /// Greaseweazle EXE arguments, with name.
    /// </summary>
    internal class GWArguments
    {
        /// <summary>
        /// The name of the argument, to be displayed onscreen, in the menu, etc.
        /// </summary>
        public string ArgumentName { get; set; }    
        /// <summary>
        /// The actual exe arguments, to be used to pass to the main exe, along with the filename to process
        /// </summary>
        public string ArgumentValue { get; set; }
    }
}
