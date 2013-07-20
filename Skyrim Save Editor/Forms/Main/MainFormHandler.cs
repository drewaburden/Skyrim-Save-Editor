using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class MainFormManager {
		private SaveFile activeSave;
		private SaveFile saveDiff; // Changes made that are different from the originally loaded save will be stored here

		private ArrayList listViewItems;
		private ArrayList removedListViewItems;
	}
}
