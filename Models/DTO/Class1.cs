using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEVIMLI_KITAPCILIKAPI.Models.DTO
{
    public class Class1
    {
        private int Id;
        public int _id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string Eser;
        public string _eser
        {
            get { return Eser; }
            set { Eser = value; }
        }
        private string Yazar;
        public string _yazar
        {
            get { return Yazar; }
            set { Yazar = value; }
        }
        private string Konum;
        public string _konum
        {
            get { return Konum; }
            set { Konum = value; }
        }
        private int Fiyat;
        public int _fiyat
        {
            get { return Fiyat; }
            set { Fiyat = value; }
        }
        private int Adet;
        public int _adet
        {
            get { return Adet; }
            set { Adet = value; }
        }

    }
}