using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class Unknown0Section : SaveSection {
		public VSVal count;
		public TESUnknown0[] unknown;
        
		public Unknown0Section() {
			blockName = "Unknown 0";
		}

		public override void Load(SaveReader saveReader) {
            count = saveReader.ReadVSVal("count");
			unknown = saveReader.readUnknown0(count.Value);
		}

		public override SaveField[] GetFields() {
			SaveField[] fields = new SaveField[1] { count };
			fields = fields.Concat(unknown).ToArray();
			return fields;
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
