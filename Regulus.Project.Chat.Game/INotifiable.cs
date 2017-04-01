namespace Regulus.Project.Chat.Game
{
    internal interface INotifiable : Common.ITalker
    {
        void Enter(INotifiable other);

        void Leave(INotifiable other);
        
        
    }
}