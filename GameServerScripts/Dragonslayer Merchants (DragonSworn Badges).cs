/* Dragonslayer Merchants (DragonSworn Badges)
 * Created By Deathwish
 * To be used with DragonslayerWeapons and AlbionDragonItems scripts
 * This script is based on the GameDragonSwornMerchant script, so you buy items with DragonSworn Badges!
 * 
 * How to install: Place this script into your script folder
 * How to use ingame: /mob create DOL.GS.Scripts.DSWAT  Alb Weapon merchant
 *                                               DSWMT  Mid Weapon merchant
 *                                               DSWHT  Hib Weapon merchant
 *                                               DSAAT  Alb Armor merchant
 *                                               DSAMT  Mid Armor merchant
 *                                               DSAHT  Hib Armor merchant
 * You will need to edit your Items and weapon script if you want to use badges, change the items from Price 2500  to 25, then it will cost 25 badges per item not 2500 badges.
 */



using System;
using System.Collections;

using DOL.GS.PacketHandler;
using DOL.AI.Brain;
using DOL.Database;
using DOL.Language;

namespace DOL.GS.Scripts
{
    public class DSWAT : GameDragonSwornMerchant // Alb Weapon Merchant
    {
        #region Constructor

        public DSWAT()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3800);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 4000);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 4004);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 4003);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 4001);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 4002);
            Inventory = template.CloseTemplate();
            Name = "Dragon Weapons";
            GuildName = "Alb Merchant";
            Model = 33;
            Size = 54;
            Level = 60;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("AlbionDragonslayerWeapons");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSWMT : GameDragonSwornMerchant // Mid Weapon Merchant
    {
        #region Constructor

        public DSWMT()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3801);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 4031);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 4035);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 4034);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 4032);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 4033);
            Inventory = template.CloseTemplate();
            Name = "Dragon Weapons";
            GuildName = "Mid Merchant";
            Model = 144;
            Size = 54;
            Level = 60;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("MidgardDragonWeapons");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSWHT : GameDragonSwornMerchant // Hib Weapon Merchant
    {
        #region Constructor

        public DSWHT()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3802);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 4089);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 4088);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 4087);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 4085);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 4086);
            Inventory = template.CloseTemplate();
            Name = "Dragon Weapons";
            GuildName = "Hib Merchant";
            Model = 334;
            Size = 54;
            Level = 60;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("HiberniaDragonWeapons");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSAAT : GameDragonSwornMerchant // Alb Armor Merchant
    {
        #region Constructor

        public DSAAT()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3800);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 4000);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 4004);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 4003);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 4001);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 4002);
            Inventory = template.CloseTemplate();
            Name = "Dragon Armor";
            GuildName = "Alb Merchant";
            Model = 33;
            Size = 54;
            Level = 60;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("AlbionDragonItems");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSAMT : GameDragonSwornMerchant // Mid Armor Merchant
    {
        #region Constructor

        public DSAMT()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3801);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 4031);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 4035);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 4034);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 4032);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 4033);
            Inventory = template.CloseTemplate();
            Name = "Dragon Armor";
            GuildName = "Mid Merchant";
            Model = 144;
            Size = 54;
            Level = 60;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("MidgardDragonItems");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSAHT : GameDragonSwornMerchant // Hib Armor Merchant
    {
        #region Constructor

        public DSAHT()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3802);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 4089);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 4088);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 4087);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 4085);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 4086);
            Inventory = template.CloseTemplate();
            Name = "Dragon Armor";
            GuildName = "Hib Merchant";
            Model = 334;
            Size = 54;
            Level = 60;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("HiberniaDragonItems");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }

}