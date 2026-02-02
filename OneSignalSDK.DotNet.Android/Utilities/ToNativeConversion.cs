using System;
using OneSignalSDK.DotNet.Core.Debug;

namespace OneSignalSDK.DotNet.Android.Utilities;

/// <summary>
/// Translation functions when translating from .NET SDK class types to their respective native SDK class types.
/// </summary>
public static class ToNativeConversion
{
    public static Com.OneSignal.Android.Debug.LogLevel ToLogLevel(LogLevel logLevel)
    {
        switch (logLevel)
        {
            case LogLevel.NONE:
                return Com.OneSignal.Android.Debug.LogLevel.None!;
            case LogLevel.FATAL:
                return Com.OneSignal.Android.Debug.LogLevel.Fatal!;
            case LogLevel.ERROR:
                return Com.OneSignal.Android.Debug.LogLevel.Error!;
            case LogLevel.WARN:
                return Com.OneSignal.Android.Debug.LogLevel.Warn!;
            case LogLevel.INFO:
                return Com.OneSignal.Android.Debug.LogLevel.Info!;
            case LogLevel.DEBUG:
                return Com.OneSignal.Android.Debug.LogLevel.Debug!;
            case LogLevel.VERBOSE:
                return Com.OneSignal.Android.Debug.LogLevel.Verbose!;
            default:
                return Com.OneSignal.Android.Debug.LogLevel.None!;
        }
    }

    public static Java.Lang.Object? ToJavaObject(object? value)
    {
        if (value == null)
            return null;

        if (value is string strValue)
        {
            return new Java.Lang.String(strValue);
        }
        else if (value is bool boolValue)
        {
            return new Java.Lang.Boolean(boolValue);
        }
        else if (value is int intValue)
        {
            return new Java.Lang.Integer(intValue);
        }
        else if (value is long longValue)
        {
            return new Java.Lang.Long(longValue);
        }
        else if (value is float floatValue)
        {
            return new Java.Lang.Float(floatValue);
        }
        else if (value is double doubleValue)
        {
            return new Java.Lang.Double(doubleValue);
        }
        else if (value is short shortValue)
        {
            return new Java.Lang.Short(shortValue);
        }
        else if (value is char charValue)
        {
            return new Java.Lang.Character(charValue);
        }
        else if (value is sbyte byteValue)
        {
            return new Java.Lang.Byte(byteValue);
        }
        else if (value is uint uintValue)
        {
            return new Java.Lang.Integer((int)uintValue);
        }
        else if (value is ulong ulongValue)
        {
            return new Java.Lang.Long((long)ulongValue);
        }
        else if (value is IDictionary<string, object> dictValue)
        {
            return DictToJavaHashMap(dictValue);
        }
        else if (value is System.Collections.IList listValue)
        {
            return ListToJavaList(listValue);
        }

        return null;
    }

    public static IDictionary<string, Java.Lang.Object>? DictToJavaMap(IDictionary<string, object>? dict)
    {
        if (dict == null)
            return null;

        var javaMap = new Dictionary<string, Java.Lang.Object>();
        foreach (var kvp in dict)
        {
            var javaValue = ToJavaObject(kvp.Value);
            if (javaValue != null)
                javaMap[kvp.Key] = javaValue;
        }
        return javaMap;
    }

    private static Java.Util.HashMap? DictToJavaHashMap(IDictionary<string, object>? dict)
    {
        if (dict == null)
            return null;

        var javaMap = new Java.Util.HashMap();
        foreach (var kvp in dict)
        {
            javaMap.Put(kvp.Key, ToJavaObject(kvp.Value));
        }
        return javaMap;
    }

    public static Java.Util.ArrayList? ListToJavaList(System.Collections.IList? list)
    {
        if (list == null)
            return null;

        var javaList = new Java.Util.ArrayList();
        foreach (var item in list)
        {
            javaList.Add(ToJavaObject(item));
        }
        return javaList;
    }
}
