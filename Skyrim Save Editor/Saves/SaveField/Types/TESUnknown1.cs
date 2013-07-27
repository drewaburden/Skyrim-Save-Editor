using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves.SaveFields {
    public class TESUnknown1 : RefID {
        public Byte[] unknown { get; set; }

		public TESUnknown1(RefID refID) : base(refID.Key) {
			this.type = refID.type;
			this.formID = refID.formID;
			this.Value = refID.Value;
			this.Description = refID.Description;
		}
	}
}
