using System;
using Akka.Actor;
using Neo.Consensus;
using Neo.Ledger;
using Neo.Network.P2P;
using Neo.Persistence;
using Neo.Plugins;
using Neo.Wallets;

namespace Neo
{
    public class NeoSystem : IDisposable
    {
        public ActorSystem ActorSystem { get; } = ActorSystem.Create(nameof(NeoSystem),
            "akka { log-dead-letters = off }" +
            $"blockchain-mailbox {{ mailbox-type: \"{typeof(BlockchainMailbox).AssemblyQualifiedName}\" }}" +
            $"task-manager-mailbox {{ mailbox-type: \"{typeof(TaskManagerMailbox).AssemblyQualifiedName}\" }}" +
            $"remote-node-mailbox {{ mailbox-type: \"{typeof(RemoteNodeMailbox).AssemblyQualifiedName}\" }}" +
            $"protocol-handler-mailbox {{ mailbox-type: \"{typeof(ProtocolHandlerMailbox).AssemblyQualifiedName}\" }}" +
            $"consensus-service-mailbox {{ mailbox-type: \"{typeof(ConsensusServiceMailbox).AssemblyQualifiedName}\" }}");
        public IActorRef Blockchain { get; }
        public IActorRef LocalNode { get; }
        internal IActorRef TaskManager { get; }
        public IActorRef Consensus { get; private set; }

        private readonly Store store;
        private ChannelsConfig start_message;
        private bool suspend;

        public NeoSystem(Store store)
        {
            this.store = store;
            Plugin.LoadPlugins(this);
            Blockchain = ActorSystem.ActorOf(Ledger.Blockchain.Props(this, store));
            LocalNode = ActorSystem.ActorOf(Network.P2P.LocalNode.Props(this));
            TaskManager = ActorSystem.ActorOf(Network.P2P.TaskManager.Props(this));
            Plugin.NotifyPluginsLoadedAfterSystemConstructed();
        }

        public void Dispose()
        {
            EnsureStoped(LocalNode);
            // Dispose will call ActorSystem.Terminate()
            ActorSystem.Dispose();
            ActorSystem.WhenTerminated.Wait();
        }

        public void EnsureStoped(IActorRef actor)
        {
            Inbox inbox = Inbox.Create(ActorSystem);
            inbox.Watch(actor);
            ActorSystem.Stop(actor);
            inbox.Receive(TimeSpan.FromMinutes(5));
        }

        internal void ResumeNodeStartup()
        {
            suspend = false;
            if (start_message != null)
            {
                LocalNode.Tell(start_message);
                start_message = null;
            }
        }

        public void StartConsensus(Wallet wallet, Store consensus_store = null, bool ignoreRecoveryLogs = false)
        {
            Consensus = ActorSystem.ActorOf(ConsensusService.Props(LocalNode, TaskManager, consensus_store ?? store, wallet));
            Consensus.Tell(new ConsensusService.Start { IgnoreRecoveryLogs = ignoreRecoveryLogs }, Blockchain);
        }

        public void StartNode(ChannelsConfig config)
        {
            start_message = config;

            if (!suspend)
            {
                LocalNode.Tell(start_message);
                start_message = null;
            }
        }

        internal void SuspendNodeStartup()
        {
            suspend = true;
        }
    }
}
