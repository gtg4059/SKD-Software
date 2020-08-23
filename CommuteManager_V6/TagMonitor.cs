using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommuteManager_V6
{
	public partial class TagMonitor : Form
	{
		Taglist_Manager TagList;
		private bool sw_stop = false;

		public TagMonitor()
		{
			InitializeComponent();
			listView_Tag.DoubleBuffered(true);
		}

		public TagMonitor(Taglist_Manager _TagList)
		{
			InitializeComponent();
			TagList = _TagList;
			timer_Update.Enabled = true;
			listView_Tag.DoubleBuffered(true);
		}

		#region ListView Control

		private void ListUpdate()
		{
			List<Taglist_Manager.List_Tag> _TagList = new List<Taglist_Manager.List_Tag>(TagList.TagList);
			listView_Tag.BeginUpdate();
			if(_TagList.Count > 0)
			{
				foreach(Taglist_Manager.List_Tag _Tag in _TagList)
				{
					bool _flag = false;

					foreach (ListViewItem _Item in listView_Tag.Items)
					{
						if(ItemUpdate(_Item, _Tag))
						{
							_flag = true;
							break;
						}
					}

					if(_flag == false)
					{
						ItemAdd(_Tag);
					}
				}
			}
			RemoveOld();//Remove items on listview which is not exist anymore.
			listView_Tag.EndUpdate();//hold off. related with 'listView_Tag.BeginUpdate()'
		}

		private bool ItemUpdate(ListViewItem _Item, Taglist_Manager.List_Tag _Tag)
		{//Update listview control's item with kyhTag class.
			if (_Item.SubItems[1].Text == _Tag.ID)
			{//If EPC IDs are same...
				_Item.SubItems[0].Text = (_Item.Index + 1).ToString();//Data Number.
				_Item.SubItems[2].Text = _Tag.Ant;//Antenna Number update.
				_Item.SubItems[3].Text = _Tag.RSSI.ToString();//RSSI update.
				TimeSpan _Span = DateTime.Now - _Tag.Time;//Calculate time span.
				_Item.SubItems[4].Text = _Tag.GATE;
				_Item.SubItems[5].Text = _Span.Seconds.ToString();//Time span update.
				return true;
			}
			else
			{//If EPC IDs are not same...
				return false;//Do nothing.
			}
		}

		private void ItemAdd(Taglist_Manager.List_Tag _Tag)
		{//Add new Item to listview_tag with kyhTag class.
		 //Create listview item instance.
			ListViewItem _Item = new ListViewItem(listView_Tag.Items.Count.ToString());

			_Item.SubItems.Add(_Tag.ID);//EPC ID write.
			_Item.SubItems.Add(_Tag.Ant);//Antenna write.
			_Item.SubItems.Add(_Tag.RSSI.ToString());//RSSI value write.
			_Item.SubItems.Add(_Tag.GATE);
			_Item.SubItems.Add("0");//Time span is 0.
			listView_Tag.Items.Add(_Item);//Add item to listview.
		}

		private void RemoveOld()
		{//Remove items on listview which is not exist anymore.
			foreach (ListViewItem _Item in listView_Tag.Items)
			{//For every items in the listview...
				bool _flag = false;//Flag to find out existence.
				string _ID = _Item.SubItems[1].Text;//Remember EPC ID of Item.
				foreach (Taglist_Manager.List_Tag _Tag in TagList.TagList)
				{//For every tag in the tagList...
					if (_Tag.ID == _ID)
					{//If there is a tag with same ID...
						_flag = true;//Existence flag on!
						break;//There is same ID, so this item is not need to be removed.
					}
				}
				if (_flag == false)
				{//If there is no this ID on the list...
					listView_Tag.Items.Remove(_Item);//Remove listview item.
				}
			}
		}
		#endregion

		private void timer_Update_Tick(object sender, EventArgs e)
		{
			if(!sw_stop)
			{
				ListUpdate();
			}
		}

		private void toolStripButton_Close_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}

		private void toolStripButton_Stop_Click(object sender, EventArgs e)
		{
			sw_stop = !sw_stop;
		}

		private void toolStripButton_Check_Click(object sender, EventArgs e)
		{
			//Create selected Item group of listview_tag
			ListView.SelectedListViewItemCollection _Selected = listView_Tag.SelectedItems;

			string Selected_ID = "";
			if (_Selected.Count > 0)
			{//If there is selected item...
				Selected_ID = _Selected[0].SubItems[1].Text;//remember first item's ID.
				Clipboard.SetText(Selected_ID);//copy it to the clipboard.
				this.DialogResult = DialogResult.OK;//set dialog result OK.
			}
			else
			{//if there is no item selected...
				this.DialogResult = DialogResult.No;//set dialog result No.
			}
			this.Close();
		}


	}
}
