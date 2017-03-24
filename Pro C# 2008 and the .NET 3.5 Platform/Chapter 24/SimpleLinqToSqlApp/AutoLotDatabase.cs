using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace SimpleLinqToSqlApp
{
  class AutoLotDatabase : DataContext
  {
    public Table<Inventory> Inventory;

    public AutoLotDatabase(string connectionString)
      : base(connectionString) { }
  }
}
