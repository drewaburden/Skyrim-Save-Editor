using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves;
using Skyrim_Save_Editor.Saves.SaveSections;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Forms.Main.Advanced {
	public class TreeBuilder {
		public TreeItem createTree(SaveFile save) {
			TreeItem root = buildTree(null, save);

			return root;
		}
		public TreeItem buildTree(TreeItem tree, SaveSection saveBlock) {
			TreeItem child = new TreeItem(saveBlock);
			child.Children = new List<TreeItem>();
			foreach (SaveSection childnode in saveBlock.GetSections()) {
				child.Children.Add(buildTree(child, childnode));
			}

			return child;
		}

		int level = 0;

		public void displayDebugTree(TreeItem tree) {
			for (int x = 0; x < level; ++x) {
				Console.Write("\t");
			}
			Console.WriteLine((tree.NodeData as SaveSection).blockName);
			++level;

			foreach (SaveField field in (tree.NodeData as SaveSection).GetFields()) {
				for (int x = 0; x < level; ++x) {
					Console.Write("\t");
				}
				Console.WriteLine((field as SaveField).Key);
				if (field is SaveField<String[]>) {
					++level;
					foreach (String stringItem in (field as SaveField<String[]>).Value) {
						for (int x = 0; x < level; ++x) {
							Console.Write("\t");
						}
						Console.WriteLine(stringItem);
					}
					--level;
				}
			}

			foreach (TreeItem child in tree) {
				displayDebugTree(child);
			}

			--level;
		}
	}
}
