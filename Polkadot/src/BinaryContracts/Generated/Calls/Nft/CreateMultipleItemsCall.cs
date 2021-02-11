using Polkadot.BinarySerializer;
using Polkadot.DataStructs;
using Polkadot.BinarySerializer.Converters;
using Polkadot.BinaryContracts.Nft;
using System.Numerics;

namespace Polkadot.BinaryContracts.Calls.Nft
{
    public class CreateMultipleItemsCall : IExtrinsicCall
    {
        // Rust type CollectionId
        [Serialize(0)]
        public uint CollectionId { get; set; }


        // Rust type T::AccountId
        [Serialize(1)]
        public PublicKey Owner { get; set; }


        // Rust type Vec<CreateItemData>
        [Serialize(2)]
        [PrefixedArrayConverter]
        public Polkadot.BinaryContracts.Nft.CreateItem.CreateItemData[] ItemsData { get; set; }



        public CreateMultipleItemsCall() { }
        public CreateMultipleItemsCall(uint @collectionId, PublicKey @owner, Polkadot.BinaryContracts.Nft.CreateItem.CreateItemData[] @itemsData)
        {
            this.CollectionId = @collectionId;
            this.Owner = @owner;
            this.ItemsData = @itemsData;
        }

    }
}