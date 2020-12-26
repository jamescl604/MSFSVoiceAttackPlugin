//=================================================================================================================
// PROJECT: MSFS Agent
// PURPOSE: This file defines the set of events that can be triggered in the sim through the agent
// AUTHOR: James Clark
// Licensed under the MS-PL license. See LICENSE.md file in the project root for full license information.
//================================================================================================================= 
using System.Collections.Generic;


namespace MSFS
{
 
    // Identifies the types of events we want to be able to call against the sim
    public enum EventTypes
    {
        SIMSTART,
        SIMSTOP,
        PAUSE,

        ADF_COMPLETE_SET,                             //Sets ADF 1 frequency (BCD Hz)
        ADF2_COMPLETE_SET,                            //Sets ADF 1 frequency (BCD Hz)
        AP_ALT_VAR_SET_ENGLISH,                       //Sets altitude reference in feet
        AP_NAV_SELECT_SET,                            //Sets the nav (1 or 2) which is used by the Nav hold modes
        AP_SPD_VAR_SET,                               //Sets airspeed reference in knots
        AP_VS_VAR_SET_ENGLISH,                        //Sets reference vertical speed in feet per minute
        BLEED_AIR_SOURCE_CONTROL_SET,                 //0: auto, 1: off, 2: apu, 3: engines
        COM_RADIO_SET,                                //Sets COM frequency (BCD Hz)
        COM_STBY_RADIO_SET,                           //Sets COM 1 standby frequency (BCD Hz)
        COM_STBY_RADIO_SWAP,                          //Swaps COM 1 frequency with standby
        COM1_TRANSMIT_SELECT,                         //Selects COM 1 to transmit
        COM2_RADIO_SET,                               //Sets COM 2 frequency (BCD Hz)
        COM2_RADIO_SWAP,                              //Swaps COM 2 frequency with standby
        COM2_STBY_RADIO_SET,                          //Sets COM 2 standby frequency (BCD Hz)
        COM2_TRANSMIT_SELECT,                         //Selects COM 2 to transmit
        DME1_TOGGLE,                                  //Sets DME display to Nav 1
        DME2_TOGGLE,                                  //Sets DME display to Nav 2
        HEADING_BUG_SET,                              //Set heading hold reference bug (degrees)
        NAV1_RADIO_SET,                               //Sets NAV 1 frequency (BCD Hz)
        NAV1_RADIO_SWAP,                              //Swaps NAV 1 frequency with standby
        NAV1_STBY_SET,                                //Sets NAV 1 standby frequency (BCD Hz)
        NAV2_RADIO_SET,                               //Sets NAV 2 frequency (BCD Hz)
        NAV2_RADIO_SWAP,                              //Swaps NAV 2 frequency with standby
        NAV2_STBY_SET,                                //Sets NAV 2 standby frequency (BCD Hz)
        PANEL_LIGHTS_TOGGLE,                          //Toggle panel lights
        STROBES_TOGGLE,                               //Toggle strobe lights 
        TOGGLE_BEACON_LIGHTS,                         //Toggle beacon lights
        TOGGLE_CABIN_LIGHTS,                          //Toggle cockpit/cabin lights
        TOGGLE_LOGO_LIGHTS,                           //Toggle logo lights
        TOGGLE_NAV_LIGHTS,                            //Toggle navigation lights
        TOGGLE_RECOGNITION_LIGHTS,                    //Toggle recognition lights
        TOGGLE_TAXI_LIGHTS,                           //Toggle taxi lights
        TOGGLE_WING_LIGHTS,                           //Toggle wing lights
        XPNDR_SET,                                    //Sets transponder code (BCD)

    }


    // the enum name and the event name may not always match, this enables them to be mapped
    public static class EventFactory
    {
        private static Dictionary<EventTypes, string> _enumToNameDictionary = new Dictionary<EventTypes, string>();

