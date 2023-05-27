using FFXIVBot.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace FFXIVBot
{
    public static class Helper
    {
        [DllImport("user32.dll")] private static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        [DllImport("user32.dll")] private static extern short VkKeyScan(char ch);

        [DllImport("user32.dll")] public static extern int SetForegroundWindow(int hwnd);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto,SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        public static int NumpadZero = 0x60;
        public static int NumpadTwo = 0x62;
        public static int NumpadFive = 0x65;
        public static int NumpadEight = 0x68;

        public static char LeftTurn => Settings.Default.turnLeft;
        public static char RightTurn => Settings.Default.turnRight;
        public static char MoveLeft => Settings.Default.moveLeft;
        public static char MoveRight => Settings.Default.moveRight;
        public static char Forward => Settings.Default.forward;
        public static char Backward => Settings.Default.back;
        public static char Jump => ' ';
        public static char Craft => Settings.Default.craftMacro;
        public static char Gather => Settings.Default.gatherMacro;

        public static SettingsBackup SettingsObject => BuildObject();

        public static Process Process { get; set; }

        public static void PreventSleep()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
        }

        public static void AllowSleep()
        {
            // probably not necessary but just to be safe
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
        }
        
        public static void PressKey(int key)
        {
            PostMessage(Process.MainWindowHandle, WM_KEYDOWN, key, 0);
        }

        public static void LiftKey(int key)
        {
            PostMessage(Process.MainWindowHandle, WM_KEYUP, key, 3);
        }
        
        public static void PressKeyForDuration(int key, int duration = 35)
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
        
        [StructLayout(LayoutKind.Explicit)]
        struct CharHelper
        {
            [FieldOffset(0)]public short Value;
            [FieldOffset(0)]public byte Low;
            [FieldOffset(1)]public byte High;
        }

        private static SettingsBackup BuildObject()
        {
            return new SettingsBackup
            {
                Backward = Backward,
                Forward = Forward,
                MoveLeft = MoveLeft,
                MoveRight = MoveRight,
                RightTurn = RightTurn,
                LeftTurn = LeftTurn,
                Craft = Craft,
                Gather = Gather,
                Version = Bot.Version
            };
        }
    }
    
    [FlagsAttribute]
    public enum EXECUTION_STATE :uint
    {
        ES_AWAYMODE_REQUIRED = 0x00000040,
        ES_CONTINUOUS = 0x80000000,
        ES_DISPLAY_REQUIRED = 0x00000002,
        ES_SYSTEM_REQUIRED = 0x00000001
        // Legacy flag, should not be used.
        // ES_USER_PRESENT = 0x00000004
    }
}