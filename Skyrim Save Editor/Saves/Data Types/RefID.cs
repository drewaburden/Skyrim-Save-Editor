using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class RefID {
			public Byte type { get; set; }
			public Byte[] formID { get; set; } // 22-bit value
			public String hexFormID { get; set; }
		}
	}
}
