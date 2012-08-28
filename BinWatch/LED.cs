using System;
using System.Collections.Generic;
using System.Text;

namespace BinWatch {
    public class LED {
        private int m_PosX, m_PosY;
        private int m_Height = 10, m_Width = 10;
        private int m_SpcX = 10, m_SpcY = 10;
        private int m_ID;
        private const int m_CountW = 6, m_CountH = 4;
        private static int m_Count = 0;

        public int ID {
            get { return m_ID; }
        }

        public int Height {
            get { return m_Height; }
            set
            {
                if(value > 0)
                    m_Height = value;
            }
        }

        public int Width {
            get { return m_Width; }
            set {
                if (value > 0)
                    m_Width = value;
            }
        }

        public int PosX {
            get { return m_PosX; }
            set { m_PosX = value; }
        }

        public int PosY {
            get { return m_PosY; }
            set { m_PosY = value; }
        }

        public int SpcX {
            get { return m_SpcX; }
            set { m_SpcX = value; }
        }

        public int SpcY {
            get { return m_SpcY; }
            set { m_SpcY = value; }
        }

        public LED(int PosX, int PosY) {
            m_ID = ++m_Count;
            m_PosX = PosX;
            m_PosY = PosY;
        }

        public LED(int PosX, int PosY, int Width, int Height) {
            m_ID = ++m_Count;
            m_PosX = PosX;
            m_PosY = PosY;
            m_Width = Width;            
            m_Height = Height;
        }

        public LED(int PosX, int PosY, int Width, int Height, int SpcX, int SpcY) {
            m_ID = ++m_Count;
            m_PosX = PosX;
            m_PosY = PosY;
            m_Width = Width;
            m_Height = Height;
            m_SpcX = SpcX;
            m_SpcY = SpcY;
        }
    }
}
