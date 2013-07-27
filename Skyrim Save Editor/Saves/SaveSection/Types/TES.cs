using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class TES : SaveSection {
		public SaveField<UInt32> type;
		public SaveField<UInt32> length;
		public VSVal count1;

        public TES() {
            blockName = "TES";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
			count1 = saveReader.ReadVSVal("count1");
		}

		public override SaveField[] GetFields() {
			return new SaveField[3] {
				type, length, count1
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
