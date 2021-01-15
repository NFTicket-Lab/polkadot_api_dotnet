﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Polkadot.Api;
using Polkadot.BinaryContracts.Events;
using Polkadot.BinarySerializer.Extensions;
using Polkadot.Utils;
using Xunit;

namespace PolkaTest
{
    public class DeserializationTest
    {
        [Fact]
        public async Task EventSubscriptionDoesntFail()
        {
            using var app = PolkaApi.GetApplication();
            app.Connect(Constants.LocalNodeUri);

            var storageKey = app.StorageApi.GetKeys("System", "Events");
            var deserializedCount = 0;
            var tcs = new TaskCompletionSource<EventList>();
            app.StorageApi.SubscribeStorage(storageKey, s =>
            {
                try
                {
                    var list = app.Serializer.DeserializeAssertReadAll<EventList>(s.HexToByteArray());
                    tcs.SetResult(list);
                    deserializedCount++;
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }

                deserializedCount++;
            });

            await tcs.Task;
            
            Assert.True(deserializedCount > 0);
        }
    }
}