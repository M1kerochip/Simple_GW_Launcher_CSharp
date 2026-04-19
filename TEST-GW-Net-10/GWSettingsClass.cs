using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_GW
{
    public class GWSettingsClass

    {
        /// <summary>
        /// 
        /// </summary>
        public string GW_EXE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GW_Arguments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Working_Folder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string File_Name { get; set;  }
        /// <summary>
        /// 
        /// </summary>
        public bool Save_Log { get; set; }  
        /// <summary>
        /// Should a script be executed after a read etc command finishes.
        /// </summary>
        public bool Execute_Script { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Script_To_Run { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProgramWidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProgramHeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool HideBatch { get; set; }

        public bool batch_Disablex64FileRedirection { get; set; }
        public bool batch_ExecuteScript { get; set; }
        public bool batch_ClearListOnDragDrop { get; set; }
        public bool batch_WaitForExit { get; set; }
        public int batch_RunMinimized { get; set; }
        public int batch_ClearListAfterExecute { get; set; }


    }
}
