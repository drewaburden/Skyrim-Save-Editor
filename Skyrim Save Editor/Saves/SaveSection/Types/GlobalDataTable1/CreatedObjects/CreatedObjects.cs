using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class CreatedObjects : SaveSection {
		public SaveField<UInt32> type;
		public SaveField<UInt32> length;
		public EnchantmentTable weaponEnchTable;

		public CreatedObjects() {
			blockName = "Created Objects";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
			weaponEnchTable = new EnchantmentTable("weaponEnchTable");
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
			weaponEnchTable.Load(saveReader);
		}

		public override SaveField[] GetFields() {
			return new SaveField[2] {
				type, length
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[1] {
				weaponEnchTable
			};
		}
	}
}
