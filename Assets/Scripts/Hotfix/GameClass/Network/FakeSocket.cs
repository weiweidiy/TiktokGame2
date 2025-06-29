using JFramework;
using JFramework.Extern;
using JFramework.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tiktok
{
    public class FakeSocket : IJSocket
    {
        public bool IsOpen => true;

        public event Action<IJSocket> onOpen;
        public event Action<IJSocket, SocketStatusCodes, string> onClosed;
        public event Action<IJSocket, string> onError;
        public event Action<IJSocket, byte[]> onBinary;

        FakeServer fakeServer;

        public FakeSocket(IJConfigManager jConfigManager)
        {
            var litJson = new LitJsonSerializer();
            var resolve = new JNetMessageJsonTypeResolver(litJson); //to do:×¢²áÏûÏ¢
            resolve.RegisterMessageType(1, typeof(C2S_Login));
            var strate = new JNetMessageJsonSerializerStrate(litJson);

            fakeServer = new FakeServer(new JNetworkMessageProcessStrate(strate,resolve,null,null), jConfigManager);
        }

        public void Close()
        {
            //throw new NotImplementedException();
        }

        public void Init(string url)
        {
            //throw new NotImplementedException();
        }

        public void Open()
        {
            //throw new NotImplementedException();
            onOpen?.Invoke(this);
        }

        public void Send(byte[] data)
        {
            //throw new NotImplementedException();
            var response = fakeServer.OnRevieveData(data);

            onBinary?.Invoke(this, response);

        }
    }
}

