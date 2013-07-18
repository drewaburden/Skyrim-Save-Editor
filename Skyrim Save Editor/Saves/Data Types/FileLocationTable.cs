using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Save_Editor.Saves {
	public partial class SaveFile {
		public class FileLocationTable : SaveBlock {
			public SaveField<UInt32> formIDArrayCountOffset;
			public SaveField<UInt32> unknownTable3Offset;
			public SaveField<UInt32> globalDataTable1Offset;
			public SaveField<UInt32> globalDataTable2Offset;
			public SaveField<UInt32> changeFormsOffset;
			public SaveField<UInt32> globalDataTable3Offset;
			public SaveField<UInt32> globalDataTable1Count;
			public SaveField<UInt32> globalDataTable2Count;
			public SaveField<UInt32> globalDataTable3Count;
			public SaveField<UInt32> changeFormCount;
			public SaveField<UInt32[]> unused;

			public FileLocationTable() {
				formIDArrayCountOffset = new SaveField<UInt32>("formIDArrayCountOffset");
				unknownTable3Offset = new SaveField<UInt32>("unknownTable3Offset");
				globalDataTable1Offset = new SaveField<UInt32>("globalDataTable1Offset");
				globalDataTable2Offset = new SaveField<UInt32>("globalDataTable2Offset");
				changeFormsOffset = new SaveField<UInt32>("changeFormsOffset");
				globalDataTable3Offset = new SaveField<UInt32>("globalDataTable3Offset");
				globalDataTable1Count = new SaveField<UInt32>("globalDataTable1Count");
				globalDataTable2Count = new SaveField<UInt32>("globalDataTable2Count");
				globalDataTable3Count = new SaveField<UInt32>("globalDataTable3Count");
				changeFormCount = new SaveField<UInt32>("changeFormCount");
				unused = new SaveField<UInt32[]>("unused");
			}

			public void loadFields(SaveReader saveReader) {
				formIDArrayCountOffset.Value = saveReader.ReadUInt32();
				unknownTable3Offset.Value = saveReader.ReadUInt32();
				globalDataTable1Offset.Value = saveReader.ReadUInt32();
				globalDataTable2Offset.Value = saveReader.ReadUInt32();
				changeFormsOffset.Value = saveReader.ReadUInt32();
				globalDataTable3Offset.Value = saveReader.ReadUInt32();
				globalDataTable1Count.Value = saveReader.ReadUInt32();
				globalDataTable2Count.Value = saveReader.ReadUInt32();
				globalDataTable3Count.Value = saveReader.ReadUInt32();
				changeFormCount.Value = saveReader.ReadUInt32();
				unused.Value = new UInt32[15];
				for (int elementIndex = 0; elementIndex < unused.Value.Length; ++elementIndex) {
					unused.Value[elementIndex] = saveReader.ReadUInt32();
				}
			}
		};
	}
}
