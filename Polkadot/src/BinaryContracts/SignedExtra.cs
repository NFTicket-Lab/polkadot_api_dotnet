﻿using System.Numerics;
using Polkadot.BinaryContracts.Extrinsic;
using Polkadot.BinarySerializer;
using Polkadot.BinarySerializer.Converters;
using Polkadot.Utils;

namespace Polkadot.BinaryContracts
{
    public class SignedExtra : IExtrinsicExtra
    {
        [Serialize(0)]
        public EraDto Era { get; set; }
        
        [Serialize(1)]
        [CompactBigIntegerConverter]
        public BigInteger Nonce { get; set; }
        
        [Serialize(2)]
        [CompactBigIntegerConverter]
        public BigInteger ChargeTransactionPayment { get; set; }

        public SignedExtra()
        {
        }

        public SignedExtra(EraDto era, BigInteger nonce, BigInteger chargeTransactionPayment)
        {
            Era = era;
            Nonce = nonce;
            ChargeTransactionPayment = chargeTransactionPayment;
        }

        public EraDto GetEraIfAny()
        {
            return Era;
        }
    }
}