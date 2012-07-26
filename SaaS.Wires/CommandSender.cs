using Lokad.Cqrs;

namespace SaaS.Wires
{
    public sealed class CommandSender : ICommandSender
    {
        readonly SimpleMessageSender _sender;

        public CommandSender(SimpleMessageSender sender)
        {
            _sender = sender;
        }


        public void SendCommandsAsBatch(ICommand[] commands)
        {
            _sender.SendBatch(commands);
        }
    }
}