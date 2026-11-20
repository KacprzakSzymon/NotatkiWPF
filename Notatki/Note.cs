using System;
using System.Collections.Generic;
using System.Text;

namespace Notatki
{
    public class Note
    {
        public string Content { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
