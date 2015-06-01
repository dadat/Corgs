using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace Corgs
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class TblRecord : Entity<long>
  {
    #region Fields
  
    [ValidateLength(0, 50)]
    private string _fname;
    [ValidateLength(0, 50)]
    private string _mname;
    [ValidateLength(0, 50)]
    private string _lname;
    private System.Nullable<int> _age;
    private System.Nullable<System.DateTime> _vdate;
    [ValidateLength(0, 50)]
    private string _caseId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Fname entity attribute.</summary>
    public const string FnameField = "Fname";
    /// <summary>Identifies the Mname entity attribute.</summary>
    public const string MnameField = "Mname";
    /// <summary>Identifies the Lname entity attribute.</summary>
    public const string LnameField = "Lname";
    /// <summary>Identifies the Age entity attribute.</summary>
    public const string AgeField = "Age";
    /// <summary>Identifies the Vdate entity attribute.</summary>
    public const string VdateField = "Vdate";
    /// <summary>Identifies the CaseId entity attribute.</summary>
    public const string CaseIdField = "CaseId";


    #endregion
    
    #region Properties



    [System.Diagnostics.DebuggerNonUserCode]
    public string Fname
    {
      get { return Get(ref _fname, "Fname"); }
      set { Set(ref _fname, value, "Fname"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Mname
    {
      get { return Get(ref _mname, "Mname"); }
      set { Set(ref _mname, value, "Mname"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Lname
    {
      get { return Get(ref _lname, "Lname"); }
      set { Set(ref _lname, value, "Lname"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> Age
    {
      get { return Get(ref _age, "Age"); }
      set { Set(ref _age, value, "Age"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> Vdate
    {
      get { return Get(ref _vdate, "Vdate"); }
      set { Set(ref _vdate, value, "Vdate"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string CaseId
    {
      get { return Get(ref _caseId, "CaseId"); }
      set { Set(ref _caseId, value, "CaseId"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the LightSpeedModelDetails model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class LightSpeedModelDetailsUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<TblRecord> TblRecords
    {
      get { return this.Query<TblRecord>(); }
    }
    
  }

}
