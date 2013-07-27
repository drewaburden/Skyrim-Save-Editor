using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Diagnostics;
using Skyrim_Save_Editor.Saves.SaveFields;
using Skyrim_Save_Editor.Saves.SaveSections;

namespace Skyrim_Save_Editor.Saves {
	public enum Race {
		AltmerRace,
		ArgonianRace,
		BosmerRace,
		BretonRace,
		DunmerRace,
		ImperialRace,
		KhajiitRace,
		NordRace,
		OrcRace,
		RedguardRace
	};

	public class SaveFile : SaveSection {
		public SaveSection header;
		public SaveSection pluginInfo;
		public SaveSection fileLocationTable;
		public SaveSection globalDataTable1;
		public SaveSection globalDataTable2;
		public SaveSection changeForms;
		public SaveSection globalDataTable3;

		public SaveFile() {
			blockName = "Save File";
			header = new Header();
			pluginInfo = new PluginInfo();
			fileLocationTable = new FileLocationTable();
			globalDataTable1 = new GlobalDataTable1();
			globalDataTable2 = new GlobalDataTable2();
			changeForms = new ChangeForms();
			globalDataTable3 = new GlobalDataTable3();
		}
		public SaveFile CreateNew() {
			try {
				ResourceManager resourceManager = new ResourceManager("Skyrim_Save_Editor.Resources.Resource", Assembly.GetExecutingAssembly());
				Byte[] resource = (Byte[]) resourceManager.GetObject("DefaultSave");
				SaveReader saveReader = new SaveReader(new MemoryStream(resource));

				Load(saveReader);
			}
			catch (Exception exception) {
				/* todo: write custom error dialog */
				MessageBox.Show("Error accessing resources:\n" + exception.Message + "\n\n" + exception.StackTrace);
				return default(SaveFile);
			}

			return this;
		}
		public SaveFile LoadFromFile(String filename) {
			FileStream file = null;
			try {
				file = new FileStream(filename, FileMode.Open);
				SaveReader saveReader = new SaveReader(file);

				Load(saveReader);
			}
			catch (Exception exception) {
				/* todo: write custom error dialog */
				MessageBox.Show("Error loading save file:\n" + exception.Message + "\n\n" + exception.StackTrace);
				return default(SaveFile);
			}
			finally {
				if (file != null) {
					file.Close();
				}
			}

			return this;
		}

		public override void Load(SaveReader saveReader) {
			(header as Header).Load(saveReader);
			(pluginInfo as PluginInfo).Load(saveReader);
			(fileLocationTable as FileLocationTable).Load(saveReader);
			(globalDataTable1 as GlobalDataTable1).Load(saveReader);
			(globalDataTable2 as GlobalDataTable2).Load(saveReader);
			(changeForms as ChangeForms).Load(saveReader);
			(globalDataTable3 as GlobalDataTable3).Load(saveReader);
		}

		public override SaveField[] GetFields() {
			return new SaveField[0];
		}
		public override SaveSection[] GetSections() {
			return new SaveSection[7] {
					header, pluginInfo, fileLocationTable, globalDataTable1,
					globalDataTable2, changeForms, globalDataTable3
			};
		}
	}
}
