using System;

using Regulus.Project.Chat.Common;
using Regulus.Remoting;
using Regulus.Utility;

namespace Regulus.Project.Chat.Game
{
    internal class TalkerChatStage : IStage , Common.IPlayer , INotifiable  , Common.ITalker
    {
        private readonly ISoulBinder _SoulBinder;   

        private readonly Room _Room;

        private readonly string _Name;

        public Action DoneEvent;

        public TalkerChatStage(ISoulBinder soul_binder, Room room , string name)
        {
            _SoulBinder = soul_binder;
            _Room = room;
            _Name = name;
        }

        void IStage.Enter()
        {            
            _SoulBinder.Bind<IPlayer>(this);
            _Room.Join(this);
        }

        void IStage.Leave()
        {
            _Room.Leave(this);
            _SoulBinder.Unbind<IPlayer>(this);
        }

        void IStage.Update()
        {
            
        }


        Regulus.Remoting.Value<bool> IPlayer.Talk(string message)
        {
            _MessageEvent(message);
            return true;
        }

        public void Exit()
        {
            DoneEvent();
        }

        void INotifiable.Enter(INotifiable other)
        {
            _SoulBinder.Bind<ITalker>(other);
        }

        void INotifiable.Leave(INotifiable other)
        {
            _SoulBinder.Unbind<ITalker>(other);
        }

        

        private event Action<string> _MessageEvent;
        event Action<string> ITalker.MessageEvent
        {
            add { _MessageEvent += value; }
            remove { _MessageEvent -= value; }
        }

        
        string ITalker.Name
        {
            get { return _Name; }
        }
    }
}