namespace DarkTech.Engine.Scripting
{
    internal sealed class CommandBuffer
    {
        private CommandBufferEntry first;
        private CommandBufferEntry last;

        public CommandBuffer()
        {
            this.first = null;
            this.last = null;
        }

        public void Append(Command command, ArgList args)
        {
            if (first == null)
            {
                CommandBufferEntry entry = new CommandBufferEntry(command, args);

                first = entry;
                last = entry;
            }
            else
            {
                CommandBufferEntry entry = new CommandBufferEntry(command, args);

                last.Next = entry;
                last = entry;
            }
        }

        public void Insert(Command command, ArgList args)
        {
            if (first == null)
            {
                CommandBufferEntry entry = new CommandBufferEntry(command, args);

                first = entry;
                last = entry;
            }
            else
            {
                CommandBufferEntry entry = new CommandBufferEntry(command, args, first);

                first = entry;
            }
        }

        public void Process()
        {
            for (CommandBufferEntry walker = first; walker != null; walker = walker.Next)
            {
                walker.Command.Execute(walker.Args);
            }

            first = null;
            last = null;
        }

        private sealed class CommandBufferEntry
        {
            public Command Command { get; private set; }
            public ArgList Args { get; private set; }
            public CommandBufferEntry Next { get; set; }

            public CommandBufferEntry(Command command, ArgList args)
            {
                this.Command = command;
                this.Args = args;
                this.Next = null;
            }

            public CommandBufferEntry(Command command, ArgList args, CommandBufferEntry next)
            {
                this.Command = command;
                this.Args = args;
                this.Next = next;
            }
        }
    }
}
