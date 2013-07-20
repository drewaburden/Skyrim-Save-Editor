using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace Skyrim_Save_Editor.Saves {
	public class Header : SaveSection {
		public SaveField<String> magic;
		public SaveField<UInt32> headerSize;
		public SaveField<UInt32> version;
		public SaveField<UInt32> saveNumber;
		public SaveField<String> playerName { get; set; }
		public SaveField<UInt32> playerLevel;
		public SaveField<String> playerLocation;
		public SaveField<String> gameDate;
		public SaveField<DateTime> saveTime;
		public SaveField<String> playerRace;
		public SaveField<UInt16> playerSex;
		public SaveField<Single> playerCurExp;
		public SaveField<Single> playerLvlUpExp;
		public SaveField<ScreenshotData> screenshotData;
		public SaveField<Byte> formVersion;

		public Header() {
			blockName = "Header";
			magic = new SaveField<String>("magic");
			headerSize = new SaveField<UInt32>("headerSize");
			version = new SaveField<UInt32>("version");
			saveNumber = new SaveField<UInt32>("saveNumber");
			playerName = new SaveField<String>("playerName");
			playerLevel = new SaveField<UInt32>("playerLevel");
			playerLocation = new SaveField<String>("playerLocation");
			gameDate = new SaveField<String>("gameDate");
			saveTime = new SaveField<DateTime>("saveTime");
			playerRace = new SaveField<String>("playerRace");
			playerSex = new SaveField<UInt16>("playerSex");
			playerCurExp = new SaveField<Single>("playerCurExp");
			playerLvlUpExp = new SaveField<Single>("playerLvlUpExp");
			screenshotData = new SaveField<ScreenshotData>("screenshotData");
			formVersion = new SaveField<Byte>("formVersion");
		}

		public override void Load(SaveReader saveReader) {
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
			saveTime.Value = DateTime.FromFileTime(saveReader.ReadInt64());
			screenshotData.Value = saveReader.ReadScreenshotData();
			formVersion.Value = saveReader.ReadByte();
		}

		public override SaveField[] GetValues() {
			return new SaveField[15] {
				magic, headerSize, version, saveNumber, playerName,
				playerLevel, playerLocation, gameDate, saveTime,
				playerRace, playerSex, playerCurExp, playerLvlUpExp,
				screenshotData, formVersion
			};
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}