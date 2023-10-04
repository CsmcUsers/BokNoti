using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Model;

public class TreeMap
{
    
    public Int32 Seq { get; set; }

    public string? 行政區 { get; set; }

    public string? 樹種 { get; set; }

    public string? 大約數量 { get; set; }

    public string? 約最小樹齡 { get; set; }

    public string? 約最大樹齡 { get; set; }

    public override string ToString()
    {
        return string.Format("{0,2}.{1,-4}{2,-9:C}{3,-4}", Seq, 行政區, 樹種, 大約數量) ;
    }
}
