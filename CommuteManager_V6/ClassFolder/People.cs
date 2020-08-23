using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
//using xc = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace CommuteManager_V6
{
	public class People
	{//Class module for personal database.      
            #region Global
		public string Name; //이름
		public string Photo; //사진경로
		public string TagID; //EPC ID
		public string Blood; //혈액형
		public string Job; //직종
		public string Company; //회사명
		public string PK; //주민번호
		public string Phone; //전화번호
		public string Emer; //긴급연락
		public string Address; //주소
		public string Year; //근무경력
		public string Insure; //보험
		public string Edu; //신규교육
        

		public Boolean Status;
        #endregion

        //xc.Application excellApp = null;
        //xc.Workbook wb = null;
        //xc.Worksheet ws = null;

      
		public People()
		{//Constructor : set null.
			Name = null;
			Phone = null;
			TagID = null;
			Status = false;
		}

		public People(string _fileName)
		{//Constructor : load data from ini file at cunstructiong.
			//LoadIni(_fileName);
			Status = false;
		}

        public People(string _name,string _tagID, string _Blood, string _Job, string _company, 
                        string _PK, string _Phone, string _emer, string _address, 
                        string _year, string _insure, string _edu)
        {
            Name = _name;
            TagID = _tagID;
            Blood = _Blood;
            Job = _Job;
            Company = _company;
            PK = _PK;
            Phone = _Phone;
            Emer = _emer;
            Address = _address;
            Year = _year;
            Insure = _insure;
            Edu = _edu;            
        }

		public People(string _name, string _TagID)
		{//Constructor : set name and EPC ID.
			Name = _name;
			TagID = _TagID;
			Status = false;
		}

        public void saveExcel()
        {
            /*if (Name != null && TagID != null)
            {
                excellApp = new xc.Application();
                wb = excellApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
                ws = wb.Worksheets.Item["Personal Data"];

                int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                ws.Cells[nInLastRow + 1, 1] = Name;
                ws.Cells[nInLastRow + 1, 2] = TagID;
                ws.Cells[nInLastRow + 1, 3] = Blood;
                ws.Cells[nInLastRow + 1, 4] = Job;
                ws.Cells[nInLastRow + 1, 5] = Company;
                ws.Cells[nInLastRow + 1, 6] = PK;
                ws.Cells[nInLastRow + 1, 7] = Phone;
                ws.Cells[nInLastRow + 1, 8] = Emer;
                ws.Cells[nInLastRow + 1, 9] = Address;
                ws.Cells[nInLastRow + 1, 10] = Year;
                ws.Cells[nInLastRow + 1, 11] = Insure;
                ws.Cells[nInLastRow + 1, 12] = Edu;

                wb.Save();
                wb.Close();
                excellApp.Quit();*/
            }
        }

		/*public void SaveIni(string _path)
		{//Save current information to ini file. _path is full name of target file.
			if (Name != null && TagID != null)
			{//If the name and ID of intomation is not a null data.

				//Check the target file existence, and if it's not, create new one.
				//if it's already there, will be overwrited.
				string sDirPath;
				sDirPath = _path + "\\PersonalData";//Directory of personal data storage.
				DirectoryInfo di = new DirectoryInfo(sDirPath);
				if (di.Exists == false)
				{
					di.Create();
				}

				//Construct file name to "Name_EPCid.ini"
				string _fileName = sDirPath + "\\" + Name + "_" + TagID + ".ini";
				Save_Ini _Ini = new Save_Ini(_fileName);

				//write the data to target file.
				_Ini.IniWriteValue("People", "Name", Name);
				_Ini.IniWriteValue("People", "Photo", Photo);
				_Ini.IniWriteValue("People", "TagID", TagID);
				_Ini.IniWriteValue("People", "Blood", Blood);
				_Ini.IniWriteValue("People", "Job", Job);
				_Ini.IniWriteValue("People", "Company", Company);
				_Ini.IniWriteValue("People", "PK", PK);
				_Ini.IniWriteValue("People", "Phone", Phone);
				_Ini.IniWriteValue("People", "Emer", Emer);
				_Ini.IniWriteValue("People", "Address", Address);
				_Ini.IniWriteValue("People", "Year", Year);
				_Ini.IniWriteValue("People", "Insure", Insure);
				_Ini.IniWriteValue("People", "Edu", Edu);
			}
		}

		public void LoadIni(string _path)
		{//Load personal data from file "_path". it'll be saved on globals.

			string _fileName = _path;//Set the target path.
			System.IO.FileInfo _info = new System.IO.FileInfo(_fileName);//Get file info.

			if (_info.Exists)
			{//if there is a file which we are looking for...
				Save_Ini _Ini = new Save_Ini(_fileName);//Create ini manager instance.
													//Load data by ini form.
				Name = _Ini.IniReadValue("People", "Name");
				Photo = _Ini.IniReadValue("People", "Photo");
				TagID = _Ini.IniReadValue("People", "TagID");
				Blood = _Ini.IniReadValue("People", "Blood");
				Job = _Ini.IniReadValue("People", "Job");
				Company = _Ini.IniReadValue("People", "Company");
				PK = _Ini.IniReadValue("People", "PK");
				Phone = _Ini.IniReadValue("People", "Phone");
				Emer = _Ini.IniReadValue("People", "Emer");
				Address = _Ini.IniReadValue("People", "Address");
				Year = _Ini.IniReadValue("People", "Year");
				Insure = _Ini.IniReadValue("People", "Insure");
				Edu = _Ini.IniReadValue("People", "Edu");
			}
			else
			{//or not, set current data to null.
				Name = null;
				Photo = null;
				TagID = null;
				Blood = null;
				Job = null;
				Company = null;
				PK = null;
				Phone = null;
				Emer = null;
				Address = null;
				Year = null;
				Insure = null;
				Edu = null;
			}
		}

        // Main 에 LoadPeople method -
        public void LoadExcel()
        {
            excellApp = new xc.Application();
            wb = excellApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
            ws = wb.Worksheets.Item["Personal Data"];

            int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;            
        }*/
        
	}



