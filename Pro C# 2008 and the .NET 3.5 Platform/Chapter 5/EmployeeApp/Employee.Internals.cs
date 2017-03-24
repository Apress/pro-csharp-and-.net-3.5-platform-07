using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
  partial class Employee
  {
    #region Properties
    /// <summary>
    /// Gets and Sets the Age.
    /// </summary>
    public int Age
    {
      get { return empAge; }
      set { empAge = value; }
    }

    /// <summary>
    /// Gets and Sets the Name.
    /// </summary>
    public string Name
    {
      get { return empName; }
      set { empName = value; }
    }

    /// <summary>
    /// Gets and Sets the ID.
    /// </summary>
    public int ID
    {
      get { return empID; }
      set { empID = value; }
    }

    /// <summary>
    /// Gets and Sets the Pay.
    /// </summary>
    public float Pay
    {
      get { return currPay; }
      set { currPay = value; }
    }

    /// <summary>
    /// Read Only SSN property
    /// </summary>
    public string SocialSecurityNumber
    {
      get { return empSSN; }
    }

    /// <summary>
    /// Static Company property.
    /// </summary>
    public static string Company
    {
      get { return companyName; }
      set { companyName = value; }
    }
    #endregion

    #region Constructors.

    /// <summary>
    /// Default ctor.
    /// </summary>
    public Employee() { }
    /// <summary>
    /// Custom Constuctor
    /// </summary>
    /// <param name="name">Name of Employee</param>
    /// <param name="age">Age of Employee</param>
    /// <param name="id">ID of Employee</param>
    /// <param name="pay">Pay of Employee</param>
    /// <param name="ssn">SNN of Employee</param>
    public Employee(string name, int age, int id, float pay, string ssn)
    {
      empName = name;
      empID = id;
      empAge = age;
      currPay = pay;
      empSSN = ssn;
    }

    /// <summary>
    /// Static ctor.
    /// </summary>
    static Employee()
    {
      companyName = "Intertech Training";
    }
    #endregion

    #region Traditional Get/Set method for Name
    //// Accessor (get method)
    //public string GetName()
    //{
    //    return empName;
    //}

    //// Mutator (set method)
    //public void SetName(string name)
    //{
    //    // Remove any illegal characters (!,@,#,$,%),
    //    // check maximum length or case before making assignment.
    //    empName = name;
    //}

    //// Just for testing...
    //public string get_SocialSecurityNumber() 
    //{
    //    return empSSN;
    //}
    //public void set_SocialSecurityNumber(string ssn)
    //{
    //    empSSN = ssn;
    //}
    #endregion
  }
}
