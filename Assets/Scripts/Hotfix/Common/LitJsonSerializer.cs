using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using JFramework;
using System;
using LitJson;

namespace JFramework.Extern
{

    public class LitJsonSerializer : IJsonSerializer
    {
        public string ToJson(object obj)
        {
            return JsonMapper.ToJson(obj);
        }

        public T ToObject<T>(string str)
        {
            return JsonMapper.ToObject<T>(str);
        }

        public object ToObject(string json, Type type)
        {
            return JsonMapper.ToObject(json, type);
        }
    }
}

