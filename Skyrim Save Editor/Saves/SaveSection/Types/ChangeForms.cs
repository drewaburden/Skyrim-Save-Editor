using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class ChangeForms : SaveSection {

		public ChangeForms() {
			blockName = "Change Forms";
		}

		public override void Load(SaveReader saveReader) {
		}

		public override SaveField[] GetFields() {
			return new SaveField[0];
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}