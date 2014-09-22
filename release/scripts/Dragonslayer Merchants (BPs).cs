/* Dragonslayer Merchants (BPs Merchant)
 * Created By Deathwish
 * To be used with DragonslayerWeapons and AlbionDragonItems scripts
 * 
 * How to install: Place this script into your script folder
 * How to use ingame: /mob create DOL.GS.Scripts.DSWA  Alb Weapon merchant
 *                                               DSWM  Mid Weapon merchant
 *                                               DSWH  Hib Weapon merchant
 *                                               DSAA  Alb Armor merchant
 *                                               DSAM  Mid Armor merchant
 *                                               DSAH  Hib Armor merchant
 * 
 */



using System;
using System.Collections;

using DOL.GS.PacketHandler;
using DOL.AI.Brain;
using DOL.Database;
using DOL.Language;

namespace DOL.GS.Scripts
{
    public class DSWA : GameBountyMerchant // Alb Weapon Merchant
    {
        #region Constructor

        public DSWA()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("AlbionDragonWeapons");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSWM : GameBountyMerchant // Mid Weapon Merchant
    {
        #region Constructor

        public DSWM()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("MidgardDragonWeapons");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSWH : GameBountyMerchant // Hib Weapon Merchant
    {
        #region Constructor

        public DSWH()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("HiberniaDragonWeapons");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSAA : GameBountyMerchant // Alb Armor Merchant
    {
        #region Constructor

        public DSAA()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("AlbionDragonItems");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSAM : GameBountyMerchant // Mid Armor Merchant
    {
        #region Constructor

        public DSAM()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("MidgardDragonItems");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }


    public class DSAH : GameBountyMerchant // Hib Armor Merchant
    {
        #region Constructor

        public DSAH()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("HiberniaDragonItems");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }

}