using System;
using System.Collections.Generic;
using System.Configuration;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace FFXIVBot
{
    public static class Helper
    {
        [DllImport("user32.dll")] private static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        [DllImport("user32.dll")] private static extern short VkKeyScan(char ch);
        
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        public static char LeftTurn => GetConfigValue("turnLeft");
        
        public static char RightTurn => GetConfigValue("turnRight");
        public static char MoveLeft => GetConfigValue("moveLeft");
        public static char MoveRight => GetConfigValue("moveRight");
        public static char Forward => GetConfigValue("forward");
        public static char Backward => GetConfigValue("back");
        public static char Jump => GetConfigValue("jump");
        
        public static Process Process { get; set; }
        
        public static void PressKey(int key)
        {
            PostMessage(Process.MainWindowHandle, WM_KEYDOWN, key, 0);
        }

        public static void LiftKey(int key)
        {
            PostMessage(Process.MainWindowHandle, WM_KEYUP, key, 3);
        }
        
        public static void PressKeyForDuration(int duration, int key)
        {
            PressKey(key);
            Thread.Sleep(duration);
            LiftKey(key);
        }

        public static char GetRandomKey()
        {
            List<char> keys = new List<char>()
            {
                Jump,
                Backward,
                Forward,
                MoveLeft,
                MoveRight,
                RightTurn,
                LeftTurn
            };

            keys = keys.Where(k => k != char.MaxValue).ToList();
            
            return keys[new Random().Next(keys.Count)];
        }

        public static int GetKeyCode(char key)
        {
            var CharHelper = new CharHelper()
            {
                Value = VkKeyScan(key)
            };

            return CharHelper.Low;
        }
        
        private static char GetConfigValue(string appSetting)
        {
            var value = ConfigurationManager.AppSettings[appSetting];
            if (string.IsNullOrEmpty(value))
            {
                return Char.MaxValue;
            }

            return value[0];
        }
        
        [StructLayout(LayoutKind.Explicit)]
        struct CharHelper
        {
            [FieldOffset(0)]public short Value;
            [FieldOffset(0)]public byte Low;
            [FieldOffset(1)]public byte High;
        }
    }
}