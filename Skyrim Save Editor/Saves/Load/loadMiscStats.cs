using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveManager {
		protected void loadMiscStats(BinaryReader binaryReader) { 
			MiscStats miscStats = loadedSave.miscStats; // For code cleanliness

			// miscStatsType
			binaryReader.ReadUInt32();

			// miscStatsLength
			binaryReader.ReadUInt32();

			// miscStatsCount
			miscStats.miscStatsCount = binaryReader.ReadUInt32();

			// miscStats
			miscStats.statData = new MiscStat[miscStats.miscStatsCount];
			for (int statIndex = 0; statIndex < miscStats.statData.Length; ++statIndex) {
				MiscStat miscStat = new MiscStat();

				// name
				miscStat.name = new String(binaryReader.ReadChars(binaryReader.ReadInt16()));

				// category
				miscStat.category = binaryReader.ReadByte();

				// value
				miscStat.value = binaryReader.ReadInt32();

				miscStats.statData[statIndex] = miscStat;
			}
		}
	}
}