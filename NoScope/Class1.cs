using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityScript;


namespace NoScope
{
    public class NoScope : BaseScript
    {

        public NoScope()
            : base()
        {
            base.PlayerConnected += spawn;
        }

        public void spawn(Entity player)
        {
            /*(player.SpawnedPlayer += new Action(() =>
            {
                player.Health = 500;
            });*/

                HudElem LabelA = HudElem.CreateFontString(player, "hudbig", 0.8f);
                LabelA.SetPoint("TOPRIGHT", "TOPRIGHT", -60, 10);
                LabelA.SetText("^0L^1S^3D^2 Snipe");
                LabelA.HideWhenInMenu = true;

                HudElem LabelC = HudElem.CreateFontString(player, "hudbig", 0.5f);
                LabelC.SetPoint("TOPRIGHT", "TOPRIGHT", -60, 30);
                LabelC.SetText("^5TS3: ^2codeascript.de");
                LabelC.HideWhenInMenu = true;

                HudElem LabelB = HudElem.CreateFontString(player, "hudbig", 0.8f);
                LabelB.SetPoint("TOPRIGHT", "TOPRIGHT", -60, 60);
                LabelB.SetText("...");
                LabelB.HideWhenInMenu = true;
                
                OnInterval(50, () =>
                {
                    LabelB.SetText(DateTime.Now.ToShortTimeString());
                    return true;
                });
            
        }
                
    }
}
