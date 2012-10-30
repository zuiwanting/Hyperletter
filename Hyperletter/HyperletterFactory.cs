﻿using System.Net.Sockets;
using System.Threading;
using Hyperletter.Batch;
using Hyperletter.Channel;
using Hyperletter.IoC;

namespace Hyperletter {
    internal class HyperletterFactory {
        private readonly Container _container;

        public HyperletterFactory(Container container) {
            _container = container;
        }

        public LetterTransmitter CreateLetterTransmitter(Socket socket, CancellationTokenSource cancellationTokenSource) {
            return _container.Resolve<LetterTransmitter>(socket, cancellationTokenSource);
        }

        public LetterReceiver CreateLetterReceiver(Socket socket, CancellationTokenSource cancellationTokenSource) {
            return _container.Resolve<LetterReceiver>(socket, cancellationTokenSource);
        }

        public LetterDispatcher CreateLetterDispatcher() {
            return _container.Resolve<LetterDispatcher>();
        }

        public SocketListener CreateSocketListener(Binding binding) {
            return _container.Resolve<SocketListener>(binding);
        }

        public OutboundChannel CreateOutboundChannel(Binding binding) {
            return _container.Resolve<OutboundChannel>(binding);
        }

        public BatchChannel CreateBatchChannel(IChannel channel) {
            return _container.Resolve<BatchChannel>(channel);
        }

        public InboundChannel CreateInboundChannel(TcpClient tcpClient, Binding binding) {
            return _container.Resolve<InboundChannel>(tcpClient, binding);
        }
    }
}
