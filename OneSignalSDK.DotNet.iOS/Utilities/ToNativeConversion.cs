using System.Collections.Generic;
using Foundation;
using HomeKit;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Internal.Utilities;

namespace OneSignalSDK.DotNet.iOS.Utilities;

/// <summary>
/// Translation functions when translating from .NET SDK class types to their respective native SDK class types.
/// </summary>
public static class NativeConversion
{
    public static NSDictionary<NSString, NSObject> DictToNSDict(IDictionary<string, object> dict)
    {
        if (dict == null)
            return null;

        var keys = new NSString[dict.Count];
        var values = new NSObject[dict.Count];
        var index = 0;

        foreach(var entry in dict)
        {
            keys[index] = NSString.FromData(entry.Key, NSStringEncoding.UTF8);
            values[index] = ObjectToNSObject(entry.Value);
            index++;
        }

        var result = new NSDictionary<NSString, NSObject>(keys, values);

        return result;
    }

    public static NSDictionary<NSString, NSString> DictToNSDict(IDictionary<string, string> dict)
    {
        if (dict == null)
            return null;

        var keys = new NSString[dict.Count];
        var values = new NSString[dict.Count];
        var index = 0;
        foreach (var entry in dict)
        {
            keys[index] = NSString.FromData(entry.Key, NSStringEncoding.UTF8);
            values[index] = NSString.FromData(entry.Value, NSStringEncoding.UTF8);
            index++;
        }

        var result = new NSDictionary<NSString, NSString>(keys, values);

        return result;
    }

    public static NSObject ListToNSObject(IList<object> list)
    {
        if (list == null)
            return null;

        var result = new NSMutableArray<NSObject>();
        foreach (var item in list)
        {
            result.Add(ObjectToNSObject(item));
        }

        return result;
    }

    public static NSObject ObjectToNSObject(object obj)
    {
        if (obj == null)
            return NSNull.Null;

        if (obj is IDictionary<string, object> dictItem)
        {
            return DictToNSDict(dictItem);
        }
        else if (obj is IList<object> listItem)
        {
            return ListToNSObject(listItem);
        }
        else if (obj is String stringItem)
        {
            return NSString.FromData(stringItem, NSStringEncoding.UTF8);
        }
        else
        {
            return NSObject.FromObject(obj);
        }
    }
}
