using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class MiscStats : TreeNode {
			public String blockName = "Misc Stats";
			public SaveField<UInt32> type;
			public SaveField<UInt32> length;
			public SaveField<UInt32> miscStatsCount;
			public SaveField<MiscStat[]> statData;

			public MiscStats() {
				type = new SaveField<UInt32>("type");
				length = new SaveField<UInt32>("length");
				miscStatsCount = new SaveField<UInt32>("miscStatsCount");
				statData = new SaveField<MiscStat[]>("statData");
			}

			public void loadFields(SaveReader saveReader) {
				type.Value = saveReader.ReadUInt32();
				length.Value = saveReader.ReadUInt32();
				miscStatsCount.Value = saveReader.ReadUInt32();
				statData.Value = saveReader.ReadMiscStat((int) miscStatsCount.Value);
			}

			public override IEnumerator GetEnumerator() {
				return (new Object[4] {
					type, length, miscStatsCount, statData
				}).GetEnumerator();
			}

			public override TreeNode[] GetNodes() {
				return new TreeNode[0];
			}
		}
	}
}
