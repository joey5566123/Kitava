using Kitava.Library;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitava.GUI
{
    public partial class KitavaForm : Form
    {
        private bool IsControlClicking, IsShiftClicking, IsInventoryClicking, IsCardChanging;
        private int SelectIndex = 0;
        private int Column = 1, Row = 1;
        private int DelayTime = 50;
        private Task InventoryTask, CardTask;
        private CancellationTokenSource InventoryCancelToken, CardTaskCancelToken;
        private Point InventoryCoordinate, CardChangeButtonCoordinate, ChangeItemCoordinate;
        private Hashtable hotkeyTable;
        private System.Timers.Timer clickControlTimer;
        private System.Timers.Timer clickShiftTimer;

        private void InitializeHotKey()
        {
            IsControlClicking = IsShiftClicking = false;
            hotkeyTable = new Hashtable
            {
                { Hotkey.RegisterHotkey(Handle, 0, Keys.F2), Keys.F2 },
                { Hotkey.RegisterHotkey(Handle, 2, Keys.F2), Keys.F2 },
                { Hotkey.RegisterHotkey(Handle, 0, Keys.F3), Keys.F3 },
                { Hotkey.RegisterHotkey(Handle, 2, Keys.F3), Keys.F3 },
                { Hotkey.RegisterHotkey(Handle, 4, Keys.F3), Keys.F3 }
            };
            clickControlTimer = new System.Timers.Timer
            {
                Interval = 10
            };
            clickControlTimer.Elapsed += new System.Timers.ElapsedEventHandler(Click);
            clickShiftTimer = new System.Timers.Timer
            {
                Interval = 10
            };
            clickShiftTimer.Elapsed += new System.Timers.ElapsedEventHandler(Click);
        }

        private new void Click(object sender, System.Timers.ElapsedEventArgs e)
        {
            Mouse.LeftClick();  
        }

        private async void InventoryClick(CancellationTokenSource ct)
        {
            Keyboard.Down(Keys.Control);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (!ct.IsCancellationRequested)
                    {
                        Mouse.Move(InventoryCoordinate.X + i * 29, InventoryCoordinate.Y + j * 29);
                        await Delay(DelayTime);
                        Mouse.LeftClick();
                        await Delay(DelayTime);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            Keyboard.Up(Keys.Control);
            IsInventoryClicking = false;
            if (InventoryTask.Status == TaskStatus.RanToCompletion || InventoryTask.Status == TaskStatus.Running)
            {
                InventoryTask.Dispose();
            }
        }

        private async void CardChange(CancellationTokenSource ct)
        {
            Keyboard.Down(Keys.Control);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (!ct.IsCancellationRequested)
                    {
                        Mouse.Move(InventoryCoordinate.X + i * 29, InventoryCoordinate.Y + j * 29);
                        await Delay(DelayTime);
                        Mouse.LeftClick();
                        await Delay(DelayTime);
                        Mouse.Move(CardChangeButtonCoordinate.X, CardChangeButtonCoordinate.Y);
                        await Delay(DelayTime);
                        Mouse.LeftClick();
                        await Delay(DelayTime);
                        Mouse.Move(ChangeItemCoordinate.X, ChangeItemCoordinate.Y);
                        await Delay(DelayTime);
                        Mouse.LeftClick();
                        await Delay(DelayTime);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            Keyboard.Up(Keys.Control);
            IsCardChanging = false;
            if (CardTask.Status == TaskStatus.RanToCompletion || CardTask.Status == TaskStatus.Running)
            {
                CardTask.Dispose();
            }
        }

        static async Task Delay(int iSecond)
        {
            await Task.Delay(iSecond);
        }

        public void SelectIndexChange(int Index)
        {
            SelectIndex = Index;
        }

        public void DelayValueChange(int ms)
        {
            DelayTime = ms;
        }

        public void ColumnRowValueChange(int ColumnIndex, int RowIndex)
        {
            Column = ColumnIndex;
            Row = RowIndex;
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x312)
            {
                var key = (Keys)hotkeyTable[message.WParam.ToInt32()];
                InventoryCoordinate = Coordinate.InitialCoordinate(Coordinate.CoordinatesStatus.InventoryCoordinate);
                CardChangeButtonCoordinate = Coordinate.InitialCoordinate(Coordinate.CoordinatesStatus.CardChangeButtonCoordinate);
                ChangeItemCoordinate = Coordinate.InitialCoordinate(Coordinate.CoordinatesStatus.ChangeItemCoordinate);
                switch (SelectIndex)
                {
                    case 0:
                        switch (key)
                        {
                            case Keys.F2:
                                MapsButton.PerformClick();
                                break;
                            case Keys.F3:
                                PickitButton.PerformClick();
                                break;
                        }
                        break;
                    case 1:
                        switch (key)
                        {
                            case Keys.F2:
                                if (IsControlClicking)
                                {
                                    clickControlTimer.Stop();
                                    Keyboard.Up(Keys.Control);
                                    IsControlClicking = false;
                                }
                                else
                                {
                                    Keyboard.Down(Keys.Control);
                                    clickControlTimer.Start();
                                    IsControlClicking = true;
                                }
                                break;
                            case Keys.F3:
                                if (IsShiftClicking)
                                {
                                    clickShiftTimer.Stop();
                                    Keyboard.Up(Keys.Shift);
                                    IsShiftClicking = false;
                                }
                                else
                                {
                                    Keyboard.Down(Keys.Shift);
                                    clickShiftTimer.Start();
                                    IsShiftClicking = true;
                                }
                                break;
                        }
                        break;
                    case 2:
                        switch (key)
                        {
                            case Keys.F2:
                                if (IsInventoryClicking)
                                {
                                    InventoryCancelToken.Cancel();
                                    Keyboard.Up(Keys.Control);
                                    if(InventoryTask.Status == TaskStatus.RanToCompletion || InventoryTask.Status == TaskStatus.Running)
                                    {
                                        InventoryTask.Dispose();
                                    }
                                    IsInventoryClicking = false;
                                }
                                else
                                {
                                    InventoryTask = new Task(() => InventoryClick(InventoryCancelToken));
                                    if (!InventoryCoordinate.IsEmpty)
                                    {
                                        IsInventoryClicking = true;
                                        InventoryCancelToken = new CancellationTokenSource();
                                        InventoryTask.Start();
                                    }
                                }
                                break;
                            case Keys.F3:
                                if (IsCardChanging)
                                {
                                    CardTaskCancelToken.Cancel();
                                    Keyboard.Up(Keys.Control);
                                    if (CardTask.Status == TaskStatus.RanToCompletion || CardTask.Status == TaskStatus.Running)
                                    {
                                        CardTask.Dispose();
                                    }
                                    IsCardChanging = false;
                                }
                                else
                                {
                                    CardTask = new Task(() => CardChange(CardTaskCancelToken));
                                    if (!CardChangeButtonCoordinate.IsEmpty)
                                    {
                                        IsCardChanging = true;
                                        CardTaskCancelToken = new CancellationTokenSource();
                                        CardTask.Start();
                                    }
                                }
                                break;
                        }
                        break;
                }
            }
        }
    }
}