using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook() //object initializer syntax
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Role = "Script"},
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters"},
                }
            },
            new ComicBook()
            {
                Id  =  2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.<strong> Spider-Man visits the FF for a very private wake....</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Test1", Role = "Hard-Carry"},
                    new Artist() { Name = "Test2", Role = "Carry"},
                    new Artist() { Name = "Test3", Role = "Mage"},
                    new Artist() { Name = "Test14", Role = "Assasin"}
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 80,
                DescriptionHtml = "<p><strong>The Dungeon & The Paraphet, Part 1 </strong></p>",
                     Artists = new Artist[]
                     {
                    new Artist() { Name = "Sample1", Role = "Script"},
                    new Artist() { Name = "Sample1", Role = "Hard-Carry"},
                    new Artist() { Name = "Sample1", Role = "Carry"},
                    new Artist() { Name = "Sample1", Role = "Mage"},
                    new Artist() { Name = "Sample1", Role = "Assasin"}
                     },
                    Favorite = false
                }
            };
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }

            return comicBookToReturn;
        }
    }
}