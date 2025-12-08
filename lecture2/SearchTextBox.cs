using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
public class SearchTextBox : UserControl
{
TextBox txt = new TextBox();
ListBox list = new ListBox();
public List<string> SuggestList { get; set; } = new List<string>();
public SearchTextBox()
{
this.Height = 25;
txt.Dock = DockStyle.Top;
list.Visible = false;
list.Height = 100;
list.Top = txt.Bottom;
txt.TextChanged += (s, e) => UpdateFilter();
list.Click += (s, e) => SelectItem();
this.Controls.Add(list);
this.Controls.Add(txt);
}
private void UpdateFilter()
{
string text = txt.Text.ToLower();
var results = SuggestList.Where(a =>
a.ToLower().Contains(text)).ToList();
if (results.Any())
{
list.Visible = true;
list.DataSource = results;
}
else list.Visible = false;
}
private void SelectItem()
{
txt.Text = list.SelectedItem.ToString();
list.Visible = false;
}
}
