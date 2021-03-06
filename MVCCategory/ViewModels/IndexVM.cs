﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCCategory.Models;

namespace MVCCategory.ViewModels
{
    public class IndexVM
    {
        public NewsletterVM NewsletterVM { get; set; }
        public LoginViewModel LoginViewModel { get; set; }
        public List<Category> RootCategories { get; set; }
    }
}