using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Student
    {
        private String name;
        private String id;
        private String department;
        private Book[] borrowedBook;
        private int borrowedBookCount;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
      