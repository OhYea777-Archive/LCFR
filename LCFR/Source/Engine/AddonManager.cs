using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LCFR;

using GTA;

namespace Engine
{

    /// <summary>
    /// Manager for implementing addons
    /// </summary>
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

        /// <summary>
        /// Function loads the default addons
        /// </summary>
        public void loadDefaults()
        {
            registerAndInit(new Pullover());
            registerAndInit(new Speedometer());
        }

        /// <summary>
        /// Function registers an <see cref="IAddon"/>
        /// </summary>
        /// <param name="addon">IAddon to be registered</param>
        /// <returns></returns>
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

        /// <summary>
        /// Function registers and initializes <see cref="IAddon"/>
        /// </summary>
        /// <param name="addon">IAddon to be registered and initialized</param>
        public void registerAndInit(IAddon addon)
        {
            if (register(addon))
                addon.onInitialize(engine);
        }

    }

    /// <summary>
    /// <see cref="IAddon"/> interface. All functions are required
    /// </summary>
    public interface IAddon
    {

        /// <summary>
        /// Called on initialization of the <see cref="IAddon"/>
        /// </summary>
        /// <param name="engine">Contains an instance of the LCFREngine class</param>
        void onInitialize(LCFREngine engine);

        /// <summary>
        /// Function called when a key is pressed down in game
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="args">Args of the event</param>
        void onKeyDown(object sender, KeyEventArgs args);

        /// <summary>
        /// Function called on tick in-game
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Args of the event</param>
        void onTick(object sender, EventArgs e);

        /// <summary>
        /// Function called when a frame is drawn
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Args of the event</param>
        void onFrameDraw(object sender, GraphicsEventArgs e);

    }

}
