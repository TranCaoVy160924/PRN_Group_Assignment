using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;

namespace Ass1.BusinessObject
{
    public class MemberDTO
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string Password { get; set; }
        public string MemberCity { get; set; }
        public string MemberCountry { get; set; }

        
    }

    public class SortableCollection<T> : Collection<T>
    {
        private readonly List<T> _list;

        public SortableCollection() : this(new List<T>()) { }
        public SortableCollection(List<T> list) : base(list)
        {
            _list = list;
        }
        public void Sort() { _list.Sort(); }
    }
}