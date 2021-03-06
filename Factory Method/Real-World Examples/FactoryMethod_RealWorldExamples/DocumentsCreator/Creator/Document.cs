﻿using DocumentsCreator.Product;
using System.Collections.Generic;

namespace DocumentsCreator.Creator
{
    /// <summary>
    /// The 'Creator' abstract class 
    /// </summary>
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages => _pages;

        // Factory Method
        public abstract void CreatePages();
    }
}
