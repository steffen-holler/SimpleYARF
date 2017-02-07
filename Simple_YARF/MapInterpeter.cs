using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_YARF
{
    /// <summary>
    /// This class takes an 8- bit to a 32-bit bitmap and creates 
    /// from it based on the rules, a custom dungeon layout and 
    /// returns it to the over arching game for use as it sees fit.
    /// </summary>
    /// <remarks>
    /// Warning: here there is almost certain Dragons! you were warned.
    /// </remarks>
    class MapInterpeter
    {
        #region member variables
        private Bitmap map = null;
        private string mapPath = "";
        private byte[] mapObjects = null;
        #endregion

        #region properties
        /// <summary>
        /// Full map of the entire Dungeon with the objects
        /// based upon the rule set
        /// </summary>
        private byte[] MapObjects
        { get { return mapObjects; } }
        #endregion

        /// <summary>
        /// Creates a new dungeon based upon a bitmap image
        /// and given interpretive rule set.
        /// </summary>
        /// <param name="map"></param>
        public MapInterpeter(Bitmap map)
        {
            this.map = map;

            
        }

        #region public methods
        #endregion

        #region private methods
        /// <summary>
        /// This method converts the underlying bitmap image
        /// into a multi object and multi rule based dungeon
        /// </summary>
        private void Interpret()
        {
            // TODO : split into channels
            // create a different map of each channel 
            // determine which rule set to apply to which rules
        }

        /// <summary>
        /// This method interprets one and only one channel 
        /// of a single to multi-channel image and converts
        /// this channel into a 255 item dungeon map.
        /// </summary>
        /// <param name="ch"></param>
        private void InterpretChannel(short ch)
        {

        }
        #endregion
    }
}
