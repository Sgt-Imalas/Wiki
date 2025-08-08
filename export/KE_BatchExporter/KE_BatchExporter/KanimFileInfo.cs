using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KE_BatchExporter
{
    class KanimFileInfo
    {
        public FileInfo SpriteSheet, Build, Anim;
		public bool IsValid => SpriteSheet != null && Build != null && Anim != null;


		internal static bool PathContainsKanim(DirectoryInfo root, out KanimFileInfo kanim)
		{
			kanim = new KanimFileInfo();
			foreach (var file in root.GetFiles())
			{
				if(file.Extension == ".png")
				{
					if (kanim.SpriteSheet == null)
						kanim.SpriteSheet = file;
				}
				else if (file.Extension == ".bytes" || file.Extension == ".txt")
				{
					if (kanim.Anim == null && file.Name.Contains("_anim"))
						kanim.Anim = file;
					else if (kanim.Build == null && file.Name.Contains("_build"))
						kanim.Build = file;
				}
			}
			return kanim.IsValid;
		}
	}
}
