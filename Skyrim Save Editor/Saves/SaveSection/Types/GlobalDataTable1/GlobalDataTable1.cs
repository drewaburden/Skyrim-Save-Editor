using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class GlobalDataTable1 : SaveSection {
		public SaveSection miscStats;
		public SaveSection playerLocation;
		public SaveSection tes;
		public SaveSection globalVariables;

		public GlobalDataTable1() {
			blockName = "Global Data Table 1";
			miscStats = new MiscStats();
			playerLocation = new PlayerLocation();
			tes = new TES();
			globalVariables = new GlobalVariables();
		}

		public override void Load(SaveReader saveReader) {
			(miscStats as MiscStats).Load(saveReader);
			(playerLocation as PlayerLocation).Load(saveReader);
			(tes as TES).Load(saveReader);
			(globalVariables as GlobalVariables).Load(saveReader);
		}

		public override SaveField[] GetFields() {
			return new SaveField[0];
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[4] {
				miscStats, playerLocation, tes, globalVariables
			};
		}
	}
}