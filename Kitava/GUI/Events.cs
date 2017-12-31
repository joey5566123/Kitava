using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using Kitava.GUI;

namespace Kitava.GUI
{
    public partial class KitavaForm
    {
        protected int ColumnValue = 1, RowValue = 1;

        private async void MapsButtonClick(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            var directory = FindDirectory(@"C:\Users\" + Environment.UserName + @"\Desktop", "default");
            if (directory != String.Empty)
            {
                var httpClient = new HttpClient();
                var httpResponseMessage = await httpClient.GetAsync("https://raw.githubusercontent.com/joey5566123/Exiled-Bot/master/Map.ipd");
                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();

                File.Delete(directory + @"\Maps\default.ipd");
                File.WriteAllBytes(directory + @"\Maps\default.ipd", bytes);
                MessageBox.Show("Update Map.ipd Successful");
            }
            else
            {
                MessageBox.Show("Can Not Found Directory");
            }
            ((Button)sender).Enabled = true;
        }

        private async void PickitButtonClick(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            var directory = FindDirectory(@"C:\Users\" + Environment.UserName + @"\Desktop", "default");
            if (directory != String.Empty)
            {
                var httpClient = new HttpClient();
                var httpResponseMessage = await httpClient.GetAsync("https://raw.githubusercontent.com/joey5566123/Exiled-Bot/master/On-Game");
                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();

                File.Delete(directory + @"\Pickit\default.ipd");
                File.WriteAllBytes(directory + @"\Pickit\default.ipd", bytes);
                MessageBox.Show("Update Pickit.ipd Successful");
            }
            else
            {
                MessageBox.Show("Can Not Found Directory");
            }
            ((Button)sender).Enabled = true;
        }

        private void ColumnValueChanged(object sender, EventArgs e)
        {
            ColumnValue = Decimal.ToInt32(ColumnNumeric.Value);
            if (ColumnValue < 1 || ColumnValue > 5)
            {
                ColumnValue = 1;
                ColumnNumeric.Value = ColumnValue;
            }
            ColumnRowValueChange(ColumnValue, RowValue);
        }

        private void RowValueChanged(object sender, EventArgs e)
        {
            RowValue = Decimal.ToInt32(RowNumeric.Value);
            if (RowValue < 1 || RowValue > 12)
            {
                RowValue = 1;
                RowNumeric.Value = RowValue;
            }
            ColumnRowValueChange(ColumnValue, RowValue);
        }

        private void DelayValueChange(object sender, EventArgs e)
        {
            int DelayTime = Decimal.ToInt32(DelayNumeric.Value);
            if (DelayTime < 10)
            {
                MessageBox.Show("Delay請勿低於10ms");
                DelayTime = 10;
                DelayNumeric.Value = DelayTime;
            }
            DelayValueChange(DelayTime);
        }
        private void TabChange(object sender, EventArgs e)
        {
            SelectIndexChange(tabControl1.SelectedIndex);
        }
    }
}