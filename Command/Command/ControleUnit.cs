using System.Collections.Generic;

namespace Command
{
    class ControleUnit
    {
        private List<AbstractCommand> commands = new List<AbstractCommand>();
        private int current = 0;
        public void StoreCommand(AbstractCommand com)
        {
            commands.Add(com);
        }
        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }
        public void Undo(int level)
        {
            for (int i = 0; i < level; i++)
                if (current > 0)
                    commands[--current].UnExecute();
        }
        public void Redo(int level)
        {
            for (int i = 0; i < level; i++)
                if (current < commands.Count - 1)
                    commands[current++].Execute();
        }
    }
}
