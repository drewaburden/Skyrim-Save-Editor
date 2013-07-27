using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class Unknown2Section : SaveSection {
		public VSVal count;
		public RefID[] unknown;

		public Unknown2Section() {
			blockName = "Unknown 2";
		}

		public override void Load(SaveReader saveReader) {
            count = saveReader.ReadVSVal("count");
			unknown = new RefID[count.Value];
			for (int index = 0; index < unknown.Length; ++index) {
				unknown[index] = saveReader.ReadRefID("unknown");
			}
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
