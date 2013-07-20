using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves;

namespace Skyrim_Save_Editor.Forms.Main.Advanced {
	public class TreeBuilder {
		public TreeItem createTree(SaveFile save) {
			TreeItem root = new TreeItem(save);
			root.Children = new List<TreeItem>();
			foreach (SaveSection node in save.GetSections()) {
				root.Children.Add(buildTree(root, node));
			}

			return root;
		}
		public TreeItem buildTree(TreeItem tree, SaveSection saveBlock) {
			tree.Children = new List<TreeItem>();
			foreach (SaveSection node in saveBlock.GetSections()) {
				TreeItem child = null;

				foreach (TreeItem innerTree in tree.Children) {
					child = buildTree(innerTree, node);
					child.NodeData = node;
				}

				tree.Children.Add(child);
			}

			return tree;
		}
	}
}
