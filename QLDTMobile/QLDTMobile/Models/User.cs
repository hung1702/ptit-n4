using System;
using System.Collections.Generic;
using System.Text;

namespace QLDTMobile.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string SDT { get; set; }
        public string SCMT { get; set; }
        public string Email { get; set; }
    }
}
