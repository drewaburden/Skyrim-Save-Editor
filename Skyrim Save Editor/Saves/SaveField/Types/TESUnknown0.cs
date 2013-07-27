using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves.SaveFields {
    public class TESUnknown0 : RefID {
		public UInt16 unknown { get; set; }

		public TESUnknown0(RefID refID) : base(refID.Key) {
			this.type = refID.type;
			this.formID = refID.formID;
			this.Value = refID.Value;
			this.Description = refID.Description;
		}
	}
}
