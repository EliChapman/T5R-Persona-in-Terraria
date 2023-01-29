using SubworldLibrary;
using System.Collections.Generic;
using Terraria;
using Terraria.WorldBuilding;

namespace T5R.Content.Subworlds.VelvetRoom
{
    public class VelvetRoom : Subworld
    {
        public override int Width => 400;
        public override int Height => 400;

        public override bool ShouldSave => false;
        public override bool NoPlayerSaving => false;

        public override List<GenPass> Tasks => new List<GenPass>()
        {
            new VelvetRoomGenPass()
        };

        public override void OnEnter()
        {
            // SubworldSystem.noReturn = true;
            SubworldSystem.hideUnderworld = true;
        }

        // Sets the time to the middle of the day whenever the subworld loads
        public override void OnLoad()
        {
            Main.dayTime = true;
            Main.time = 27000;
        }
    }
}