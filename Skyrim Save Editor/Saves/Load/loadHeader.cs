using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveManager {
		protected void loadHeader(BinaryReader binaryReader) {
			Header header = loadedSave.header; // For code cleanliness

			// magic
			header.magic = new String(binaryReader.ReadChars(13));

			// headerSize
			header.headerSize = binaryReader.ReadUInt32();

			// version
			header.version = binaryReader.ReadUInt32();

			// saveNumber
			header.saveNumber = binaryReader.ReadUInt32();

			// playerName
			header.playerName = new String(binaryReader.ReadChars(binaryReader.ReadInt16()));

			// playerLevel
			header.playerLevel = binaryReader.ReadUInt32();

			// playerLocation
			header.playerLocation = new String(binaryReader.ReadChars(binaryReader.ReadInt16()));

			// gameDate
			header.gameDate = new String(binaryReader.ReadChars(binaryReader.ReadInt16()));

			// playerRace
			header.playerRace = new String(binaryReader.ReadChars(binaryReader.ReadInt16()));

			// playerSex
			header.playerSex = binaryReader.ReadUInt16();

			// playerCurExp
			header.playerCurExp = binaryReader.ReadSingle();

			// playerLvlUpExp
			header.playerLvlUpExp = binaryReader.ReadSingle();

			// saveTime
			header.saveTime = new FILETIME();
			header.saveTime.dwLowDateTime = binaryReader.ReadInt32();
			header.saveTime.dwHighDateTime = binaryReader.ReadInt32();
			binaryReader.BaseStream.Position -= sizeof(Int64);
			header.saveTime64 = binaryReader.ReadInt64();

			ScreenshotData screenshotData = header.screenshotData; // Makes things cleaner looking

			// shotWidth
			screenshotData.shotWidth = binaryReader.ReadUInt32();

			// shotHeight
			screenshotData.shotHeight = binaryReader.ReadUInt32();

			// screenshotData
			UInt32 rgbIndexCount = screenshotData.shotWidth * screenshotData.shotHeight;
			screenshotData.R = new Byte[rgbIndexCount];
			screenshotData.G = new Byte[rgbIndexCount];
			screenshotData.B = new Byte[rgbIndexCount];
			for (UInt32 pixel = 0; pixel < rgbIndexCount; pixel++) {
				screenshotData.R[pixel] = binaryReader.ReadByte();
				screenshotData.G[pixel] = binaryReader.ReadByte();
				screenshotData.B[pixel] = binaryReader.ReadByte();
			}

			// formVersion
			header.formVersion = binaryReader.ReadByte();
		}
	}
}