using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRCP
{
    class StoreRCP
    {
        //private static StoreRCP instance = null;
        public StoreRCP()
        {

        }
        /*
        public static StoreRCP Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new StoreRCP();
                }
                return instance;
            }
        }
        */

        public int nDeviceIndex = 0;
        public void setDeviceIndex(int index)
        {
            this.nDeviceIndex = index;
        }
        public int getDeviceIndex()
        {
            return this.nDeviceIndex;
        }

        public int nCommandIndex = 0;
        public void setCommandIndex(int index)
        {
            this.nCommandIndex = index;
        }
        public int getCommandIndex()
        {
            return this.nCommandIndex;
        }

        public bool isOnOffPower = false;
        public void setOnOff(Boolean isOn)
        {
            this.isOnOffPower = isOn;
        }
        public bool getOnOff()
        {
            return this.isOnOffPower;
        }

        public bool isBeep = false;
        public void setBeep(Boolean isOn)
        {
            this.isBeep = isOn;
        }
        public bool getBeep()
        {
            return this.isBeep;
        }

        public bool isVibration = false;
        public void setVibration(Boolean isOn)
        {
            this.isVibration = isOn;
        }
        public bool getVibration()
        {
            return this.isVibration;
        }

        public bool isLED = false;
        public void setLED(Boolean isOn)
        {
            this.isLED = isOn;
        }
        public bool getLED()
        {
            return this.isLED;
        }

        public bool isIllumination = false;
        public void setIllumination(Boolean isOn)
        {
            this.isIllumination = isOn;
        }
        public bool getIllumination()
        {
            return this.isIllumination;
        }

        public int nInformationMode = 0;
        public void setInformationMode(int mode)
        {
            this.nInformationMode = mode;
        }
        public int getInformationMode()
        {
            return this.nInformationMode;
        }

        public int nChannel = 0;
        public void setChannel(int chan)
        {
            this.nChannel = chan;
        }
        public int getChannel()
        {
            return this.nChannel;
        }

        public int nChannelOffset = 0;
        public void setOffset(int offset)
        {
            this.nChannelOffset = offset;
        }
        public int getOffset()
        {
            return this.nChannelOffset;
        }

        public double dTXPower = 18.0;
        public void setTXPower(double power)
        {
            this.dTXPower = power;
        }
        public double getTXPower()
        {
            return this.dTXPower;
        }


    }
}
