using Polkadot.BinarySerializer;
using Polkadot.DataStructs;
using Polkadot.BinarySerializer.Converters;
using Polkadot.BinaryContracts.Nft;
using System.Numerics;

namespace Polkadot.BinaryContracts.Calls.System
{
    public class SetCodeCall : IExtrinsicCall
    {
        // Rust type Vec<u8>
        [Serialize(0)]
        [PrefixedArrayConverter]
        public byte[] Code { get; set; }



        public SetCodeCall() { }
        public SetCodeCall(byte[] @code)
        {
            this.Code = @code;
        }

    }
}