using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessMultipleExceptions
{
  #region CarIsDeadException, take one.
  //public class CarIsDeadException : ApplicationException
  //{
  //  private string messageDetails;
  //  private DateTime errorTimeStamp;
  //  private string causeOfError;

  //  public DateTime TimeStamp
  //  {
  //    get { return errorTimeStamp; }
  //    set { errorTimeStamp = value; }
  //  }
  //  public string Cause
  //  {
  //    get { return causeOfError; }
  //    set { causeOfError = value; }
  //  }

  //  public CarIsDeadException() { }
  //  public CarIsDeadException(string message,
  //  string cause, DateTime time)
  //  {
  //    messageDetails = message;
  //    causeOfError = cause;
  //    errorTimeStamp = time;
  //  }
  //  // Override the Exception.Message property.
  //  public override string Message
  //  {
  //    get
  //    {

  //      return string.Format("Car Error Message: {0}", messageDetails);
  //    }
  //  }
  //}
  #endregion

  #region CarIsDeadException, take two.
  //public class CarIsDeadException : ApplicationException
  //{
  //  private DateTime errorTimeStamp;
  //  private string causeOfError;

  //  public DateTime TimeStamp
  //  {
  //    get { return errorTimeStamp; }
  //    set { errorTimeStamp = value; }
  //  }
  //  public string Cause
  //  {
  //    get { return causeOfError; }
  //    set { causeOfError = value; }
  //  }

  //  public CarIsDeadException() { }
    
  //  // Feed message to parent constructor.
  //  public CarIsDeadException(string message,
  //  string cause, DateTime time)
  //    : base(message)
  //  {
  //    causeOfError = cause;
  //    errorTimeStamp = time;
  //  }
  //}
  #endregion

  #region CarIsDeadException, take three.  
  [global::System.Serializable]
  public class CarIsDeadException : ApplicationException
  {
    //
    // For guidelines regarding the creation of new exception types, see
    //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
    // and
    //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
    //

    public CarIsDeadException() { }
    public CarIsDeadException(string message) : base(message) { }
    public CarIsDeadException(string message, Exception inner) : base(message, inner) { }
    protected CarIsDeadException(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context)
      : base(info, context) { }

    // Feed message to parent constructor.
    public CarIsDeadException(string message,
    string cause, DateTime time)
      : base(message)
    {
      causeOfError = cause;
      errorTimeStamp = time;
    }

    private DateTime errorTimeStamp;
    private string causeOfError;

    public DateTime TimeStamp
    {
      get { return errorTimeStamp; }
      set { errorTimeStamp = value; }
    }
    public string Cause
    {
      get { return causeOfError; }
      set { causeOfError = value; }
    }
  }
  #endregion
}
