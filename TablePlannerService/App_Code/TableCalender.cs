using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TablePlanner
/// </summary>
public class TableCalander
{
    public DateTime Date { get; set; }
    public Table Table { get; set; }
    public bool IsBooked { get; set; }
}