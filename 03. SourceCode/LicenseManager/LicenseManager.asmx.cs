using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Data.Odbc;
using System.Data.Common;

namespace LicenseManager
{
    /// <summary>
    /// Summary description for LicenseManager
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LicenseManager : System.Web.Services.WebService
    {
        /// <summary>
        /// true : dang co ban quyen; false : khong co ban quyen
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool checkKey(string macAddress)
        {
            //string v_mac = getMac();

            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            var v_pk = v_ett.PRODUCT_KEY.Where(x => x.MAC == macAddress).FirstOrDefault();

            if (v_pk != null)
            {
                if (v_pk.EXPIRY_DATE < DateTime.Now.Date)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// true : dang dung thu; false : khong dung thu
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool checkTrial(string macAddress)
        {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            //string v_mac = getMac();
            var v_t = v_ett.TRAIL_MANAGER.Where(x => x.MAC == macAddress).FirstOrDefault();
            if (v_t == null)
            {
                writeLog(macAddress + " - return false : null");
                return false;
            }
            else
            {
                if (v_t.EXPIRY_DATE < DateTime.Now.Date)
                {
                    writeLog(macAddress + " - return false : het han dung thu");
                    return false;
                }
                else
                {
                    writeLog(macAddress + " - return true : dang dung thu");
                    return true;
                }
            }
        }

        [WebMethod]
        public bool checkMacTrial(string macAddress) {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            var v_t = v_ett.TRAIL_MANAGER.Where(x => x.MAC == macAddress).FirstOrDefault();
            if (v_t == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [WebMethod]
        public bool activeKey(string macAddress, string company, string key) {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            var v_key = v_ett.PRODUCT_KEY.Where(x => x.LICENSE == key && x.ACTIVE_YN == false).FirstOrDefault();
            if (v_key == null)
            {
                return false;
            }
            else {
                v_key.ACTIVE_TIME = DateTime.Now;
                v_key.ACTIVE_YN = true;
                v_key.COMPANY = company;
                v_key.MAC = macAddress;
                v_ett.Entry(v_key).State = System.Data.EntityState.Modified;
                v_ett.SaveChanges();
                return true;
            }
        }

        [WebMethod]
        public bool activeTrial(string macAddress, string company, string email, string phone) {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            var v_trial = v_ett.TRAIL_MANAGER.Where(x => x.MAC == macAddress).FirstOrDefault();
            if (v_trial != null)
            {
                return false;
            }
            else
            {
                string username = email.Split('@')[0].ToString();
                createNewLogin(username);
                createNewDB("ISalary_" + username);
                alterDB("ISalary_" + username);
                grantDBO(username, "ISalary_" + username);
                saveInfoDB(v_ett, "ISalary_" + username, username, "sa@123456", company, macAddress);
                saveInfo(v_ett, macAddress, company, email, phone);
                return true;
            }
        }

        private void saveInfoDB(LICENSE_MANAGEREntities ett ,string dbname, string username, string password, string company, string macAddress)
        {
            DB_ISALARY v_dbi = new DB_ISALARY();
            v_dbi.COMPANY = company;
            v_dbi.CREATE_TIME = DateTime.Now;
            v_dbi.DBNAME = dbname;
            v_dbi.PASSWORD = password;
            v_dbi.USERNAME = username;
            ett.DB_ISALARY.Add(v_dbi);
            ett.SaveChanges();

            MAC_DB v_mdb = new MAC_DB();
            v_mdb.ID_DB = v_dbi.ID;
            v_mdb.MAC = macAddress;
            ett.MAC_DB.Add(v_mdb);
            ett.SaveChanges();
        }

        private void createNewDB(string dbname)
        {

            string script = File.ReadAllText(@"C:\backupDB\createNewDBISalary\2.1.createNewDB.sql");
            script = script.Replace("dbname", dbname);
            executeScript(script);
        }

        private void executeScript(string script)
        {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            v_ett.Database.Connection.Open();
            DbCommand db = v_ett.Database.Connection.CreateCommand();
            db.CommandText = script;
            db.ExecuteNonQuery();
            v_ett.Database.Connection.Close();
        }

        private void alterDB(string dbname)
        {
            string script = File.ReadAllText(@"C:\backupDB\createNewDBISalary\2.2.createDB.sql");
            script = script.Replace("dbname", dbname);
            executeScript(script);
        }

        private void grantDBO(string username, string dbname)
        {
            string script = File.ReadAllText(@"C:\backupDB\createNewDBISalary\3.grantDBO.sql");
            script = script.Replace("dbname", dbname);
            script = script.Replace("user_name", username);
            executeScript(script);
        }

        private void createNewLogin(string username)
        {
            string script = File.ReadAllText(@"C:\backupDB\createNewDBISalary\1.createLogin.sql");
            script = script.Replace("username", username);
            script = script.Replace("password", "sa@123456");
            executeScript(script);
        }

        private void saveInfo(LICENSE_MANAGEREntities v_ett, string macAddress, string company, string email, string phone)
        {
            TRAIL_MANAGER v_t = new TRAIL_MANAGER();
            v_t.COMPANY = company;
            v_t.EMAIL = email;
            v_t.EXPIRY_DATE = DateTime.Now.Date.AddDays(30);
            v_t.MAC = macAddress;
            v_t.PHONE = phone;
            v_t.TRAIL_TIME = DateTime.Now;
            v_ett.TRAIL_MANAGER.Add(v_t);
            v_ett.SaveChanges();
        }

        [WebMethod]
        public CTrial getTrial(string macAddress)
        {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            var v_t = v_ett.TRAIL_MANAGER.Where(x => x.MAC == macAddress).First();
            CTrial v_ct = new CTrial();
            v_ct.COMPANY = v_t.COMPANY;
            v_ct.EMAIL = v_t.EMAIL;
            v_ct.EXPIRY_DATE = v_t.EXPIRY_DATE.Value;
            v_ct.PHONE = v_t.PHONE;
            v_ct.TRAIL_TIME = v_t.TRAIL_TIME.Value;
            return v_ct;
        }

        [WebMethod]
        public CLicense getLicense(string macAddress)
        {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            var v_t = v_ett.PRODUCT_KEY.Where(x => x.MAC == macAddress).First();
            CLicense v_ct = new CLicense();
            v_ct.COMPANY = v_t.COMPANY;
            v_ct.EXPIRY_DATE = v_t.EXPIRY_DATE.Value;
            return v_ct;
        }

        [WebMethod]
        public DB_ISALARY getInfoServer(string macAddress) {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            var v_mdb = v_ett.MAC_DB.Where(x => x.MAC == macAddress).FirstOrDefault();
            if (v_mdb == null)
            {
                return null;
            }
            else
            {
                var m_dbi = v_ett.DB_ISALARY.Where(x => x.ID == v_mdb.ID_DB).First();
                return m_dbi;
            }
        }

        private void writeLog(string log) {
            LICENSE_MANAGEREntities v_ett = new LICENSE_MANAGEREntities();
            LOG_IS v_log = new LOG_IS();
            v_log.CREATE_TIME = DateTime.Now;
            v_log.LOG_RESULT = log;
            v_ett.LOG_IS.Add(v_log);
            v_ett.SaveChanges();
        }
    }
}