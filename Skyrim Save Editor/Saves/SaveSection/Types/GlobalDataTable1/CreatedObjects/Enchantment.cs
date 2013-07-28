using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class Enchantment : SaveSection {
		public RefID refID;
		public VSVal count;
		public SaveField<UInt32> timesUsed;

		public Enchantment() {
			blockName = "Unknown Enchantment";
			timesUsed = new SaveField<UInt32>("timesUsed");
		}

		public override void Load(SaveReader saveReader) {
			refID = saveReader.ReadRefID("refID");
			blockName = refID.Value;
            count = saveReader.ReadVSVal("count");
			timesUsed.Value = saveReader.ReadUInt32();
		}

		public override SaveField[] GetFields() {
			return new SaveField[3] {
				refID, count, timesUsed
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
