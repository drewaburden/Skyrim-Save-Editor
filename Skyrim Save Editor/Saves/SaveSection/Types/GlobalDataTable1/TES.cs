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
        public SaveField<TESUnknown0[]> unknown0;
        public SaveField<UInt32> count2;
        public SaveField<TESUnknown1[]> unknown1;
        public VSVal count3;
        public SaveField<RefID[]> unknown2;

        public TES() {
            blockName = "TES";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
            unknown0 = new SaveField<TESUnknown0[]>("unknown0");
            count2 = new SaveField<UInt32>("count2");
            unknown1 = new SaveField<TESUnknown1[]>("unknown1");
            unknown2 = new SaveField<RefID[]>("unknown2");
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
            count1 = saveReader.ReadVSVal("count1");
			unknown0.Value = new TESUnknown0[count1.Value];
            for (int index = 0; index < unknown0.Value.Length; ++index) {
                unknown0.Value[index] = new TESUnknown0("unknown0");
                unknown0.Value[index].Value = saveReader.ReadRefID("unknown0");
                unknown0.Value[index].unknown = saveReader.ReadUInt16();
            }

            count2.Value = saveReader.ReadUInt32();
            unknown1.Value = new TESUnknown1[count2.Value];
            for (int index = 0; index < unknown1.Value.Length; ++index) {
                unknown1.Value[index] = new TESUnknown1();
                unknown1.Value[index].formID = saveReader.ReadRefID("unknown1");
                unknown1.Value[index].unknown = saveReader.ReadBytes(12);
            }

            count3 = saveReader.ReadVSVal("count3");
            unknown2.Value = new RefID[count3.Value];
            for (int index = 0; index < unknown2.Value.Length; ++index) {
                unknown2.Value[index] = saveReader.ReadRefID("unknown2");
            }
		}

		public override SaveField[] GetFields() {
			return new SaveField[8] {
				type, length, count1, unknown0, count2, unknown1, count3, unknown2
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
