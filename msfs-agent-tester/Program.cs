//=================================================================================================================
// PROJECT: MSFS Agent
// PURPOSE: This file/project is used to do simple tests of the main MSFS Agent library
// AUTHOR: James Clark
// Licensed under the MS-PL license. See LICENSE.md file in the project root for full license information.
//================================================================================================================= 


using System;
using MSFS;

namespace msfs.agent.tester
{
    class Program
    {
        private static Agent agent;

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            agent = new Agent();

            try
            {
                //setup the agent
                agent.Connect();
                agent.AddDataDefinitions();
                agent.EnableMessagePolling();

                // trigger an event with data
                agent.TriggerEvent(EventTypes.NAV1_RADIO_SET, "174.1");

                // trigger an event without data
                agent.TriggerEvent(EventTypes.STROBES_TOGGLE);

                // the following will keep requesting updated data from the sim with each keypress
                // note: the results of the request is output to the to Output window (not the console)
                do
                {
                    Console.WriteLine("Press any key to continue or ESC to quit.");
                    cki = Console.ReadKey(true);
                    
                    // request sim data
                    agent.RequestData(RequestTypes.PlaneState, DataDefinitions.PlaneState);
                    
                } while (cki.Key != ConsoleKey.Escape);

                agent.Disconnect();
           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }

    }
}
