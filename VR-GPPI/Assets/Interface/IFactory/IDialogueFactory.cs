using System.Collections.Generic;

public interface IDialogueFactory : IFactory<Dialogue, int>
{
    public abstract int CurrentIndex { get; }

    public abstract List<Dialogue> DialogueList { get; }
}