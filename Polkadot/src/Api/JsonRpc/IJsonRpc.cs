﻿namespace Polkadot.Api
{
    using System;
    using Newtonsoft.Json.Linq;

    public interface IJsonRpc : IDisposable
    {
        /// <summary>
        /// Connects to WebSocket
        /// </summary>
        /// <param name="connectionParams">Connection parameters</param>
        /// <returns> operation result </returns>
        int Connect(ConnectionParameters connectionParams);

        /// <summary>
        /// Disconnects from WebSocket
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Synchronously send request and wait for result
        /// </summary>
        /// <param name="jsonMap"> jsonMap JSON object with command parameters </param>
        /// <param name="timeout"> timeout_s - timeout of response in seconds </param>
        /// <returns> JSON object that contains parsed node response</returns>
        (JObject Result, JObject Error) Request(JObject jsonMap, int timeout = Consts.RESPONSE_TIMEOUT_S);

        /// <summary>
        /// Send a command to subscribe to websocket updates, e.g.state_subscribeStorage
        /// </summary>
        /// <param name="jsonMap"> jsonMap JSON object with command parameters </param>
        /// <param name="observer"> observer The observer that will be notified of updates </param>
        /// <returns> subscription ID </returns>
        string SubscribeWs(JObject jsonMap, IWebSocketMessageObserver observer);

        /// <summary>
        /// Send a command to unsubscribe from websocket updates, e.g.state_unsubscribeStorage
        /// </summary>
        /// <param name="subscriptionId"> subscriptionId Id of subscription to unsubscribe from </param>
        /// <param name="method"></param>
        /// <returns> command execution result </returns>
        string UnsubscribeWs(string subscriptionId, string method);
    }
}