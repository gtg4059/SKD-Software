using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Protocol_data
{
	#region Global
	private string STX, ETX, SEP1, SEP2;//Starting, Ending, Seperator1, Seperator2 text.
	public string Buffer;//Communication data container.
	private int FocusS, FocusE;//Indicator for cutting Buffer data. related with STX and ETX.

	public delegate void Function();//Function pointer for function activating protocol.
	List<Function> DataFunction;//List for Function pointer
	List<string> KeyFunction;//List for Function activating protocol's key text.

	List<double> DataDouble;//List of double for numerical protocol.
	List<string> KeyDouble;//List of numerical protocol's key text.

	List<string> DataString;//List of text for numerical protocol.
	List<string> KeyString;//List of numerical protocol's key text.

	private int NoData;
	private string Catch;
	#endregion

	public void Protocol()
	{
		//STX = "[";
		// ETX = "]";
		STX = "(";
		ETX = ")";
		SEP1 = ",";
		SEP2 = "=";

		DataDouble = new List<double>();
		KeyDouble = new List<string>();

		DataString = new List<string>();
		KeyString = new List<string>();

		DataFunction = new List<Function>();
		KeyFunction = new List<string>();


		Buffer = "";
	}

	public void AddBuffer(string text)
	{
		if (text != null)
			Buffer = Buffer + text;
		else
			return;
	}

	public void AddDouble(string Key)
	{
		KeyDouble.Add(Key);
		DataDouble.Add(0);
	}

	public void AddString(string Key)
	{
		KeyString.Add(Key);
		DataString.Add("");
	}

	public void AddFunction(string Key, Function Pointer)
	{
		KeyFunction.Add(Key);
		DataFunction.Add(Pointer);
	}

	public bool CheckBlock()
	{
		int nstx = Buffer.IndexOf(STX);
		int netx = Buffer.IndexOf(ETX);

		if (netx > nstx)
		{
			FocusS = nstx;
			FocusE = netx;
			return true;
		}
		else
		{
			return false;
		}
	}

	private void CutFirstBlock()
	{
		int netx = Buffer.IndexOf(ETX);
		if (netx > 0)
		{
			int Len = Buffer.Length;
			netx++;
			Buffer = Buffer.Substring(netx, Len - netx);
		}
	}

	private void CutTrashHead()
	{
		int nstx = Buffer.IndexOf(STX);
		if (nstx > 0)
		{
			int Len = Buffer.Length;
			Buffer = Buffer.Substring(nstx, Len - nstx);
		}
	}

	public void ProcessBlock()
	{
		CutTrashHead();

		if (CheckBlock())
		{
			NoData = 0;
			Catch = "";
			string Block = Buffer.Substring(FocusS + 1, FocusE - FocusS - 1);
			string[] spBlock = Block.Split(SEP1.ToCharArray());

			for (int i = 0; i < spBlock.Length; i++)
			{
				string[] spCommand = spBlock[i].Split(SEP2.ToCharArray());

				for (int j = 0; j < KeyDouble.Count; j++)
				{
					if (spCommand[0] == KeyDouble[j])
					{
						DataDouble[j] = Convert.ToDouble(spCommand[1]);
						Catch = Catch + KeyDouble[j] + SEP1;
						NoData++;
						break;
					}
				}

				for (int j = 0; j < KeyString.Count; j++)
				{
					if (spCommand[0] == KeyString[j])
					{
						DataString[j] = spCommand[1];
						Catch = Catch + KeyString[j] + SEP1;
						NoData++;
						break;
					}
				}

				for (int k = 0; k < KeyFunction.Count; k++)
				{
					if (spCommand[0] == KeyFunction[k])
					{
						DataFunction[k]();
						Catch = Catch + KeyFunction[k] + SEP1;
						NoData++;
						break;
					}
				}
			}
			if (Catch != "") Catch = Catch.Remove(Catch.Length - 1);
			CutFirstBlock();
		}
		else		
			return;
		
	}

	public double GetDouble(string protocol)
	{
		for (int i = 0; i < KeyDouble.Count; i++)
		{
			if (KeyDouble[i] == protocol)
			{
				return DataDouble[i];
			}
		}
		return 0;
	}

	public string GetString(string protocol)
	{
		for (int i = 0; i < KeyString.Count; i++)
		{
			if (KeyString[i] == protocol)
			{
				return DataString[i];
			}
		}
		return "";
	}

	public int CountData()
	{
		return NoData;
	}

	public string CalledProtocol()
	{
		return Catch;
	}

	public bool HasProtocol(string protocol)
	{
		if (Catch == null) return false;
		try
		{
			if (Catch != "")
			{
				string[] txt = Catch.Split(Convert.ToChar(SEP1));
				for (int i = 0; i < txt.Length; i++)
				{
					if (txt[i] == protocol) return true;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void Design(string stx, string etx, string sep1, string sep2)
	{
		STX = stx;
		ETX = etx;
		SEP1 = sep1;
		SEP2 = sep2;
	}

	public void FlushBuffer()
	{
		Buffer = "";
	}
}