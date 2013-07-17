using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices.ComTypes;

namespace Skyrim_Save_Editor.Saves {
	public class RefID {
		public Byte type { get; set; }
		public Byte[] formID { get; set;  } // 22-bit value
		public String hexFormID { get; set; }
	};

	public class Header {
		public String magic { get; set; }
		public UInt32 headerSize { get; set; }
		public UInt32 version { get; set; }
		public UInt32 saveNumber { get; set; }
		public String playerName { get; set; }
		public UInt32 playerLevel { get; set; }
		public String playerLocation { get; set; }
		public String gameDate { get; set; }
		public FILETIME saveTime;
		public Int64 saveTime64 { get; set; }
		public String playerRace { get; set; }
		public UInt16 playerSex { get; set; }
		public Single playerCurExp { get; set; }
		public Single playerLvlUpExp { get; set; }
		public ScreenshotData screenshotData { get; set; }
		public Byte formVersion { get; set; }

		public Header() {
			screenshotData = new ScreenshotData();
		}
	};

		
	public class ScreenshotData {
		public UInt32 shotWidth { get; set; }
		public UInt32 shotHeight { get; set; }
		public Byte[] R { get; set; }
		public Byte[] G { get; set; }
		public Byte[] B { get; set; }
	};

	public class PluginInfo {
		public UInt32 pluginInfoSize { get; set; }
		public Byte pluginCount { get; set; }
		public String[] plugins { get; set; }
	};

	public class FileLocationTable {
		public UInt32 formIDArrayCountOffset { get; set; }
		public UInt32 unknownTable3Offset { get; set; }
		public UInt32 globalDataTable1Offset { get; set; }
		public UInt32 globalDataTable2Offset { get; set; }
		public UInt32 changeFormsOffset { get; set; }
		public UInt32 globalDataTable3Offset { get; set; }
		public UInt32 globalDataTable1Count { get; set; }
		public UInt32 globalDataTable2Count { get; set; }
		public UInt32 globalDataTable3Count { get; set; }
		public UInt32 changeFormCount { get; set; }
		public UInt32[] unused { get; set; }
	};

	public class MiscStats {
		public UInt32 miscStatsCount { get; set; }
		public MiscStat[] statData { get; set; }
	};

	public class MiscStat {
		public String name { get; set; }
		public Byte category { get; set; }
		public Int32 value { get; set; }
	};

	public class PlayerLocation {
		public UInt32 unknown { get; set; }
		public RefID worldSpace1 { get; set; }
		public Int32 coorX { get; set; }
		public Int32 coorY { get; set; }
		public RefID worldSpace2 { get; set; }
		public Single posX { get; set; }
		public Single posY { get; set; }
		public Single posZ { get; set; }
		public Byte unk { get; set; }
	};

	public class TES {

	};

	public class GlobalVariables {  };
	public class CreatedObjects {  };
	public class Effects {  };
	public class Weather {  };
	public class Audio {  };
	public class SkyCells {  };
	public class ProcessLists {  };
	public class Combat {  };
	public class Interface {  };
	public class ActorCauses {  };
	public class Unknown104 {  };
	public class DetectionManager {  };
	public class LocationMetaData {  };
	public class QuestStatic {  };
	public class StoryTeller {  };
	public class MagicFavorites {  };
	public class PlayerControls {  };
	public class StoryEvent {  };
	public class IngredientShared {  };
	public class MenuControls {  };
	public class MenuTopicManager {  };
	public class TempEffects {  };
	public class Papyrus {  };
	public class AnimObjects {  };
	public class Timer {  };
	public class SynchronizedAnimations {  };
	public class Main {  };
}
