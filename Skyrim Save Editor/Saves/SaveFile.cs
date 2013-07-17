using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public enum Race {
		AltmerRace, ArgonianRace, BosmerRace, BretonRace, DunmerRace, ImperialRace, KhajiitRace, NordRace, OrcRace, RedguardRace
	};

	public class SaveFile {
		public Header header;
		public PluginInfo pluginInfo;
		public FileLocationTable fileLocationTable;
		public MiscStats miscStats;
		public PlayerLocation playerLocation;
		public TES tes;

		public SaveFile() {
			header = new Header();
			pluginInfo = new PluginInfo();
			fileLocationTable = new FileLocationTable();
			miscStats = new MiscStats();
			playerLocation = new PlayerLocation();
			tes = new TES();
		}
	};
}
