﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            mahasiswa saya = new mahasiswa();
            mahasiswa kamu = new mahasiswa();

            saya.Nim = "2330";
            saya.Nama = "Ucik";
            saya.Ipk = 4;

            kamu.Nim = "2356";
            kamu.Nama = "Febe";
            kamu.Ipk = 4;

            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }


        }
    }

