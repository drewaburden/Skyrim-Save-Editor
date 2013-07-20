using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Skyrim_Save_Editor.Saves {
	public class SaveReader : BinaryReader {
		public SaveReader(Stream stream) : base(stream) { }

		public override String ReadString() {
			int length = ReadInt16();
			return ReadString(length);
		}
		public String ReadString(int length) {
			return (String) (new String(ReadChars(length))).Clone();
		}

		public FILETIME ReadFILETIME() {
			FILETIME fileTime = new FILETIME();

			fileTime.dwLowDateTime = ReadInt32();
			fileTime.dwHighDateTime = ReadInt32();

			return fileTime;
		}

		public ScreenshotData ReadScreenshotData() {
			ScreenshotData screenshotData = new ScreenshotData();

			screenshotData.shotWidth = ReadUInt32();
			screenshotData.shotHeight = ReadUInt32();

			// read pixels
			UInt32 rgbIndexCount = screenshotData.shotWidth * screenshotData.shotHeight;
			screenshotData.R = new Byte[rgbIndexCount];
			screenshotData.G = new Byte[rgbIndexCount];
			screenshotData.B = new Byte[rgbIndexCount];
			for (UInt32 pixel = 0; pixel < rgbIndexCount; pixel++) {
				screenshotData.R[pixel] = ReadByte();
				screenshotData.G[pixel] = ReadByte();
				screenshotData.B[pixel] = ReadByte();
			}

			return screenshotData;
		}

		public MiscStat ReadMiscStat() {
			return ReadMiscStat(1)[0];
		}
		public MiscStat[] ReadMiscStat(int num) {
			MiscStat[] miscStats = new MiscStat[num];
			for (int elementIndex = 0; elementIndex < miscStats.Length; ++elementIndex) {
				miscStats[elementIndex] = new MiscStat(ReadString());
				miscStats[elementIndex].Category = ReadByte();
				miscStats[elementIndex].Value = ReadInt32();
			}
			return miscStats;
		}

		public String ReadPlugin() {
			return ReadPlugin(1)[0];
		}
		public String[] ReadPlugin(int num) {
			String[] plugins = new String[num];
			for (int pluginIndex = 0; pluginIndex < plugins.Length; ++pluginIndex) {
				plugins[pluginIndex] = ReadString();
			}
			return plugins;
		}

		public RefID ReadRefID(String name) {
			RefID refID = new RefID(name);
			refID.formID = new Byte[3];

			BaseStream.Read(refID.formID, 0, 3); // Read only 3 bytes into the buffer

			refID.type = (Byte) (refID.formID[0] >> 6); // Get the upper 2 bits, which represent the formID type
			refID.formID[0] <<= 2; // Get the remaining lower 6 bits to form the completed "22-bit" byte array

			// Convert the "22-bit" byte array to a readable hex string for easy lookup in the Creation Kit, etc.
			refID.Value = "0x" +
				BitConverter.ToString(refID.formID, 0)
				.Replace("-", String.Empty).PadLeft(8, '0');

			return refID;
		}
	}
}
