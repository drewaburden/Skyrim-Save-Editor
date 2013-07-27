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
		public Unknown0Section unknown0;
		public Unknown1Section unknown1;
		public Unknown2Section unknown2;

        public TES() {
            blockName = "TES";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
			unknown0 = new Unknown0Section();
			unknown1 = new Unknown1Section();
			unknown2 = new Unknown2Section();
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
			unknown0.Load(saveReader);
			unknown1.Load(saveReader);
			unknown2.Load(saveReader);
		}

		public override SaveField[] GetFields() {
			return new SaveField[2] {
				type, length
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[3] {
				unknown0, unknown1, unknown2
			};
		}
	}
}
