using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using Skyrim_Save_Editor.Saves;
using Skyrim_Save_Editor.Forms.Main.Advanced;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class MainForm {
		public static class ListViewGroups { // This would be an enum, but you can't index arrays with enums.
			public const int
				HEADER = 0,
				SAVE_INFO = 1,
				PLUGIN_INFO = 2,
				FILE_LOCATION_TABLE = 3,
				MISC_STATS = 4,
				PLAYER_LOCATION = 5,
				TES = 6;
		};
		void populateControls() {
			listViewItems = new ArrayList();
			removedListViewItems = new ArrayList();

			//int numFields = calcNumFields(activeSave.GetType());
			//Console.WriteLine(numFields);

			/*Object[] olvObjects = new Object[numFields];

			for (int x = 0; x < numFields; ++x) {
				olvObjects[x] = 
			}*/

			List<Object> fields = new List<Object>();
			foreach (SaveFile.SaveField field in activeSave.header) {
				fields.Add(field);
			}

			objectListView1.AddObjects(fields);

			TreeBuilder builder = new TreeBuilder();
			TreeItem tree = builder.createTree(activeSave);

			/*// headerSize
			ListViewItem headerSize = new ListViewItem(
				new String[2] {"headerSize", Convert.ToString(activeSave.headerSize)}, -1);
			headerSize.Group = listView1.Groups[HEADER];
			listViewItems.Add(headerSize);
			listView1.Items.Add((ListViewItem)headerSize.Clone());

			// version
			ListViewItem versionItem = new ListViewItem(
				new String[2] {"version", Convert.ToString(activeSave.header.version)}, -1);
			versionItem.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(versionItem);
			advancedKeyValues.Items.Add((ListViewItem)versionItem.Clone());

			// saveNumber
			ListViewItem saveNumberItem = new ListViewItem(
				new String[2] {"saveNumber", Convert.ToString(activeSave.header.saveNumber)}, -1);
			saveNumberItem.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(saveNumberItem);
			advancedKeyValues.Items.Add((ListViewItem)saveNumberItem.Clone());

			// playerName
			playerName.Text = activeSave.header.playerName;
			ListViewItem playerNameItem = new ListViewItem(
				new String[2] {"playerName", activeSave.header.playerName}, -1);
			playerNameItem.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(playerNameItem);
			advancedKeyValues.Items.Add((ListViewItem)playerNameItem.Clone());

			// playerLevel
			playerLevel.Value = activeSave.header.playerLevel;
			ListViewItem playerLevelItem = new ListViewItem(
				new String[2] {"playerLevel", Convert.ToString(activeSave.header.playerLevel)}, -1);
			playerLevelItem.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(playerLevelItem);
			advancedKeyValues.Items.Add((ListViewItem)playerLevelItem.Clone());

			// playerLocation
			ListViewItem playerLocation = new ListViewItem(
				new String[2] {"playerLocation", activeSave.header.playerLocation}, -1);
			playerLocation.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(playerLocation);
			advancedKeyValues.Items.Add((ListViewItem)playerLocation.Clone());

			// gameDate
			ingameDate.Text = activeSave.header.gameDate;
			ListViewItem gameDate = new ListViewItem(
				new String[2] {"gameDate", activeSave.header.gameDate}, -1);
			gameDate.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(gameDate);
			advancedKeyValues.Items.Add((ListViewItem)gameDate.Clone());

			// playerRaceEditorId
			int position;
			for(position = 0; position < 10; ++position)  {
				if (activeSave.header.playerRace == ((Race) position).ToString("g")) {
					break;
				}
			}
			playerRace.SelectedIndex = position;
			ListViewItem playerRaceEditorId = new ListViewItem(
				new String[2] {"playerRaceEditorId", ((Race) position).ToString("g")}, -1);
			playerRaceEditorId.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(playerRaceEditorId);
			advancedKeyValues.Items.Add((ListViewItem)playerRaceEditorId.Clone());

			// playerSex
			if (activeSave.header.playerSex == 1) {
				femaleSex.Checked = true;
				maleSex.Checked = false;
			}
			else {
				maleSex.Checked = true;
				femaleSex.Checked = false;
			}
			ListViewItem playerSex = new ListViewItem(
				new String[2] {"playerSex", Convert.ToString(activeSave.header.playerSex)}, -1);
			playerSex.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(playerSex);
			advancedKeyValues.Items.Add((ListViewItem)playerSex.Clone());

			// playerCurExp
			playerExperienceBar.Maximum = Convert.ToInt16(activeSave.header.playerLvlUpExp); // Have to set the max first
			playerExperienceBox.Maximum = Convert.ToDecimal(activeSave.header.playerLvlUpExp); // Have to set the max first
			playerExperienceBox.Value = Convert.ToDecimal(activeSave.header.playerCurExp);
			ListViewItem playerCurExp = new ListViewItem(
				new String[2] {"playerCurExp", Convert.ToString(activeSave.header.playerCurExp)}, -1);
			playerCurExp.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(playerCurExp);
			advancedKeyValues.Items.Add((ListViewItem)playerCurExp.Clone());

			// playerLvlUpExp
			ListViewItem playerLvlUpExp = new ListViewItem(
				new String[2] {"playerLvlUpExp", Convert.ToString(activeSave.header.playerLvlUpExp)}, -1);
			playerLvlUpExp.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(playerLvlUpExp);
			advancedKeyValues.Items.Add((ListViewItem)playerLvlUpExp.Clone());

			// filetime
			saveTime.Value = DateTime.FromFileTime(activeSave.header.saveTime64);
			ListViewItem dwHighDateTime = new ListViewItem(
				new String[2] {"dwHighDateTime", activeSave.header.saveTime.dwHighDateTime.ToString()}, -1);
			dwHighDateTime.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(dwHighDateTime);
			advancedKeyValues.Items.Add((ListViewItem)dwHighDateTime.Clone());
			ListViewItem dwLowDateTime = new ListViewItem(
				new String[2] {"dwLowDateTime", activeSave.header.saveTime.dwLowDateTime.ToString()}, -1);
			dwLowDateTime.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(dwLowDateTime);
			advancedKeyValues.Items.Add((ListViewItem)dwLowDateTime.Clone());

			// shotWidth
			ListViewItem shotWidth = new ListViewItem(
				new String[2] {"shotWidth", Convert.ToString(activeSave.header.screenshotData.shotWidth)}, -1);
			shotWidth.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(shotWidth);
			advancedKeyValues.Items.Add((ListViewItem)shotWidth.Clone());

			// shotHeight
			ListViewItem shotHeight = new ListViewItem(
				new String[2] {"shotHeight", Convert.ToString(activeSave.header.screenshotData.shotHeight)}, -1);
			shotHeight.Group = advancedKeyValues.Groups[ListViewGroups.HEADER];
			listViewItems.Add(shotHeight);
			advancedKeyValues.Items.Add((ListViewItem)shotHeight.Clone());

			// screenshot
			if (activeSave.header.screenshotData.shotWidth > 0 && activeSave.header.screenshotData.shotHeight > 0) {
				uint xpixelInArray = 0;
				Bitmap bitmap = new Bitmap(
					(int) activeSave.header.screenshotData.shotWidth,
					(int)activeSave.header.screenshotData.shotHeight);
				for (int ypixel = 0; ypixel < activeSave.header.screenshotData.shotHeight; ++ypixel) {
					for (int xpixel = 0; xpixel < activeSave.header.screenshotData.shotWidth; ++xpixel) {
						Color color;
						color = Color.FromArgb(
							(int) activeSave.header.screenshotData.R[xpixelInArray],
							(int) activeSave.header.screenshotData.G[xpixelInArray],
							(int) activeSave.header.screenshotData.B[xpixelInArray]);
						bitmap.SetPixel(xpixel, ypixel, color);
						++xpixelInArray;
					}
				}
				screenshot.Image = (Image) bitmap.Clone();
				bitmap.Dispose();
			}

			// saveName
			String fileName = openFileDialog.FileName;
			if (fileName.Length > 1) {
				int lastSlash = fileName.LastIndexOf('\\') + 1;
				if (lastSlash > 0) {
					fileName = fileName.Substring(lastSlash, fileName.Length - lastSlash);
				}
			}

			saveName.Text = (String) fileName.Clone();
			ListViewItem saveNameItem = new ListViewItem(
				new String[2] {"saveName", (String) fileName.Clone()}, -1);
			saveNameItem.Group = advancedKeyValues.Groups[ListViewGroups.SAVE_INFO];
			listViewItems.Add(saveNameItem);
			advancedKeyValues.Items.Add((ListViewItem) saveNameItem.Clone());

			// formVersion
			ListViewItem formVersion = new ListViewItem(
				new String[2] {"formVersion", Convert.ToString(activeSave.header.formVersion)}, -1);
			formVersion.Group = advancedKeyValues.Groups[ListViewGroups.SAVE_INFO];
			listViewItems.Add(formVersion);
			advancedKeyValues.Items.Add((ListViewItem)formVersion.Clone());

			// pluginInfoSize
			ListViewItem pluginInfoSize = new ListViewItem(
				new String[2] {"pluginInfoSize", Convert.ToString(activeSave.pluginInfoSize)}, -1);
			pluginInfoSize.Group = listView1.Groups[PLUGIN_INFO];
			listViewItems.Add(pluginInfoSize);
			listView1.Items.Add((ListViewItem)pluginInfoSize.Clone());

			// pluginCount
			ListViewItem pluginCount = new ListViewItem(
				new String[2] {"pluginCount", Convert.ToString(activeSave.pluginInfo.pluginCount)}, -1);
			pluginCount.Group = advancedKeyValues.Groups[ListViewGroups.PLUGIN_INFO];
			listViewItems.Add(pluginCount);
			advancedKeyValues.Items.Add((ListViewItem)pluginCount.Clone());

			// plugins
			foreach (String pluginName in activeSave.pluginInfo.plugins) {
				pluginsList.Items.Add(pluginName, true);
			}


			/////////////////////////
			// File Location Table //
			/////////////////////////

			// formIDArrayCountOffset
			ListViewItem formIDArrayCountOffset = new ListViewItem(
				new String[2] {"formIDArrayCountOffset",
				Convert.ToString(activeSave.fileLocationTable.formIDArrayCountOffset)}, -1);
			formIDArrayCountOffset.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(formIDArrayCountOffset);
			advancedKeyValues.Items.Add((ListViewItem)formIDArrayCountOffset.Clone());

			// unknownTable3Offset
			ListViewItem unknownTable3Offset = new ListViewItem(
				new String[2] {"unknownTable3Offset",
				Convert.ToString(activeSave.fileLocationTable.unknownTable3Offset)}, -1);
			unknownTable3Offset.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(unknownTable3Offset);
			advancedKeyValues.Items.Add((ListViewItem)unknownTable3Offset.Clone());

			// globalDataTable1Offset
			ListViewItem globalDataTable1Offset = new ListViewItem(
				new String[2] {"globalDataTable1Offset",
				Convert.ToString(activeSave.fileLocationTable.globalDataTable1Offset)}, -1);
			globalDataTable1Offset.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(globalDataTable1Offset);
			advancedKeyValues.Items.Add((ListViewItem)globalDataTable1Offset.Clone());

			// globalDataTable2Offset
			ListViewItem globalDataTable2Offset = new ListViewItem(
				new String[2] {"globalDataTable2Offset",
				Convert.ToString(activeSave.fileLocationTable.globalDataTable2Offset)}, -1);
			globalDataTable2Offset.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(globalDataTable2Offset);
			advancedKeyValues.Items.Add((ListViewItem)globalDataTable2Offset.Clone());

			// changeFormsOffset
			ListViewItem changeFormsOffset = new ListViewItem(
				new String[2] {"changeFormsOffset",
				Convert.ToString(activeSave.fileLocationTable.changeFormsOffset)}, -1);
			changeFormsOffset.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(changeFormsOffset);
			advancedKeyValues.Items.Add((ListViewItem)changeFormsOffset.Clone());

			// globalDataTable3Offset
			ListViewItem globalDataTable3Offset = new ListViewItem(
				new String[2] {"globalDataTable3Offset",
				Convert.ToString(activeSave.fileLocationTable.globalDataTable3Offset)}, -1);
			globalDataTable3Offset.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(globalDataTable3Offset);
			advancedKeyValues.Items.Add((ListViewItem)globalDataTable3Offset.Clone());

			// globalDataTable1Count
			ListViewItem globalDataTable1Count = new ListViewItem(
				new String[2] {"globalDataTable1Count",
				Convert.ToString(activeSave.fileLocationTable.globalDataTable1Count)}, -1);
			globalDataTable1Count.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(globalDataTable1Count);
			advancedKeyValues.Items.Add((ListViewItem)globalDataTable1Count.Clone());

			// globalDataTable2Count
			ListViewItem globalDataTable2Count = new ListViewItem(
				new String[2] {"globalDataTable2Count",
				Convert.ToString(activeSave.fileLocationTable.globalDataTable2Count)}, -1);
			globalDataTable2Count.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(globalDataTable2Count);
			advancedKeyValues.Items.Add((ListViewItem)globalDataTable2Count.Clone());

			// globalDataTable3Count
			ListViewItem globalDataTable3Count = new ListViewItem(
				new String[2] {"globalDataTable3Count",
				Convert.ToString(activeSave.fileLocationTable.globalDataTable3Count)}, -1);
			globalDataTable3Count.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(globalDataTable3Count);
			advancedKeyValues.Items.Add((ListViewItem)globalDataTable3Count.Clone());

			// changeFormCount
			ListViewItem changeFormCount = new ListViewItem(
				new String[2] {"changeFormCount",
				Convert.ToString(activeSave.fileLocationTable.changeFormCount)}, -1);
			changeFormCount.Group = advancedKeyValues.Groups[ListViewGroups.FILE_LOCATION_TABLE];
			listViewItems.Add(changeFormCount);
			advancedKeyValues.Items.Add((ListViewItem)changeFormCount.Clone());

			////////////////
			// MISC_STATS //
			////////////////

			// count
			ListViewItem count = new ListViewItem(
				new String[2] {"count", Convert.ToString(activeSave.miscStatsCount)}, -1);
			count.Group = listView1.Groups[MISC_STATS];
			listViewItems.Add(count);
			listView1.Items.Add((ListViewItem)count.Clone());

			foreach (MiscStat miscStat in activeSave.miscStats.statData) {
				// name
				ListViewItem name = new ListViewItem(
					new String[2] {miscStat.name, Convert.ToString(miscStat.value)}, -1);
				name.Group = advancedKeyValues.Groups[ListViewGroups.MISC_STATS];
				listViewItems.Add(name);
				advancedKeyValues.Items.Add((ListViewItem)name.Clone());
			}

			/////////////////////
			// PLAYER_LOCATION //
			/////////////////////

			// unknown
			ListViewItem unknown = new ListViewItem(
				new String[2] {"unknown", Convert.ToString(activeSave.unknown)}, -1);
			unknown.Group = listView1.Groups[PLAYER_LOCATION];
			listViewItems.Add(unknown);
			listView1.Items.Add((ListViewItem)unknown.Clone());

			// worldSpace1
			// type
			ListViewItem worldSpace1Type = new ListViewItem(
				new String[2] {"worldSpace1 type", Convert.ToString(activeSave.playerLocation.worldSpace1.type)}, -1);
			worldSpace1Type.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(worldSpace1Type);
			advancedKeyValues.Items.Add((ListViewItem)worldSpace1Type.Clone());
			// formID
			ListViewItem worldSpace1FormID = new ListViewItem(
				new String[2] {"worldSpace1 formID", activeSave.playerLocation.worldSpace1.hexFormID}, -1);
			worldSpace1FormID.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(worldSpace1FormID);
			advancedKeyValues.Items.Add((ListViewItem)worldSpace1FormID.Clone());
			
			// coorX
			ListViewItem coorX = new ListViewItem(
				new String[2] {"coorX", Convert.ToString(activeSave.playerLocation.coorX)}, -1);
			coorX.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(coorX);
			advancedKeyValues.Items.Add((ListViewItem)coorX.Clone());

			// coorY
			ListViewItem coorY = new ListViewItem(
				new String[2] {"coorY", Convert.ToString(activeSave.playerLocation.coorY)}, -1);
			coorY.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(coorY);
			advancedKeyValues.Items.Add((ListViewItem)coorY.Clone());
			
			// worldSpace2
			// type
			ListViewItem worldSpace2Type = new ListViewItem(
				new String[2] {"worldSpace2 type", Convert.ToString(activeSave.playerLocation.worldSpace2.type)}, -1);
			worldSpace2Type.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(worldSpace2Type);
			advancedKeyValues.Items.Add((ListViewItem)worldSpace2Type.Clone());
			// formID
			ListViewItem worldSpace2FormID = new ListViewItem(
				new String[2] {"worldSpace2 formID", activeSave.playerLocation.worldSpace2.hexFormID}, -1);
			worldSpace2FormID.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(worldSpace2FormID);
			advancedKeyValues.Items.Add((ListViewItem)worldSpace2FormID.Clone());

			// posX
			ListViewItem posX = new ListViewItem(
			new String[2] {"posX", Convert.ToString(activeSave.playerLocation.posX)}, -1);
			posX.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(posX);
			advancedKeyValues.Items.Add((ListViewItem)posX.Clone());

			// posY
			ListViewItem posY = new ListViewItem(
				new String[2] {"posY", Convert.ToString(activeSave.playerLocation.posY)}, -1);
			posY.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(posY);
			advancedKeyValues.Items.Add((ListViewItem)posY.Clone());

			// posZ
			ListViewItem posZ = new ListViewItem(
				new String[2] {"posZ", Convert.ToString(activeSave.playerLocation.posZ)}, -1);
			posZ.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(posZ);
			advancedKeyValues.Items.Add((ListViewItem)posZ.Clone());

			// unk
			ListViewItem unk = new ListViewItem(
				new String[2] {"unk", Convert.ToString(activeSave.playerLocation.unk)}, -1);
			unk.Group = advancedKeyValues.Groups[ListViewGroups.PLAYER_LOCATION];
			listViewItems.Add(unk);
			advancedKeyValues.Items.Add((ListViewItem)unk.Clone());*/
		}

		private void resetControls() {
			objectListView1.ClearObjects();
			saveName.ResetText();
			ingameDate.ResetText();
			saveTime.ResetText();
			playerName.ResetText();
			playerLevel.Value = 0;
			playerExperienceBar.Maximum = 100;
			playerExperienceBox.Maximum = 100;
			playerExperienceBox.Value = 0;
			playerRace.SelectedIndex = -1;
			maleSex.Checked = false;
			femaleSex.Checked = false;
			Bitmap image = new Bitmap(320, 192);
			screenshot.Image = (Image) image.Clone();
			labelScreenshot.Visible = true;
			pluginsList.Items.Clear();
			foreach (ListViewItem item in advancedKeyValues.Items) {
				item.Remove();
			}
			if (removedListViewItems != null) {
				foreach (ListViewItem item in removedListViewItems) {
					item.Remove();
				}
			}
			saveDiff = new SaveFile();
		}
	}
}
