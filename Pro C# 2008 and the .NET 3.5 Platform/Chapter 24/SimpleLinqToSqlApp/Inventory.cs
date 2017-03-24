using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SimpleLinqToSqlApp
{
  [Table]
  public class Inventory
  {
    #region Fields
    // Can use automatic properties.
    [Column]
    public string Make {get; set;} 

    // Or public fields.
    [Column]
    public string Color;

    // Identify the primary key.
    [Column(IsPrimaryKey = true)]
    public int CarID;

    // Or traditional CLR property syntax.
    // note [Column] is on the prop, not 
    // the backing field. 
    [Column]
    public string PetName
    {
      get { return name; }
      set { name = value; }
    }
    private string name;
    #endregion

    public override string ToString()
    {
      return string.Format("ID = {0}; Make = {1}; Color = {2}; PetName = {3}",
        CarID, Make.Trim(), Color.Trim(), PetName.Trim());
    }
  }
}
