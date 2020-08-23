using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Taglist_Manager
{
	public class List_Tag
	{
		public string ID; //EPC ID of Tag
		public DateTime Time; //Last time of update
		public string Ant; //Finded Antenna ID
		public double RSSI; //Received signal strength
		public string GATE; //Find Gate Number
		public string Event = "";

		#region Constructors
		public List_Tag(string _ID, string _Ant, double _RSSI, string _GATE)
		{
			ID = _ID;
			Ant = _Ant;
			RSSI = _RSSI;
			GATE = _GATE;
			Time = DateTime.Now;
		}

		public List_Tag(string _ID)
		{
			ID = _ID;
			Ant = "";
			RSSI = -99;
			Time = DateTime.Now;
		}

		public List_Tag(string _ID, double _RSSI)
		{
			ID = _ID;
			Ant = "";
			RSSI = _RSSI;
			Time = DateTime.Now;
		}

		public List_Tag(string _ID, string _Ant)
		{
			ID = _ID;
			Ant = _Ant;
			RSSI = -99;
			Time = DateTime.Now;
		}
		#endregion


	}


	public List<List_Tag> TagList;

	public Taglist_Manager()
	{
		TagList = new List<List_Tag>();
		TagList.Clear();
	}

	public void Update(string _ID, string _Ant, double _RSSI, string _GATE)
	{
		bool _flag = false;//Flag for recognize existence of tag.

		foreach (List_Tag i in TagList)
		{
			if (_ID == i.ID)
			{
				_flag = true;
				i.RSSI = _RSSI;
				if (_Ant != "")
				{
					if (_Ant == "1" && i.Ant == "0") i.Event = "in";
					if (_Ant == "0" && i.Ant == "1") i.Event = "Out";
					i.Ant = _Ant;
				}
				i.Time = DateTime.Now;
			}
		}

		if (_flag == false)
		{
			List_Tag newTag = new List_Tag(_ID, _Ant, _RSSI, _GATE);
			TagList.Add(newTag);
		}
	}
	public void RemoveOld(int _sec)
	{
        //Remove old tags in the TagList. _sec is time interval threshold in second.
		DateTime _now = DateTime.Now;//Set now time to compare lately discovered time.
		List<List_Tag> _TagList = new List<List_Tag>(TagList);//Make a deep copy of TagList. Cuz of safety.

		foreach (List_Tag i in _TagList)
		{
            //For every tag...
			TimeSpan _span = _now - i.Time;//Measure time span.
			if (_span.Seconds > _sec)
			{//If time span is longer than threshold...
				TagList.Remove(i);//Remove tag from original list.
			}
		}
	}
}
	




