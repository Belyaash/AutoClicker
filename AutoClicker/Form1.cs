using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AutoClicker.Annotations;

namespace AutoClicker;

public partial class Form1 : Form, INotifyPropertyChanged
{
    private bool _isStart = false;
    private int _period = 10000;

    public int Period
    {
        get => _period;
        set
        {
            _period = value switch
            {
                < 100 => 100,
                _ => value
            };
            OnPropertyChanged(nameof(Period));
        }
    }


    private int _x = 0;
    public int X
    {
        get => _x;
        set
        {
            _x = value;
            OnPropertyChanged(nameof(X));
        }
    }

    private int _y = 0;
    public int Y
    {
        get => _y;
        set
        {
            _y = value;
            OnPropertyChanged(nameof(Y));
        }
    }

    #region MouseHooks

    [DllImport("user32.dll")]
    static extern bool GetCursorPos(out Point pt);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

    private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
    private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
    private const int MOUSEEVENTF_LEFTUP = 0x0004;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
    private const int MOUSEEVENTF_RIGHTUP = 0x0010;
    private const int MOUSEEVENTF_MOVE = 0x0001;

    #endregion

    #region KeyBoardHooks

    private const int WH_KEYBOARD_LL = 13;
    private LowLevelKeyboardProcDelegate m_callback;
    private IntPtr m_hHook;

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod,
        int dwThreadId);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("Kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0)
        {
            var khs = (KeyboardHookStruct)
                Marshal.PtrToStructure(lParam,
                    typeof(KeyboardHookStruct));
            if (Convert.ToInt32("" + wParam) == 256)
            {
                if ((int)khs.VirtualKeyCode == 123) //F12
                {
                    StopButton.PerformClick();
                    WindowState = FormWindowState.Normal;
                }

                if ((int)khs.VirtualKeyCode == 113) //F2
                {
                    StartButton.PerformClick();
                    WindowState = FormWindowState.Minimized;
                }

                if ((int)khs.VirtualKeyCode == 114) //F3
                {
                    SetCursorPosition.PerformClick();
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        return CallNextHookEx(m_hHook, nCode, wParam, lParam);
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct KeyboardHookStruct
    {
        public readonly int VirtualKeyCode;
        public readonly int ScanCode;
        public readonly int Flags;
        public readonly int Time;
        public readonly IntPtr ExtraInfo;
    }

    private delegate IntPtr LowLevelKeyboardProcDelegate(
        int nCode, IntPtr wParam, IntPtr lParam);

    public void SetHook()
    {
        m_callback = LowLevelKeyboardHookProc;
        m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
            m_callback,
            GetModuleHandle(IntPtr.Zero), 0);
    }
    public void Unhook()
    {
        UnhookWindowsHookEx(m_hHook);
    }


    #endregion


    public Form1()
    {
        InitializeComponent();
        XPosition.DataBindings.Add("Text", this, nameof(X));
        YPosition.DataBindings.Add("Text", this, nameof(Y));
        Interval.DataBindings.Add("Text", this, nameof(Period),
            true, DataSourceUpdateMode.OnPropertyChanged);
        SetHook();
    }

    private void Interval_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)));
    }

    private void Interval_KeyUp(object sender, KeyEventArgs e)
    {
        OnPropertyChanged(nameof(Period));
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        _isStart = false;
    }

    private void SetCursorPosition_Click(object sender, EventArgs e)
    {
        GetCursorPos(out Point pt);
        X = pt.X;
        Y = pt.Y;
    }

    private async void StartButton_Click(object sender, EventArgs e)
    {
        _isStart = true;
        Size res = Screen.PrimaryScreen.Bounds.Size;
        int x = 65535 / res.Width * X;
        int y = 65535 / res.Height * Y;

        while (_isStart)
        {
            int clicks = OneButton.Checked ? 1 : 2;
            uint mouseClickDownType;
            uint mouseClickUpType;

            if (LeftButton.Checked)
            {
                mouseClickDownType = MOUSEEVENTF_LEFTDOWN;
                mouseClickUpType = MOUSEEVENTF_LEFTUP;
            }
            else
            {
                mouseClickDownType = MOUSEEVENTF_RIGHTDOWN;
                mouseClickUpType = MOUSEEVENTF_RIGHTUP;
            }

            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE,
                x, y, 0, 0);

            for (int i = 0; i < clicks; i++)
            {
                mouse_event(MOUSEEVENTF_ABSOLUTE | mouseClickDownType | mouseClickUpType,
                    x, y, 0, 0);
            }

            await Task.Delay(Period);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
