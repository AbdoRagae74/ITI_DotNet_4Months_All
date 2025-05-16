using System;
using System.Collections.Generic;
using System.Text;

namespace LINQD02
{
  public class Subject2
  {
    public String Description {get; set;}
    public String Name {get; set;}

    public override string ToString()
    {
      return Name;
    }
  }
}