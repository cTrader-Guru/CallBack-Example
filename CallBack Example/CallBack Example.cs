/*  CTRADER GURU

    Homepage    : https://ctrader.guru/
    Telegram    : https://t.me/ctraderguru
    Twitter     : https://twitter.com/cTraderGURU/
    Facebook    : https://www.facebook.com/ctrader.guru/
    YouTube     : https://www.youtube.com/cTraderGuru
    GitHub      : https://github.com/ctrader-guru
    LinkedIn    : https://www.linkedin.com/company/ctrader-guru/
    Discord     : https://discord.gg/yE5XE3z5Nz

*/
using System;
using cAlgo.API;
using cTraderGuru.CallbackExample;

namespace cAlgo.Robots
{
    [Robot(TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class CallBackExample : Robot
    {
        
        protected override void OnStart()
        {
            


        }

        protected override void OnTick()
        {

            HelloWorld.Show(Print, Stop) ;

        }

        protected override void OnStop()
        {



        }

    }

}

namespace cTraderGuru.CallbackExample {

    public static class HelloWorld {

        public static void Show(Action<string> MyPrint, Action MyStop) {

            MyPrint( "Hello World cTrader Guru!" );
            MyStop();
        
        }
    
    }

}
