/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 */

using System;
using System.Reflection;
using DOL.Database;
using log4net;
using DOL.GS;
using DOL.GS.PacketHandler;

namespace DOL.GS
{
	public class dragonbadges : LootGeneratorBase
	{
		private static int DROP_CHANCE = 60;
		private static int MAX_DROPS = 10;

		protected static ItemTemplate[][] m_itemTemplates=null;

        public dragonbadges()
		{
		}

		public override LootList GenerateLoot(GameNPC mob, GameObject killer)
		{
      		LootList loot = new LootList();
            if (mob.Name.ToLower() == "granite giant stonelord" || mob.Name.ToLower() == "granite giant pounder" || mob.Name.ToLower() == "granite giant stonecaller" || mob.Name.ToLower() == "drakulv disciple" || mob.Name.ToLower() == "drakulv executioner" || mob.Name.ToLower() == "drakulv protector" || mob.Name.ToLower() == "glimmer knight" || mob.Name.ToLower() == "glimmer deathwatcher" || mob.Name.ToLower() == "glimmer geist")
			{
				if (Util.Chance(DROP_CHANCE))
				{
					int count = 1;
					if(MAX_DROPS > 10) count = Util.Random(10, MAX_DROPS);
					for(int i = 0; i < count; i++)
						loot.AddFixed(GetArtifact(),1);
				}
			}
			return loot;
		}

		public virtual ItemTemplate GetArtifact()
        {
            ItemTemplate dragonswornbadge = GameServer.Database.FindObjectByKey<ItemTemplate>("dragonswornbadge");
            return dragonswornbadge;
		}
	}
}
