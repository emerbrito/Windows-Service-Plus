using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace $safeprojectname$.Service
{
    class WinService 
    {

        public ILog Log { get; private set; }

        public WinService(ILog logger)
        {

            // IocModule.cs needs to be updated in case new paramteres are added to this constructor

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            Log = logger;

        }

        public bool Start(HostControl hostControl)
        {   
                     
            Log.Info($"{nameof(Service.WinService)} Start command received.");

            //TODO: Implement your service start routine.
            return true;

        }

        public bool Stop(HostControl hostControl)
        {

            Log.Trace($"{nameof(Service.WinService)} Stop command received.");

            //TODO: Implement your service stop routine.
            return true;

        }

        public bool Pause(HostControl hostControl)
        {

            Log.Trace($"{nameof(Service.WinService)} Pause command received.");

            //TODO: Implement your service start routine.
            return true;

        }

        public bool Continue(HostControl hostControl)
        {

            Log.Trace($"{nameof(Service.WinService)} Continue command received.");

            //TODO: Implement your service stop routine.
            return true;

        }

        public bool Shutdown(HostControl hostControl)
        {

            Log.Trace($"{nameof(Service.WinService)} Shutdown command received.");

            //TODO: Implement your service stop routine.
            return true;

        }

    }
}
