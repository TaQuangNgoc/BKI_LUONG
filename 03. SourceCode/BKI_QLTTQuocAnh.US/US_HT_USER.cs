///************************************************
/// Generated by: haihd
/// Date: 15/07/2016 04:14:06
/// Goal: Create User Service Class for HT_USER
///************************************************
/// <summary>
/// Create User Service Class for HT_USER
/// </summary>

using System;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_DichVuMatDat.US{

public class US_HT_USER : US_Object
{
	private const string c_TableName = "HT_USER";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strUSERNAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "USERNAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["USERNAME"] = value;
		}
	}

	public bool IsUSERNAMENull() 
	{
		return pm_objDR.IsNull("USERNAME");
	}

	public void SetUSERNAMENull() {
		pm_objDR["USERNAME"] = System.Convert.DBNull;
	}

	public string strPASSWORD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PASSWORD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PASSWORD"] = value;
		}
	}

	public bool IsPASSWORDNull() 
	{
		return pm_objDR.IsNull("PASSWORD");
	}

	public void SetPASSWORDNull() {
		pm_objDR["PASSWORD"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_HT_USER() 
	{
		pm_objDS = new DS_HT_USER();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_HT_USER(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_HT_USER(decimal i_dbID) 
	{
		pm_objDS = new DS_HT_USER();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
