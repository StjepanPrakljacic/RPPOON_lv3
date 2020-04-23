using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_lv3
{
    class NotificationDirector
    {
        public ConsoleNotification CreateINFONotification(string author)
        {

            NotificationBuilder note = new NotificationBuilder();
            note.SetAuthor(author);
            note.SetTitle("title");
            note.SetLevel(Category.INFO);
            note.SetColor(ConsoleColor.White);
            note.SetText("TEXT");

            return note.Build();
        }

        public ConsoleNotification CreateERRORNotification(string author)
        {

            NotificationBuilder note = new NotificationBuilder();
            note.SetAuthor(author);
            note.SetTitle("title");
            note.SetLevel(Category.ERROR);
            note.SetColor(ConsoleColor.Red);
            note.SetText("TEXT");

            return note.Build();
        }

        public ConsoleNotification CreateALERTNotification(string author)
        {

            NotificationBuilder note = new NotificationBuilder();
            note.SetAuthor(author);
            note.SetTitle("title");
            note.SetLevel(Category.ALERT);
            note.SetColor(ConsoleColor.Blue);
            note.SetText("TEXT");

            return note.Build();
        }
    }
}
