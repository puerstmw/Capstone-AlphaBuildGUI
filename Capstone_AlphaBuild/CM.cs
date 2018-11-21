using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Capstone_AlphaBuild
{
    public class CM
    {
        public static SerialPort Port = new SerialPort("COM5", 115200, Parity.None, 8, StopBits.One);

        public static string ComPort = "COM5";
        public static int BaudRate = 115200;

        public static void UpdateSerialComm(string comport, int baudrate)
        {
            ComPort = comport;
            BaudRate = baudrate;
            //Change Serial Port item Port
        }   
        
        public static void EstablishPort()
        {
            
        }

        public static byte[] ReceiveData()
        {            
            byte[] DataArray = new byte[1024];
            int NumBytes;

            try
            {
                Port.Open();
            }
            catch { }

            NumBytes = Port.BytesToRead;
            Port.Read(DataArray, 0, NumBytes);            

            try
            {
                Port.Close();
            }
            catch { }

            return DataArray;            
        }

        public static List<byte[]> SeperateData(byte[] Data)
        {
            List<byte[]> SeperatedData = new List<byte[]>();
            List<byte> ModList = new List<byte>();
            int IML = 0;            //Iterative message length
            bool MessagesPresent = true;

            ModList = Data.ToList();

            while (MessagesPresent)
            {
                IML = Convert.ToInt32(ModList[0]);         //Assuming length is only over first byte
                SeperatedData.Add(ModList.Skip(1).Take(IML).ToArray());
                ModList.RemoveRange(0, IML);
                if (ModList.Count == 0) MessagesPresent = false;
            }

            return SeperatedData;
        }

        public static void DisplayData(List<byte> Data, RichTextBox richTextBox)
        {
            string DataString = string.Empty;

            foreach (byte DataByte in Data)
            {
                DataString += Convert.ToInt32(DataByte).ToString();
            }

            richTextBox.Text = DataString;
        }
    }
}
