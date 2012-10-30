using System.Net.Sockets;
using Hyperletter.Letter;

namespace Hyperletter.Channel {
    internal class InboundChannel : AbstractChannel {
        public InboundChannel(SocketOptions options, TcpClient tcpClient, Binding binding, LetterDeserializer letterDeserializer, HyperletterFactory factory)
            : base(options, binding, letterDeserializer, factory) {
            TcpClient = tcpClient;
        }

        public override Direction Direction {
            get { return Direction.Inbound; }
        }

        public override void Initialize() {
            Connected();
        }
    }
}