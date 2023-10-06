using System;
using System.Security.Permissions;
using TwinCAT.Ads;



namespace TCADStut
{ 
    class Program
    { 
        public static void Main()
        {
            
           AdsClient myClient = new AdsClient();
           myClient.Connect(AmsNetId.Local, 851);
           System.Console.WriteLine("ADS CLient has been initialised");

           var bTeleRun =myClient.CreateVariableHandle("test_4Untitled1.MAIN.bTeleRun");
           //read initial state

           var resp = myClient.ReadAny(bTeleRun, typeof(bool));
           System.Console.WriteLine(resp);
            //write final state and print it out
           myClient.WriteAny(bTeleRun, false);

           resp = myClient.ReadAny(bTeleRun, typeof(bool));
           System.Console.WriteLine(resp);
           

             /*   
            AdsClient myClient = new AdsClient();
            myClient.Connect(AmsNetId.Local, 851);
            System.Console.WriteLine("ADS Client has been initialized");

            var bTeleRun = myClient.CreateVariableHandle("test1.bTeleRun");
            
            if (bTeleRun != 0)
                {
                    // Read initial state
                    var resp = myClient.ReadAny(bTeleRun, typeof(bool));
                    System.Console.WriteLine(resp);

                    // Write final state and print it out
                    myClient.WriteAny(bTeleRun, false);

                    resp = myClient.ReadAny(bTeleRun, typeof(bool));
                    System.Console.WriteLine(resp);
                }
                else
                {
                    System.Console.WriteLine("Failed to create variable handle for 'test1.bTeleRun'");
                }
        }
        catch (AdsErrorException ex)
        {
            System.Console.WriteLine($"ADS Error: {ex.Message} (AdsErrorCode: {ex.ErrorCode}, 0x{ex.ErrorCode:X})");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        //By adding proper error handling, you can better diagnose the issue when an exception occ
        */

        }
    }
}
