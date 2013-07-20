using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.Loaders {
	class MiscStatsLoader {
		public MiscStats load(SaveReader saveReader) {
			MiscStats miscStats = new MiscStats();

			miscStats.blockName = "Misc Stats";

			miscStats.type.Value = saveReader.ReadUInt32();
			miscStats.length.Value = saveReader.ReadUInt32();
			miscStats.miscStatsCount.Value = saveReader.ReadUInt32();
			miscStats.statData.Value = saveReader.ReadMiscStat((int) miscStats.miscStatsCount.Value);

			return miscStats;
		}
	}
}
