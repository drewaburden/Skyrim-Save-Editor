using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.SaveFields {
	public class GlobalVariable : SaveField<float> {
		public RefID refID { get; set; }

		public GlobalVariable(RefID refID) : base(refID.Value) {
			this.refID = refID;
			Type = "GlobalVariable";
        }
	}
}
