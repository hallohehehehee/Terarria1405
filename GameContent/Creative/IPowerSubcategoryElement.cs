﻿// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Creative.IPowerSubcategoryElement
// Assembly: Terraria, Version=1.4.0.5, Culture=neutral, PublicKeyToken=null
// MVID: 67F9E73E-0A81-4937-A22C-5515CD405A83
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.UI.Elements;

namespace Terraria.GameContent.Creative
{
  public interface IPowerSubcategoryElement
  {
    GroupOptionButton<int> GetOptionButton(
      CreativePowerUIElementRequestInfo info,
      int optionIndex,
      int currentOptionIndex);
  }
}
