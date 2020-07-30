﻿// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.TownNPCUICollectionInfoProvider
// Assembly: Terraria, Version=1.4.0.5, Culture=neutral, PublicKeyToken=null
// MVID: 67F9E73E-0A81-4937-A22C-5515CD405A83
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
  public class TownNPCUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
  {
    private string _persistentIdentifierToCheck;

    public TownNPCUICollectionInfoProvider(string persistentId)
    {
      this._persistentIdentifierToCheck = persistentId;
    }

    public BestiaryUICollectionInfo GetEntryUICollectionInfo()
    {
      return new BestiaryUICollectionInfo()
      {
        UnlockState = Main.BestiaryTracker.Chats.GetWasChatWith(this._persistentIdentifierToCheck) ? BestiaryEntryUnlockState.CanShowDropsWithDropRates_4 : BestiaryEntryUnlockState.NotKnownAtAll_0
      };
    }

    public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
    {
      return (UIElement) null;
    }
  }
}