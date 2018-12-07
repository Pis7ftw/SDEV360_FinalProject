﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary_FinalProject.classes.exceptions
{
    public class NoTitleFoundMovieException : Exception
    {
        public NoTitleFoundMovieException() { }
        public NoTitleFoundMovieException(string message) : base(message) { }
        public NoTitleFoundMovieException(string message, Exception inner) : base(message, inner) { }

    }
}
