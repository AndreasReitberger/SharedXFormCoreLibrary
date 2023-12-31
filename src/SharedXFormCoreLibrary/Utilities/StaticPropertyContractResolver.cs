﻿using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace AndreasReitberger.Shared.XForm.Core.Utilities
{
    // Source: https://stackoverflow.com/questions/30193871/how-to-serialize-static-properties-in-json-net-without-adding-jsonproperty-att
    public class StaticPropertyContractResolver : DefaultContractResolver
    {
        protected override List<MemberInfo> GetSerializableMembers(Type objectType)
        {
            var baseMembers = base.GetSerializableMembers(objectType);

            PropertyInfo[] staticMembers =
                objectType.GetProperties(BindingFlags.Static | BindingFlags.Public);

            baseMembers.AddRange(staticMembers);

            return baseMembers;
        }
    }
}
