using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class Header : SaveBlock {
			public SaveField<String> magic;
			public SaveField<UInt32> headerSize;
			public SaveField<UInt32> version;
			public SaveField<UInt32> saveNumber;
			public SaveField<String> playerName { get; set; }
			public SaveField<UInt32> playerLevel;
			public SaveField<String> playerLocation;
			public SaveField<String> gameDate;
			public SaveField<FILETIME> saveTime;
			public SaveField<Int64> saveTime64;
			public SaveField<String> playerRace;
			public SaveField<UInt16> playerSex;
			public SaveField<Single> playerCurExp;
			public SaveField<Single> playerLvlUpExp;
			public SaveField<ScreenshotData> screenshotData;
			public SaveField<Byte> formVersion;

			public Header() {
				magic = new SaveField<String>("magic");
				headerSize = new SaveField<UInt32>("headerSize");
				version = new SaveField<UInt32>("version");
				saveNumber = new SaveField<UInt32>("saveNumber");
				playerName = new SaveField<String>("playerName");
				playerLevel = new SaveField<UInt32>("playerLevel");
				playerLocation = new SaveField<String>("playerLocation");
				gameDate = new SaveField<String>("gameDate");
				saveTime = new SaveField<FILETIME>("saveTime");
				saveTime64 = new SaveField<Int64>("saveTime64");
				playerRace = new SaveField<String>("playerRace");
				playerSex = new SaveField<UInt16>("playerSex");
				playerCurExp = new SaveField<Single>("playerCurExp");
				playerLvlUpExp = new SaveField<Single>("playerLvlUpExp");
				screenshotData = new SaveField<ScreenshotData>("screenshotData");
				formVersion = new SaveField<Byte>("formVersion");
			}

			public void loadFields(SaveReader saveReader) {
				magic.Value = saveReader.ReadString(13);
				headerSize.Value = saveReader.ReadUInt32();
				version.Value = saveReader.ReadUInt32();
				saveNumber.Value = saveReader.ReadUInt32();
				playerName.Value = saveReader.ReadString();
				playerLevel.Value = saveReader.ReadUInt32();
				playerLocation.Value = saveReader.ReadString();
				gameDate.Value = saveReader.ReadString();
				playerRace.Value = saveReader.ReadString();
				playerSex.Value = saveReader.ReadUInt16();
				playerCurExp.Value = saveReader.ReadSingle();
				playerLvlUpExp.Value = saveReader.ReadSingle();
				saveTime.Value = saveReader.ReadFILETIME();
				saveReader.BaseStream.Position -= 8; // We need the FILETIME in 2 different formats, so back up 8 bytes and read again.
				saveTime64.Value = saveReader.ReadInt64();
				screenshotData.Value = saveReader.ReadScreenshotData();
				formVersion.Value = saveReader.ReadByte();
			}
		}
	}
}