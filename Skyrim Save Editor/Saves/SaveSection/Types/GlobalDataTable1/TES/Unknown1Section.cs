using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class Unknown1Section : SaveSection {
		public SaveField<UInt32> count;
		public TESUnknown1[] unknown;

		public Unknown1Section() {
			blockName = "Unknown 1";
			count = new SaveField<UInt32>("count");
		}

		public override void Load(SaveReader saveReader) {
            count.Value = saveReader.ReadUInt32();
			unknown = saveReader.readUnknown1(count.Value);
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