        static EventFactory()
        {
            _enumToNameDictionary.Add(EventTypes.SIMSTART, "SIMSTART");
            _enumToNameDictionary.Add(EventTypes.SIMSTOP, "SIMSTOP");
            _enumToNameDictionary.Add(EventTypes.PAUSE, "PAUSE");

            _enumToNameDictionary.Add(EventTypes.ADF_COMPLETE_SET, "ADF_COMPLETE_SET");
            _enumToNameDictionary.Add(EventTypes.ADF2_COMPLETE_SET, "ADF2_COMPLETE_SET");
            _enumToNameDictionary.Add(EventTypes.AP_ALT_VAR_SET_ENGLISH, "AP_ALT_VAR_SET_ENGLISH");
            _enumToNameDictionary.Add(EventTypes.AP_NAV_SELECT_SET, "AP_NAV_SELECT_SET");
            _enumToNameDictionary.Add(EventTypes.AP_SPD_VAR_SET, "AP_SPD_VAR_SET");
            _enumToNameDictionary.Add(EventTypes.AP_VS_VAR_SET_ENGLISH, "AP_VS_VAR_SET_ENGLISH");
            _enumToNameDictionary.Add(EventTypes.BLEED_AIR_SOURCE_CONTROL_SET, "BLEED_AIR_SOURCE_CONTROL_SET");
            _enumToNameDictionary.Add(EventTypes.COM_RADIO_SET, "COM_RADIO_SET");
            _enumToNameDictionary.Add(EventTypes.COM_STBY_RADIO_SET, "COM_STBY_RADIO_SET");
            _enumToNameDictionary.Add(EventTypes.COM_STBY_RADIO_SWAP, "COM_STBY_RADIO_SWAP");
            _enumToNameDictionary.Add(EventTypes.COM1_TRANSMIT_SELECT, "COM1_TRANSMIT_SELECT");
            _enumToNameDictionary.Add(EventTypes.COM2_RADIO_SET, "COM2_RADIO_SET");
            _enumToNameDictionary.Add(EventTypes.COM2_RADIO_SWAP, "COM2_RADIO_SWAP");
            _enumToNameDictionary.Add(EventTypes.COM2_STBY_RADIO_SET, "COM2_STBY_RADIO_SET");
            _enumToNameDictionary.Add(EventTypes.COM2_TRANSMIT_SELECT, "COM2_TRANSMIT_SELECT");
            _enumToNameDictionary.Add(EventTypes.DME1_TOGGLE, "DME1_TOGGLE");
            _enumToNameDictionary.Add(EventTypes.DME2_TOGGLE, "DME2_TOGGLE");
            _enumToNameDictionary.Add(EventTypes.HEADING_BUG_SET, "HEADING_BUG_SET");
            _enumToNameDictionary.Add(EventTypes.NAV1_RADIO_SET, "NAV1_RADIO_SET");
            _enumToNameDictionary.Add(EventTypes.NAV1_RADIO_SWAP, "NAV1_RADIO_SWAP");
            _enumToNameDictionary.Add(EventTypes.NAV1_STBY_SET, "NAV1_STBY_SET");
            _enumToNameDictionary.Add(EventTypes.NAV2_RADIO_SET, "NAV2_RADIO_SET");
            _enumToNameDictionary.Add(EventTypes.NAV2_RADIO_SWAP, "NAV2_RADIO_SWAP");
            _enumToNameDictionary.Add(EventTypes.NAV2_STBY_SET, "NAV2_STBY_SET");
            _enumToNameDictionary.Add(EventTypes.PANEL_LIGHTS_TOGGLE, "PANEL_LIGHTS_TOGGLE");
            _enumToNameDictionary.Add(EventTypes.STROBES_TOGGLE, "STROBES_TOGGLE");
            _enumToNameDictionary.Add(EventTypes.TOGGLE_BEACON_LIGHTS, "TOGGLE_BEACON_LIGHTS");
            _enumToNameDictionary.Add(EventTypes.TOGGLE_CABIN_LIGHTS, "TOGGLE_CABIN_LIGHTS");
            _enumToNameDictionary.Add(EventTypes.TOGGLE_LOGO_LIGHTS, "TOGGLE_LOGO_LIGHTS");
            _enumToNameDictionary.Add(EventTypes.TOGGLE_NAV_LIGHTS, "TOGGLE_NAV_LIGHTS");
            _enumToNameDictionary.Add(EventTypes.TOGGLE_RECOGNITION_LIGHTS, "TOGGLE_RECOGNITION_LIGHTS");
            _enumToNameDictionary.Add(EventTypes.TOGGLE_TAXI_LIGHTS, "TOGGLE_TAXI_LIGHTS");
            _enumToNameDictionary.Add(EventTypes.TOGGLE_WING_LIGHTS, "TOGGLE_WING_LIGHTS");
            _enumToNameDictionary.Add(EventTypes.XPNDR_SET, "XPNDR_SET");

        }

        public static string GetEventName(EventTypes eventType)
        {
            return _enumToNameDictionary[eventType];
        }

    }
}
