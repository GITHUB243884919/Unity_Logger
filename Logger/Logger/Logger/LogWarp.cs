using System;
using System.Collections.Generic;
using System.Text;

namespace HillUFrame.Logger
{
    public class LogWarp
    {
        [System.Diagnostics.Conditional("LOG")]
        public static void Log(object o)
        {
            UnityEngine.Debug.Log("[Debug] " + o);
        }

        [System.Diagnostics.Conditional("LOG")]
        public static void LogFormat(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat("[Debug] " + format, args);
        }

        [System.Diagnostics.Conditional("LOG")]
        public static void LogError(object o)
        {
            UnityEngine.Debug.LogError("[Debug] " + o);
        }

        [System.Diagnostics.Conditional("LOG")]
        public static void LogErrorFormat(string format, params object[] args)
        {
            UnityEngine.Debug.LogErrorFormat("[Debug] " + format, args);
        }

        [System.Diagnostics.Conditional("LOG")]
        public static void LogWarning(object o)
        {
            UnityEngine.Debug.LogWarning("[Debug] " + o);
        }

        [System.Diagnostics.Conditional("LOG")]
        public static void LogWarningFormat(string format, params object[] args)
        {
            UnityEngine.Debug.LogWarningFormat("[Debug] " + format, args);
        }
    }
}
