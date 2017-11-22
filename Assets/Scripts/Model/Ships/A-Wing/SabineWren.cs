﻿using Mods.ModsList;

namespace Ship
{
    namespace AWing
    {
        public class SabineWren : AWing
        {
            public SabineWren() : base()
            {
                FromMod = typeof(PhoenixSquadronMod);

                PilotName = "Sabine Wren";
                PilotSkill = 5;
                Cost = 23;

                IsUnique = true;

                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Elite);

                SkinName = "Green";

                PilotAbilities.Add(new PilotAbilitiesNamespace.SabineWrenPilotAbility());
            }
        }
    }
}
