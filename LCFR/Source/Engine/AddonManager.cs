using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LCFR;

using GTA;

namespace Engine
{

    public class AddonManager
    {

        private LCFREngine engine;

        private List<IAddon> addons;

        public AddonManager(LCFREngine engine)
        {
            this.engine = engine;
            this.addons = new List<IAddon>();

            loadDefaults();
        }

        public void loadDefaults()
        {
            registerAndInit(new Speedometer());
        }

        public bool register(IAddon addon)
        {
            if (!addons.Contains(addon))
            {
                addons.Add(addon);

                engine.KeyDown += addon.onKeyDown;
                engine.Tick += addon.onTick;
                engine.PerFrameDrawing += addon.onFrameDraw;

                return true;
            }

            return false;
        }

        public void registerAndInit(IAddon addon)
        {
            if (register(addon))
                addon.onInitialize(engine);
        }

    }

    public interface IAddon
    {

        void onInitialize(LCFREngine engine);

        void onKeyDown(object sender, KeyEventArgs args);

        void onTick(object sender, EventArgs e);

        void onFrameDraw(object sender, GraphicsEventArgs e);

    }

}
