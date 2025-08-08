using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KE_BatchExporter
{
	class KanimFinder
	{
		public static List<KanimFileInfo> FindKanimFilesRecursively(DirectoryInfo root, List<KanimFileInfo> items = null)
		{
			if (items == null)
				items = new List<KanimFileInfo>();
			if (KanimFileInfo.PathContainsKanim(root, out var kanim))
			{
				items.Add(kanim);
				return items;
			}
			foreach (var dir in root.GetDirectories())
			{
				FindKanimFilesRecursively(dir, items);
			}
			return items;
		}
	}
}
