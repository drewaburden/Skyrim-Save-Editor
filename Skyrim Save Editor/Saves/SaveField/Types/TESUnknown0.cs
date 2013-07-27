using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves.SaveFields {
    public class TESUnknown0 : SaveField<RefID> {
		public UInt16 unknown { get; set; }

		public TESUnknown0(String key) : base(key) {
			Type = "Unknown0";
		}
	}
}
