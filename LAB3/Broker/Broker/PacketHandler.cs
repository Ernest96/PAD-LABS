using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker
{
    class PacketHandler
    {
        public static (string message, ushort themeId) Handle(byte[] packet)
        {
            ushort themeId = BitConverter.ToUInt16(packet, 0);
            ushort packetLength = BitConverter.ToUInt16(packet, 2);
            byte[] data = new byte[packetLength];
            Array.Copy(packet, 4, data, 0, packetLength);
            string message = Encoding.Default.GetString(data);

            Console.WriteLine($"Packet received: Length: {packetLength + 2}  ");
            Console.WriteLine($"Theme id {themeId}");
            Theme t = DbUtility.GetThemeFromDb(themeId);
            if (t != null)
            {
                Console.WriteLine(t.ToString());
            }

            return (message, themeId);
        }
    }
}
