using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYNX_FTY_V3
{
    class globalVars
    {
        public static int maxLenPIN = 8; //MaxLength
        public static string currentUser = ""; //Whois currentUser
        public static string currentUserPIN = ""; //Whois current user's PIN
        public static string partNumber = "123"; //Part NumberENUMERABLE STRING COLLECTION

        public static string workOrder = "123123"; //Work Order
        public static string currentNumpadString = ""; // Current numpad string

        public static List<string> possibleReasons = new List<string>(new string[]{
"Band pass: Failed gen2 measurement >60nm",
"Contamination: Can’t be removed with N2 or eco-snow, but not a pit",
"CT: Insufficient part thickness remaining",
"Double cut: Dual plano plane seen on machine or interferometer",
"Eco-snow: Gun spits off frost thus staining part",
"Grain: Enhanced grain boundaries",
"Haze: Surface has orange peel type appearance",
"Irregularity: Surface figure out of drawing spec",
"Knife edge: Chips, dings, dents, or burr on knife edge",
"Operator error: Part has to be rematched",
"Pits: Star in the night sky specs",
"Pressure: Failed pressure on Amada Gen2 and VRM’s only",
"Q-tip: Need to clean part, but marked mirror surface while cleaning",
"Satellite: Unacceptable diffraction",
"Scratch: Appearing at any high-intensity light angle, digs",
"Spittle: Failure to use facemask",
"Stain: Eco-snow spittle, Q-tip wipe, acetone mark",
"Surface finish: Greater than drawing spec",
"Touch-off: Needs more than usual number of cuts to remove any damage",
"Void: Using stereo microscope, surface has void that is not moveable",
"Wedge: Mirror surface parallelism to base out of spec",
"Wiper: Wispy thin chalk mark",
"Tool height: 2-Axis product",
"X-Center Error: 2-Axis product",
"Radius",
"Cleanup",
"Ding",
"Hysteresis: 2-Axis artifact at part center",
"Chatter: Used for VRM’s only",
"Plating: Delamination, poor plating",
"Inclusion scratches: Used for VRM’s only"
        });
    }
}
