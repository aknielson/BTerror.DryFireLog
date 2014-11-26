using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BTerror.DryFireLog.Models
{
    [DataContract]
    public class Drill
    {
        [DataMember]
        public int DrillId { get; set; }

        [DataMember]
        public int BoodId { get; set; }
        [DataMember]
        public virtual Book Book { get; set; }

        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public int Name { get; set; }

        [DataMember]
        public string Description { get; set; }
 
    }

    public class Book
    {
        private ICollection<Drill> _drills; 
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string Version { get; set; }

        public string Things { get; set; }

        public virtual ICollection<Drill> Drills
        {
            get { return _drills; }
            set { _drills = value; }
        }
    }

    public class Entry
    {
        public int EntryId { get; set; }
        public DateTime EntryDate { get; set; }

        public Decimal InitialPar { get; set; }
        public Decimal EndingPar { get; set; }

        public int RepititionsCompleted { get; set; }

        public int DrillId { get; set; }
        public virtual Drill Drill { get; set; }

    }

    public class DryFireSession
    {
        private ICollection<Entry> _drillEntries;
        public int DryFireSessionId { get; set; }

        public DateTime SessionDate { get; set; }

        public virtual ICollection<Entry> DrillEntries
        {
            get { return _drillEntries; }
            set { _drillEntries = value; }
        } 
    }
}
