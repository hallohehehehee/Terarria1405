﻿// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.BigProgressBar.IBigProgressBar
// Assembly: Terraria, Version=1.4.0.5, Culture=neutral, PublicKeyToken=null
// MVID: 67F9E73E-0A81-4937-A22C-5515CD405A83
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
  internal interface IBigProgressBar
  {
    bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info);

    void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch);
  }
}
