﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.entity
{
    public class Kategori
    {
        [Key]

        public int KategoriID{ get; set; }
        public string KategoriAD { get; set; }
    }
}
