﻿using System.Collections.Generic;
using Polkadot.BinarySerializer;
using Polkadot.BinarySerializer.Converters;
using Polkadot.DataStructs.Metadata.Interfaces;

namespace Polkadot.DataStructs.Metadata.BinaryContracts.V12
{
    public class RuntimeMetadataV12 : MetadataBase, IMetadata
    {
        /// Metadata of all the modules.
        [Serialize(0)]
        [PrefixedArrayConverter]
        public ModuleMetadataV12[] Modules { get; set; }
        
        /// Metadata of the extrinsic.
        [Serialize(1)]
        public ExtrinsicMetadataV12 Extrinsic { get; set; }

        public RuntimeMetadataV12()
        {
            Version = 12;
        }

        public override IReadOnlyList<IModuleMeta> GetModules()
        {
            return Modules;
        }

        public override string[] GetExtrinsicExtension()
        {
            return Extrinsic.SignedExtensions;
        }
    }
}