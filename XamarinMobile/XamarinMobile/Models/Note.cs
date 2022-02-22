using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.Models
{
    public class Note
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
