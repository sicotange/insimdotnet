using System;

namespace InSimDotNet.Packets
{
    public class IS_CIM : IPacket
    {
        /// <summary>
        /// Gets the size of the packet.
        /// </summary>
        public byte Size { get; private set; }

        /// <summary>
        /// Gets the type of the packet.
        /// </summary>
        public PacketType Type { get; private set; }

        /// <summary>
        /// Gets the packet request ID.
        /// </summary>
        public byte ReqI { get; private set; }

        /// <summary>
        /// Gets the unique ID of the connection 
        /// </summary>
        public byte UCID { get; private set; }

        /// <summary>
        /// Gets the mode identifier of the current player.
        /// </summary>
        public ModeIndentifier Mode { get; private set; }

        /// <summary>
        /// Gets the sub mode identifier of the current player.
        /// </summary>
        public SubModeIndentifier SubMode { get; private set; }

        /// <summary>
        /// selected object type
        /// </summary>
        public byte SelType { get; private set; }


        public IS_CIM()
        {
            Size = 8;
            Type = PacketType.ISP_CIM;
        }

        /// <summary>
        /// Creates a new Conn Interface Mode packet.
        /// </summary>
        /// <param name="buffer">A buffer contaning the packet data.</param>
        public IS_CIM(byte[] buffer)
            : this()
        {
            PacketReader reader = new PacketReader(buffer);
            Size = reader.ReadByte();
            Type = (PacketType)reader.ReadByte();
            ReqI = reader.ReadByte();
            UCID = reader.ReadByte();
            Mode = (ModeIndentifier)reader.ReadByte();
            SubMode = (SubModeIndentifier)reader.ReadByte();
            SelType = reader.ReadByte();
        }
    }


    //ORIGINAL from InSim.txt
    /* 
     
     struct IS_CIM // Conn Interface Mode
     {
         byte Size;      // 8
         byte Type;      // ISP_CIM
         byte ReqI;      // 0
         byte UCID;      // connection's unique id (0 = host)

         byte Mode;      // mode identifier (see below)
         byte SubMode;   // submode identifier (see below)
         byte SelType;   // selected object type (see below)
         byte Sp3;
     };

     // Mode identifiers

     enum
     {
         CIM_NORMAL,         // 0 - not in a special mode
         CIM_OPTIONS,        // 1
         CIM_HOST_OPTIONS,   // 2
         CIM_GARAGE,         // 3
         CIM_CAR_SELECT,     // 4
         CIM_TRACK_SELECT,   // 5
         CIM_SHIFTU,         // 6 - free view mode
         CIM_NUM
     };

     // Submode identifiers for free view mode

     enum
     {
         FVM_PLAIN,          // no buttons displayed
         FVM_BUTTONS,        // buttons displayed (not editing)
         FVM_SP2,            // reserved
         FVM_SP3,            // reserved
         FVM_EDIT_CHALK,
         FVM_EDIT_CONES,
         FVM_EDIT_TYRES,
         FVM_EDIT_MARKERS,
         FVM_EDIT_OTHER,
         FVM_EDIT_CONCRETE,
         FVM_EDIT_CONTROL,
         FVM_EDIT_MARSH,
         FVM_NUM
     };

     // NOTE : SelType is zero if no object type is selected
     // in most modes it refers to an AXO_x as in ObjectInfo
     // in FV_EDIT_MARSH mode it may be one of these :

     const int MARSH_IS_CP = 252; // insim checkpoint
     const int MARSH_IS_AREA = 253; // insim circle
     const int MARSH_MARSHALL = 254; // restricted area
     const int MARSH_ROUTE = 255; // route checker

     */
}
