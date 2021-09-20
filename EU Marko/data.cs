using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_Marko
{
  class Data
  {
    private string orszagnev;

    public string Orszagnev
    {
      get { return orszagnev; }
      set { orszagnev = value; }
    }
    private int datum;

    public int Datum
    {
      get { return datum; }
      set { datum = value; }
     }
 
    public Data(string orszagnev, int datum)
    {
      this.orszagnev = orszagnev;
      this.datum = datum;
    }
  }
}
