﻿namespace MattsTwitchBot.Core.CommandQuery
{
    public interface ICommander
    {
        void Execute(ICommand command);
        T Query<T>(IQuery query);
    }
}