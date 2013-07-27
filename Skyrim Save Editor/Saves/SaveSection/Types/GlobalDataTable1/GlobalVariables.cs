using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class GlobalVariables : SaveSection {
		public SaveField<UInt32> type;
		public SaveField<UInt32> length;
		public VSVal count;
		public GlobalVariable[] globals;

		public GlobalVariables() {
			blockName = "Global Variables";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
			count = saveReader.ReadVSVal("count");
			globals = saveReader.readGlobalVariable(count.Value);
		}

		public override SaveField[] GetFields() {
			SaveField[] fields = new SaveField[2] {
				type, length
			};
			fields = fields.Concat(globals).ToArray();
			return fields;
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
