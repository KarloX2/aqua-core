﻿// Copyright (c) Christof Senn. All rights reserved. See license.txt in the project root for license information.

namespace Aqua.Tests.Serialization
{
    using Newtonsoft.Json;
    using System.IO;
    using System.Runtime.Serialization;

    public static class SerializationHelper
    {
        static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

        public static T Serialize<T>(this T graph)
        {
            var json = JsonConvert.SerializeObject(graph, _serializerSettings);

            return JsonConvert.DeserializeObject<T>(json, _serializerSettings);
        }
    }
}
