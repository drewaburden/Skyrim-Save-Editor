using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves.Loaders {
	class HeaderLoader {
		public Header load(SaveReader saveReader) {
			Header header = new Header();

			header.blockName = "Header";

			header.magic.Value = saveReader.ReadString(13);
			header.headerSize.Value = saveReader.ReadUInt32();
			header.version.Value = saveReader.ReadUInt32();
			header.saveNumber.Value = saveReader.ReadUInt32();
			header.playerName.Value = saveReader.ReadString();
			header.playerLevel.Value = saveReader.ReadUInt32();
			header.playerLocation.Value = saveReader.ReadString();
			header.gameDate.Value = saveReader.ReadString();
			header.playerRace.Value = saveReader.ReadString();
			header.playerSex.Value = saveReader.ReadUInt16();
			header.playerCurExp.Value = saveReader.ReadSingle();
			header.playerLvlUpExp.Value = saveReader.ReadSingle();
			header.saveTime.Value = DateTime.FromFileTime(saveReader.ReadInt64());
			header.screenshotData.Value = saveReader.ReadScreenshotData();
			header.formVersion.Value = saveReader.ReadByte();

			return header;
		}		
	}
}
