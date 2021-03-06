﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

using Regulus.Framework;
using Regulus.Remoting;
using Regulus.Utility;

namespace Regulus.Project.Chat.Game
{
    public class Center : Regulus.Remoting.ICore
    {
        private readonly Room _Room;


        private readonly Regulus.Utility.Updater _Talkers;
        public Center()
        {
            _Talkers = new Updater();
            _Room = new Room();
        }
        void ICore.Launch(IProtocol protocol, ICommand command)
        {
            
        }

        void ICore.Shutdown()
        {
            _Talkers.Shutdown();
        }

        bool ICore.Update()
        {
            _Talkers.Working();
            return true;
        }

        void IBinderProvider.AssignBinder(ISoulBinder binder)
        {
            _Talkers.Add(new Talker(binder , _Room));
        }
    }
}
