using System;

namespace Hyperletter.EventArgs.Letter {
    internal class ReceivedEventArgs : AbstractChannelEventArgs, IReceivedEventArgs {
        public Guid RemoteNodeId { get; internal set; }
        public AckState AckState { get; internal set; }
    }
}