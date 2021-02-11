using Polkadot.BinarySerializer;
using Polkadot.DataStructs;
using Polkadot.BinarySerializer.Converters;
using Polkadot.BinaryContracts.Nft;
using System.Numerics;

namespace Polkadot.BinaryContracts.Calls.Nft
{
    public class RemoveCollectionSponsorCall : IExtrinsicCall
    {
        // Rust type CollectionId
        [Serialize(0)]
        public uint CollectionId { get; set; }



        public RemoveCollectionSponsorCall() { }
        public RemoveCollectionSponsorCall(uint @collectionId)
        {
            this.CollectionId = @collectionId;
        }

    }
}