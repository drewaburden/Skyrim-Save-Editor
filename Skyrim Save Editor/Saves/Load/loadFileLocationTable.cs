using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveManager {
		void loadFileLocationTable(BinaryReader binaryReader) {
			FileLocationTable fileLocationTable = loadedSave.fileLocationTable; // For code cleanliness

			// formIDArrayCountOffset
			fileLocationTable.formIDArrayCountOffset = binaryReader.ReadUInt32();

			// unknownTable3Offset
			fileLocationTable.unknownTable3Offset = binaryReader.ReadUInt32();

			// globalDataTable1Offset
			fileLocationTable.globalDataTable1Offset = binaryReader.ReadUInt32();

			// globalDataTable2Offset
			fileLocationTable.globalDataTable2Offset = binaryReader.ReadUInt32();

			// changeFormsOffset
			fileLocationTable.changeFormsOffset = binaryReader.ReadUInt32();

			// globalDataTable3Offset
			fileLocationTable.globalDataTable3Offset = binaryReader.ReadUInt32();

			// globalDataTable1Count
			fileLocationTable.globalDataTable1Count = binaryReader.ReadUInt32();

			// globalDataTable2Count
			fileLocationTable.globalDataTable2Count = binaryReader.ReadUInt32();

			// globalDataTable3Count
			fileLocationTable.globalDataTable3Count = binaryReader.ReadUInt32();

			// changeFormCount
			fileLocationTable.changeFormCount = binaryReader.ReadUInt32();

			// unused
			fileLocationTable.unused = new UInt32[15];
			for (int elementIndex = 0; elementIndex < fileLocationTable.unused.Length; ++elementIndex) {
				fileLocationTable.unused[elementIndex] = binaryReader.ReadUInt32();
			}
		}
	}
}