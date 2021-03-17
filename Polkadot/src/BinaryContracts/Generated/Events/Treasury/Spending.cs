using Polkadot.BinarySerializer;
using Polkadot.DataStructs;
using Polkadot.BinarySerializer.Converters;
using Polkadot.BinaryContracts.Nft;
using Polkadot.BinaryContracts.Common;
using System.Numerics;

namespace Polkadot.BinaryContracts.Events.Treasury
{
    public partial class Spending : IEvent
    {
        // Rust type Balance
        [Serialize(0)]
        public Balance EventArgument0 { get; set; }



        public Spending() { }
        public Spending(Balance @eventArgument0)
        {
            this.EventArgument0 = @eventArgument0;
        }

    }
}