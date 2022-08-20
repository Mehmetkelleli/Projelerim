using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneodev.Model
{
    public class Task
    {
        public int Id { get; set; }
        private string _name { get; set; }
        public bool Active { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "Geçersiz";
                }
            }
        }
    }
}
