using System;
using System.Collections.Generic;

namespace Regulus.Project.Chat.Game
{
    internal class Room
    {
        private readonly List<INotifiable> _Handlers;

        public Room()
        {
            _Handlers = new List<INotifiable>();
        }

        public void Join(INotifiable notifiable)
        {
            
            
            _Handlers.Add(notifiable);
            _BroadcastJoin(notifiable);

            
        }

        private void _BroadcastJoin(INotifiable notifiable)
        {
            foreach (var handler in _Handlers)
            {
                handler.Enter(notifiable);
            }
        }

        public void Leave(INotifiable notifiable)
        {

            _BroadcastLeave(notifiable);
            _Handlers.Remove(notifiable);
        }

        private void _BroadcastLeave(INotifiable notifiable)
        {
            foreach (var handler in _Handlers)
            {
                handler.Leave(notifiable);
            }
        }

    }
}