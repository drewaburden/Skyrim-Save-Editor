using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class MiscStat {
			public String name { get; set; }
			public Byte category { get; set; }
			public Int32 value { get; set; }
		}
	}
}
