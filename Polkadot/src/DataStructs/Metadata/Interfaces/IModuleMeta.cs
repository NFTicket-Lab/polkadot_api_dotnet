﻿using System.Collections.Generic;

namespace Polkadot.DataStructs.Metadata.Interfaces
{
    public interface IModuleMeta
    {
        IReadOnlyList<IConstantMeta> GetConstants();
        string GetName();
        IReadOnlyList<ICallMeta> GetCalls();
        IReadOnlyList<IEventMeta> GetEvents();
        IReadOnlyList<IStorage> GetStorages();
        IReadOnlyList<IErrorMeta> GetErrors();

        IConstantMeta GetConstant(string constantName);
        int GetStorageIndex(string storageName);
        IStorage GetStorage(string storageName);
        int GetCallIndex(string callName);
    }
}