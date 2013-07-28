using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class EnchantmentTable : SaveSection {
		public VSVal count;
		public Enchantment[] enchantments;

		public EnchantmentTable(String blockName) {
			this.blockName = blockName;
		}

		public override void Load(SaveReader saveReader) {
            count = saveReader.ReadVSVal("count");
			enchantments = new Enchantment[count.Value];

			for (int index = 0; index < enchantments.Length; ++index) {
				enchantments[index] = new Enchantment();
				enchantments[index].Load(saveReader);
			}
		}

		public override SaveField[] GetFields() {
			return new SaveField[1] {
				count
			};
		}

		public override SaveSection[] GetSections() {
			return enchantments;
		}
	}
}
