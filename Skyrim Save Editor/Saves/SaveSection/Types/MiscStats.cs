using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public class MiscStats : SaveSection {
		public SaveField<UInt32> type;
		public SaveField<UInt32> length;
		public SaveField<UInt32> miscStatsCount;
		public SaveField<MiscStat[]> statData;

		public MiscStats() {
			blockName = "Misc Stats";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
			miscStatsCount = new SaveField<UInt32>("miscStatsCount");
			statData = new SaveField<MiscStat[]>("statData");
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
			miscStatsCount.Value = saveReader.ReadUInt32();
			statData.Value = saveReader.ReadMiscStat((int) miscStatsCount.Value);
		}

		public override SaveField[] GetValues() {
			return new SaveField[4] {
				type, length, miscStatsCount, statData
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
