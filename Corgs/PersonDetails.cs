using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using Mindscape.LightSpeed.Querying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corgs
{
    class PersonDetails
    {
        LightSpeedContext<LightSpeedModelDetailsUnitOfWork> lscon = new LightSpeedContext<LightSpeedModelDetailsUnitOfWork>();


        public PersonDetails(string firstName_, string midName_, string lastName_, int agePerson_, DateTime dateOfVisit_)
        {
            loadConnection();
            fName = firstName_;
            mName = midName_;
            lName = lastName_;
            age = agePerson_;
            dateVisit = dateOfVisit_;
        }

        public PersonDetails()
        {
            loadConnection();
            fName = "";
            mName = "";
            lName = "";
            age = 0;
            dateVisit = DateTime.Today;
        }

        private void loadConnection()
        {
            lscon.ConnectionString = "Data Source=BARREDOPC\\SQLEXPRESS;Initial Catalog=DBDat;Persist Security Info=True;User ID=rdmsdb;Password=rdms123;Pooling=False";
            lscon.DataProvider = DataProvider.SqlServer2008;
            lscon.IdentityMethod = IdentityMethod.IdentityColumn;
        }

        public Boolean addRecords()
        {
            try
            {
                
                using (var uow = lscon.CreateUnitOfWork())
                {
                    TblRecord tRecords = new TblRecord();
                    tRecords.Fname = fName;
                    tRecords.Mname = mName;
                    tRecords.Lname = lName;
                    tRecords.Age = age;
                    tRecords.Vdate = dateVisit;
                    tRecords.CaseId = generateCase(lName, fName);

                    if (tRecords.Errors.Count == 0)
                    {
                        uow.Add(tRecords);
                        uow.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }
            
        }

        public Boolean searchByCase(string caseNumber)
        {
            try
            {
                using (var unitOfWork = lscon.CreateUnitOfWork())
                {
                    TblRecord trecord = new TblRecord();
                    trecord = unitOfWork.FindOne<TblRecord>(Entity.Attribute(TblRecord.CaseIdField) == caseNumber);
                    myFName = trecord.Fname;
                    myMName = trecord.Mname;
                    myLName = trecord.Lname;
                    myDateVisit = Convert.ToDateTime(trecord.Vdate);
                    myAge = Convert.ToInt16(trecord.Age);
                    myCase = trecord.CaseId;
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("searchRecordsSingle Error: {0}",e);
                return false;
                throw;
            }
        }

        public IList<TblRecord> searchRecords(string lastNameField)
        {
            try
            {
                using (var uow = lscon.CreateUnitOfWork())
                {
                    IList<TblRecord> tRecord = uow.Find<TblRecord>(Entity.Attribute(TblRecord.LnameField).Like(lastNameField + "%"));
                    if (tRecord.Count > 0)
                    {
                        return tRecord;
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("searchRecords Error: {0}", e);
                return null;
            }
        }

        public IList<TblRecord> searchRecordsLINQ(string lastNameField)
        {
            try
            {
                using (var unitOfWork = lscon.CreateUnitOfWork())
                {
                    dynamic listPatients = from o in unitOfWork.TblRecords
                                       where o.Lname.StartsWith(lastNameField)
                                       select o;

                    if (listPatients.Count() > 0) {
                        Console.WriteLine("Number of people with last name {0}: {1}.", lastNameField, listPatients.Count());
                        myCountPatient = listPatients.Count();
                       
                        return listPatients.ToList();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("searchRecordsLINQ ERROR: " + e);
                Console.WriteLine("searchRecordsLINQ Error: {0}", e);
                return null;
                throw;
            }
        }

        public IList<TblRecord> searchToListview(string lastNameField)
        {
            try
            {
                using (var uow = lscon.CreateUnitOfWork())
                {
                    IList<TblRecord> tRecord = uow.Find<TblRecord>(Entity.Attribute(TblRecord.LnameField).Like(lastNameField + "%"));
                    if (tRecord.Count > 0)
                    {
                        return tRecord;
                    }
                    else
                    {                    
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("searchToListview error:" + e);
                return null;
            }
        }

        private string generateCase(string lastname, string firstname)
        {
            string nameField = lastname + firstname;
            string nums = Convert.ToString(nameField + DateTime.Now);
            nums = nums.Replace(" ", "");
            nums = nums.Replace(":", "");
            nums = nums.Replace("0", "N");
            nums = nums.Replace("/", "");

            var chars = nums;
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        private string fName = "";
        private string mName= "";
        private string lName= "";
        private int age= 0;
        private DateTime dateVisit= DateTime.Today;

        public string myFName { get; set; }
        public string myLName { get; set;}
        public string myMName { get; set;}
        public int myAge { get; set;}
        public DateTime myDateVisit { get; set;}
        public string myCase { get; set; }

        public int myCountPatient { get; set; }
    }
}
