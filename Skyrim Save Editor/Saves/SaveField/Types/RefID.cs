using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves.SaveFields {
	public class RefID : SaveField<String> {
		public Byte type { get; set; }
		public Byte[] formID; // 22-bit value. Not displayed in UI, so not a property.

		public RefID(String key) : base(key) {
            Type = "RefID";
        }
	}
}
